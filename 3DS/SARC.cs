using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using LibEveryFileExplorer.Files;
using System.Drawing;
using System.IO;
using LibEveryFileExplorer.Files.SimpleFileSystem;
using _3DS.UI;
using LibEveryFileExplorer.IO;
using LibEveryFileExplorer.IO.Serialization;
using System.Security.Cryptography;
using System.Collections;

namespace _3DS
{
	public class SARC : FileFormat<SARC.SARCIdentifier>, IViewable, IWriteable
	{
		public SARC(byte[] Data)
		{
			EndianBinaryReaderEx er = new EndianBinaryReaderEx(new MemoryStream(Data), Endianness.LittleEndian);
			try
			{
				Header = new SARCHeader(er);
				SFat = new SFAT(er);
				SFnt = new SFNT(er);
				er.BaseStream.Position = Header.FileDataOffset;
				this.Data = er.ReadBytes((int)(Header.FileSize - Header.FileDataOffset));
			}
			finally
			{
				er.Close();
			}
		}

		public System.Windows.Forms.Form GetDialog()
		{
			return new SARCViewer(this);
		}

		public string GetSaveDefaultFileFilter()
		{
			return "Simple Archive (*.sarc)|*.sarc";
		}

        public readonly string[] MK7_szs_extensions = { "_map.bclim", "_map2.bclim", ".div", ".kcl", ".kmp", ".bcmdl", ".bclgt", ".bcfog", "_ch0.bclgt", "_ch1.bclgt", "_ch2.bclgt", "_ch3.bclgt", "_ch4.bclgt", "_ch5.bclgt" };

        public byte[] Write()
		{
			MemoryStream m = new MemoryStream();
			EndianBinaryWriter er = new EndianBinaryWriter(m, Endianness.LittleEndian);
			Header.Write(er);
			SFat.Write(er);
			SFnt.Write(er);
			while ((er.BaseStream.Position % 128) != 0) er.Write((byte)0);
			er.Write(Data, 0, Data.Length);
			er.BaseStream.Position = 8;
			er.Write((UInt32)(er.BaseStream.Length));
			byte[] result = m.ToArray();
			er.Close();
			return result;
		}

        public string SarcFilename = null;

		public SARCHeader Header;
		public class SARCHeader
		{
			public SARCHeader()
			{
				Signature = "SARC";
				HeaderSize = 0x14;
				Endianness = 0xFFFE;//0xFEFF;
				FileSize = 0;
				FileDataOffset = 0;
				Unknown = 0x0100;
			}
			public SARCHeader(EndianBinaryReaderEx er)
			{
				er.ReadObject(this);
			}
			public void Write(EndianBinaryWriter er)
			{
				er.Write(Signature, Encoding.ASCII, false);
				er.Write(HeaderSize);
				er.Endianness = LibEveryFileExplorer.IO.Endianness.BigEndian;
				er.Write(Endianness);
				if (Endianness == 0xFFFE) er.Endianness = LibEveryFileExplorer.IO.Endianness.LittleEndian;
				er.Write(FileSize);
				er.Write(FileDataOffset);
				er.Write(Unknown);
			}
			[BinaryStringSignature("SARC")]
			[BinaryFixedSize(4)]
			public String Signature;
			public UInt16 HeaderSize;
			[BinaryBOM(0xFFFE)]
			public UInt16 Endianness;
			public UInt32 FileSize;
			public UInt32 FileDataOffset;
			public UInt32 Unknown;
		}

		public SFAT SFat;
		public class SFAT
		{
			public SFAT()
			{
				Signature = "SFAT";
				HeaderSize = 0xC;
				NrEntries = 0;
				HashMultiplier = 0x65;
				Entries = new List<SFATEntry>();
			}
			public SFAT(EndianBinaryReaderEx er)
			{
				Signature = er.ReadString(Encoding.ASCII, 4);
				if (Signature != "SFAT") throw new SignatureNotCorrectException(Signature, "SFAT", er.BaseStream.Position - 4);
				HeaderSize = er.ReadUInt16();
				NrEntries = er.ReadUInt16();
				HashMultiplier = er.ReadUInt32();
				Entries = new List<SFATEntry>();
				for (int i = 0; i < NrEntries; i++)
				{
					Entries.Add(new SFATEntry(er));
				}
			}
			public void Write(EndianBinaryWriter er)
			{
				NrEntries = (ushort)Entries.Count;
				er.Write(Signature, Encoding.ASCII, false);
				er.Write(HeaderSize);
				er.Write(NrEntries);
				er.Write(HashMultiplier);
				foreach (var v in Entries) v.Write(er);
			}

			public String Signature;
			public UInt16 HeaderSize;
			public UInt16 NrEntries;
			public UInt32 HashMultiplier;
			public List<SFATEntry> Entries;
			public class SFATEntry
			{
				public SFATEntry() { }
				public SFATEntry(EndianBinaryReaderEx er)
				{
					er.ReadObject(this);
				}
				public void Write(EndianBinaryWriter er)
				{
					er.Write(FileNameHash);
					er.Write(FileNameOffset);
					er.Write(FileDataStart);
					er.Write(FileDataEnd);
				}

				public UInt32 FileNameHash;
				public UInt32 FileNameOffset;//If filenames are available
				public UInt32 FileDataStart;
				public UInt32 FileDataEnd;
			}
		}

		public SFNT SFnt;
		public class SFNT
		{
			public SFNT()
			{
				Signature = "SFNT";
				HeaderSize = 8;
				Unknown1 = 0;
			}
			public SFNT(EndianBinaryReaderEx er)
			{
				Signature = er.ReadString(Encoding.ASCII, 4);
				if (Signature != "SFNT") throw new SignatureNotCorrectException(Signature, "SFNT", er.BaseStream.Position - 4);
				HeaderSize = er.ReadUInt16();
				Unknown1 = er.ReadUInt16();
			}
			public void Write(EndianBinaryWriter er)
			{
				er.Write(Signature, Encoding.ASCII, false);
				er.Write(HeaderSize);
				er.Write(Unknown1);
			}

			public String Signature;
			public UInt16 HeaderSize;
			public UInt16 Unknown1; // Probably padding, used for custom flags in EFE.

			public bool CompressDuplicateFiles {
				get
				{
					return (Unknown1 & 1) == 1;
				}
				set
				{
                    Unknown1 = (ushort)((Unknown1 & ~1) | (value ? 1 : 0));
                }
			}
		}

		private class SARCDataBuilder
		{
			private class FileEntry
			{
				public long position;
				public FileEntry(long position)
				{
					this.position = position;
				}
			}

            // From https://gist.github.com/manbeardgames/1d9b97278f71294b254e0b6672282dfd
            public class ByteArrayComparer : IEqualityComparer<byte[]>
            {
                public bool Equals(byte[] obj1, byte[] obj2)
                {
                    return StructuralComparisons.StructuralEqualityComparer.Equals(obj1, obj2);
                }
                public int GetHashCode(byte[] obj)
                {
                    return StructuralComparisons.StructuralEqualityComparer.GetHashCode(obj);
                }
            }

            public SARCDataBuilder(bool duplicateFileCompress)
			{
				DuplicateFileCompress = duplicateFileCompress;
				FileDataHashes = new Dictionary<byte[], FileEntry>(new ByteArrayComparer());
				MemoryStream = new MemoryStream();
				MD5Provider = MD5.Create();
			}

			public long Append(SFSFile file)
			{
				if (DuplicateFileCompress)
				{
                    byte[] fileHash = MD5Provider.ComputeHash(file.Data);
                    FileEntry outEntry;
                    if (FileDataHashes.TryGetValue(fileHash, out outEntry))
                    {
                        return outEntry.position;
                    }
					while ((MemoryStream.Position % 128) != 0)
						MemoryStream.WriteByte(0);
					long start = MemoryStream.Position;
					MemoryStream.Write(file.Data, 0, file.Data.Length);
					outEntry = new FileEntry(start);
					FileDataHashes.Add(fileHash, outEntry);
					return start;
                } else
				{
                    while ((MemoryStream.Position % 128) != 0)
                        MemoryStream.WriteByte(0);
                    long start = MemoryStream.Position;
                    MemoryStream.Write(file.Data, 0, file.Data.Length);
					return start;
                }
			}

			public byte[] Get()
			{
				return MemoryStream.ToArray();
			}

			private bool DuplicateFileCompress = false;
			private Dictionary<byte[], FileEntry> FileDataHashes;
			private MemoryStream MemoryStream;
			private MD5 MD5Provider;
		}

		public byte[] Data;

		public byte[] GetFileDataByIndex(int Index)
		{
			if (SFat.Entries.Count <= Index) return null;
			SFAT.SFATEntry v = SFat.Entries[Index];
			uint start = v.FileDataStart;
			uint length = v.FileDataEnd - start;
			byte[] Result = new byte[length];
			Array.Copy(Data, start, Result, 0, length);
			return Result;
		}

		public byte[] GetFileDataByHash(UInt32 Hash)
		{
			foreach (SFAT.SFATEntry v in SFat.Entries)
			{
				if (v.FileNameHash == Hash)
				{
					uint start = v.FileDataStart;
					uint length = v.FileDataEnd - start;
					byte[] Result = new byte[length];
					Array.Copy(Data, start, Result, 0, length);
					return Result;
				}
			}
			return null;
		}

		public UInt32 GetHashFromName(String Name)
		{
			return GetHashFromName(Name, SFat.HashMultiplier);
		}

		public static UInt32 GetHashFromName(String Name, UInt32 HashMultiplier)
		{
			uint res = 0;
			for (int i = 0; i < Name.Length; i++)
			{
				res = Name[i] + res * HashMultiplier;
			}
			return res;
		}

        public bool checkHashExists(uint Hash)
        {
            foreach(var v in SFat.Entries)
            {
                if (v.FileNameHash == Hash) return true;
            }
            return false;
        }

		public SFSDirectory ToFileSystem()
		{
			SFSDirectory Root = new SFSDirectory("/", true);
            foreach (var v in SFat.Entries)
			{
				var q = new SFSFile((int)v.FileNameHash, string.Format("0x{0:X8}", v.FileNameHash), Root);
                bool NameFound = false;
				if (SARCHashTable.DefaultHashTable != null)
				{
					var vv = SARCHashTable.DefaultHashTable.GetEntryByHash(v.FileNameHash);
                    if (vv != null) { q.FileName = vv.Name; NameFound = true; }
				}
                if (SarcFilename != null && !NameFound)
                {
                    var SarcName = System.IO.Path.GetFileNameWithoutExtension(SarcFilename);
                    foreach (var ext in MK7_szs_extensions)
                    {
                        string vv = SarcName + ext;
                        if (v.FileNameHash == GetHashFromName(vv))
                        {
                            q.FileName = vv;
                        }
                    }
                }
				q.Data = GetFileDataByHash(v.FileNameHash);
				Root.Files.Add(q);
			}
            return Root;
		}

		public void FromFileSystem(SFSDirectory Root)
		{
			Header = new SARCHeader();
			SFat = new SFAT();
			SFat.NrEntries = (ushort)Root.Files.Count;
			bool CompressDuplicateFiles = SFnt != null ? SFnt.CompressDuplicateFiles : false;
            SARCDataBuilder DataBuilder = new SARCDataBuilder(CompressDuplicateFiles);
            Root.Files.Sort(delegate (SFSFile a, SFSFile b) {
                uint hasha = (uint)a.FileID;
                uint hashb = (uint)b.FileID;
                return hasha.CompareTo(hashb);
            });
			foreach(var v in Root.Files)
			{
                uint hash = (uint)v.FileID;
				long DataStart = DataBuilder.Append(v);
                SFat.Entries.Add(new SFAT.SFATEntry() { FileDataStart = (uint)DataStart, FileDataEnd = (uint)(DataStart + v.Data.Length), FileNameHash = hash, FileNameOffset = 0 });
            }
			Data = DataBuilder.Get();
            SFnt = new SFNT();
			SFnt.CompressDuplicateFiles = CompressDuplicateFiles;
            Header.FileSize = (uint)(0x14 + 0xC + SFat.NrEntries * 0x10 + 0x8);
            while ((Header.FileSize % 128) != 0) Header.FileSize++;
            Header.FileDataOffset = Header.FileSize;
            Header.FileSize += (uint)Data.Length;
        }

        public class SARCIdentifier : FileFormatIdentifier
        {
            public override string GetCategory()
            {
            return Category_Archives;
            }
			
			public override string GetFileDescription()
			{
				return "Simple Archive (SARC)";
			}

			public override string GetFileFilter()
			{
				return "Simple Archive (*.sarc, *.szs)|*.sarc;*.szs";
			}

			public override Bitmap GetIcon()
			{
				return null;
			}

			public override FormatMatch IsFormat(EFEFile File)
			{
				if (File.Data.Length > 20 && File.Data[0] == 'S' && File.Data[1] == 'A' && File.Data[2] == 'R' && File.Data[3] == 'C' && File.Data[0x14] == 'S' && File.Data[0x15] == 'F' && File.Data[0x16] == 'A' && File.Data[0x17] == 'T') return FormatMatch.Content;
				return FormatMatch.No;
			}

		}
	}
}
