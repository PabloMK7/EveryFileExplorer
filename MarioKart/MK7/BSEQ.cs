using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LibEveryFileExplorer.Files;
using LibEveryFileExplorer.Collections;
using LibEveryFileExplorer._3D;
using CommonFiles;
using LibEveryFileExplorer.IO;
using System.Drawing;
using System.Windows.Forms;
using LibEveryFileExplorer.IO.Serialization;
using System.IO;
using System.Collections;

namespace MarioKart.MK7
{
	public class BSEQManager
    {
		private static BSEQManager Singleton = null;
		private Hashtable Hash;
		private BSEQManager()
        {
			Hash = new Hashtable();
		}
		public static BSEQManager GetInstance()
        {
			if (Singleton == null) Singleton = new BSEQManager();

			return Singleton;
        }
		public void AddSectionBlock(UInt32 sequenceID, BSEQ.BSEQSectionBlock sectionBlock)
        {
			if (!Hash.ContainsKey(sequenceID))
				Hash.Add(sequenceID, sectionBlock);
        }
		public BSEQ.BSEQSectionBlock GetSectionBlockForSequenceID(UInt32 sequenceID)
		{
			if (Hash.ContainsKey(sequenceID))
				return ((BSEQ.BSEQSectionBlock)Hash[sequenceID]);
			return null;
		}
	}
    public class BSEQ : FileFormat<BSEQ.BSEQIdentifier>, IViewable
    {
		public BSEQHeader Header;
		public BSEQNameTable NameTable;
		public List<BSEQSectionBlock> SectionBlocks;
		public List<BSEQEngineCreatorEntry> EngineCreatorEntries;
		public BSEQ()
        {

        }
		public BSEQ(byte[] Data)
        {
			EndianBinaryReaderEx er = new EndianBinaryReaderEx(new MemoryStream(Data), Endianness.LittleEndian);
			Header = new BSEQHeader(er);
			UInt32[] sectionBlockOffsets = er.ReadUInt32s(Header.SectionBlockCount);
			er.BaseStream.Position = Header.NameTableOffset;
			NameTable = new BSEQNameTable(er);
			er.BaseStream.Position = Header.EngineCreatorTableOffset;
			EngineCreatorEntries = new List<BSEQEngineCreatorEntry>();
			for (int i = 0; i < Header.EngineCreatorCount; i++)
            {
				EngineCreatorEntries.Add(new BSEQEngineCreatorEntry(er, NameTable));
            }
			SectionBlocks = new List<BSEQSectionBlock>();
			for (int i = 0; i < sectionBlockOffsets.Length; i++)
            {
				er.BaseStream.Position = sectionBlockOffsets[i];
				UInt16 BlockType = BSEQSectionBlock.GetBlockType(er);
				switch ((BSEQSectionBlockType)BlockType)
                {
					case BSEQSectionBlockType.PracticalSectionTask:
					case BSEQSectionBlockType.PracticalSectionPage:
						SectionBlocks.Add(new BSEQPracticalSectionBlock(er, NameTable));
						break;
					case BSEQSectionBlockType.SequenceSection:
						SectionBlocks.Add(new BSEQSecuenceSectionBlock(er, NameTable));
						break;
					case BSEQSectionBlockType.SceneSequenceProxySection:
						SectionBlocks.Add(new BSEQSceneSequenceProxySectionBlock(er, NameTable));
						break;
					default:
						throw new NotImplementedException("Unknown BlockType (" + BlockType + ") at position 0x" + String.Format("0x{0:X}", er.BaseStream.Position));
                }
            }
		}
		public class BSEQHeader
        {
			[BinaryStringSignature("BSEQ")]
			[BinaryFixedSize(4)]
			public String Signature;
			public UInt32 InitialSequenceID;
			public UInt16 InitialSequenceID2;
			public UInt16 Unknown1;
			public UInt16 Unknown2;
			public UInt16 Unknown3;
			public UInt16 Unknown4;
			public UInt16 Unknown5;
			public UInt16 Unknown6;
			public UInt16 Unknown7;
			public UInt16 Unknown8;
			public UInt16 Unknown9;
			public UInt16 SectionBlockCount;
			public UInt16 EngineCreatorCount;
			public UInt32 Unknown10;
			public UInt32 Unknown11;
			public UInt32 SectionTableOffset;
			public UInt32 EngineCreatorTableOffset;
			public UInt32 NameTableOffset;

			public BSEQHeader(EndianBinaryReaderEx er)
            {
				er.ReadObject(this);
            }
		}
		public class BSEQNameOffset
        {
			String Value;
			public BSEQNameOffset(EndianBinaryReaderEx er, BSEQNameTable nameTable)
            {
				UInt16 offset = er.ReadUInt16();
				Value = nameTable.GetNameFromOffset(offset);
            }
			public override String ToString()
            {
				return Value.ToString();
            }
        }
		public class BSEQSequenceID
        {
			public UInt32 SequenceID;
			public BSEQSequenceID(EndianBinaryReaderEx er)
			{
				SequenceID = er.ReadUInt32();
			}
			public void RegisterSectionBlock(BSEQSectionBlock sectionBlock)
            {
				if (sectionBlock != null) BSEQManager.GetInstance().AddSectionBlock(SequenceID, sectionBlock);
			}
            public override string ToString()
            {
				BSEQSectionBlock block = BSEQManager.GetInstance().GetSectionBlockForSequenceID(SequenceID);
				if (block == null) return SequenceID.ToString();
				else return block.Name.ToString();
			}
        }
		public class BSEQCodeNamePair
        {
			public UInt16 ID;
			public BSEQNameOffset NameOffset;
			public BSEQCodeNamePair(EndianBinaryReaderEx er, BSEQNameTable nameTable)
            {
				ID = er.ReadUInt16();
				NameOffset = new BSEQNameOffset(er, nameTable);
            }
			public override string ToString()
			{
				return "ID: " + ID + ", Name: " + NameOffset;
			}
		}
		public class BSEQCodeNameList
        {
			public UInt16 DefaultID;
			public List<BSEQCodeNamePair> Entries;
			public BSEQCodeNameList(EndianBinaryReaderEx er, BSEQNameTable nameTable)
            {
				UInt16 entryCount = er.ReadUInt16();
				DefaultID = er.ReadUInt16();
				Entries = new List<BSEQCodeNamePair>();
				for (int i = 0; i < entryCount; i++)
                {
					Entries.Add(new BSEQCodeNamePair(er, nameTable));
                }
            }
			public BSEQCodeNamePair GetEntryFromID(UInt16 id)
			{
				BSEQCodeNamePair def = null;
				for (int i = 0; i < Entries.Count; i++)
                {
					if (Entries[i].ID == id) return Entries[i];
					else if (Entries[i].ID == DefaultID) def = Entries[i];
				}
				if (def != null) return def;
				else throw new InvalidDataException("Default ID doesn't exist in list.");			
			}
		}
		public enum BSEQSectionBlockType
        {
			PracticalSectionTask = 0,
			PracticalSectionPage = 1,
			SequenceSection = 2,
			CrossFadeSection = 3,
			SceneSequenceProxySection = 4
        }
		public abstract class BSEQSectionBlock
        {
			public SByte SectionType;
			public BSEQSequenceID SequenceID;
			public BSEQNameOffset Name;
			public BSEQCodeNameList EnterCodeList;
			public BSEQCodeNameList ExitCodeList;
			public UInt16 BlockType;
			public UInt16 Unknown;

			static public UInt16 GetBlockType(EndianBinaryReaderEx er)
            {
				long prevPosition = er.BaseStream.Position;
				er.BaseStream.Position += 0xE;
				UInt16 ret = er.ReadUInt16();
				er.BaseStream.Position = prevPosition;
				return ret;
            }
        }
		public class BSEQPracticalBlock
        {
			public UInt16 SequenceID2;
			public BSEQNameOffset PracticalName;
			public BSEQCodeNameList PracticalSubNameList;
			public UInt16 Unknown;
			public BSEQPracticalBlock(EndianBinaryReaderEx er, BSEQNameTable nameTable)
            {
				long startPosition = er.BaseStream.Position;
				SequenceID2 = er.ReadUInt16();
				PracticalName = new BSEQNameOffset(er, nameTable);
				UInt16 practicalSubNameListOffset = er.ReadUInt16();
				Unknown = er.ReadUInt16();
				er.BaseStream.Position = startPosition + practicalSubNameListOffset;
				PracticalSubNameList = new BSEQCodeNameList(er, nameTable);
            }
        }
		public class BSEQPracticalSectionBlock : BSEQSectionBlock
        {
			public BSEQPracticalBlock PracticalBlock;
			public BSEQPracticalSectionBlock(EndianBinaryReaderEx er, BSEQNameTable nameTable)
            {
				long startPos = er.BaseStream.Position;
				SectionType = (SByte)er.ReadUInt32();
				SequenceID = new BSEQSequenceID(er);
				Name = new BSEQNameOffset(er, nameTable);
				UInt16 enterTableOffset = er.ReadUInt16();
				UInt16 exitTableOffset = er.ReadUInt16();
				BlockType = er.ReadUInt16();
				UInt16 practicalBlockOffset = er.ReadUInt16();
				Unknown = er.ReadUInt16();
				er.BaseStream.Position = startPos + enterTableOffset;
				EnterCodeList = new BSEQCodeNameList(er, nameTable);
				er.BaseStream.Position = startPos + exitTableOffset;
				ExitCodeList = new BSEQCodeNameList(er, nameTable);
				er.BaseStream.Position = startPos + practicalBlockOffset;
				PracticalBlock = new BSEQPracticalBlock(er, nameTable);

				SequenceID.RegisterSectionBlock(this);
			}
			public override string ToString()
			{
				return Name + " (PracticalSection)";
			}
		}
		public class BSEQSubSectionEntry
        {
			public BSEQSequenceID SequenceID;
			public UInt32 ID;
			public BSEQSubSectionEntry(EndianBinaryReaderEx er)
            {
				SequenceID = new BSEQSequenceID(er);
				ID = er.ReadUInt32();
            }
            public override string ToString()
            {
				return SequenceID.ToString() + " (" + ID + ")";
			}
        }
		public class BSEQSubSectionTable
        {
			public UInt16 Unknown;
			public List<BSEQSubSectionEntry> Entries;
			public BSEQSubSectionTable(EndianBinaryReaderEx er)
			{
				Entries = new List<BSEQSubSectionEntry>();
				UInt16 entryCount = er.ReadUInt16();
				Unknown = er.ReadUInt16();
				for (int i = 0; i < entryCount; i++)
				{
					Entries.Add(new BSEQSubSectionEntry(er));
				}
			}
		}
		public class BSEQFlowEntry
        {
			public Int16 srcSubSeq;
			public UInt16 srcID;
			public Int16 dstSubSeq;
			public UInt16 dstID;

			public BSEQSequenceID OwnSequenceID;
			public BSEQFlowEntry(EndianBinaryReaderEx er, BSEQSequenceID seqID)
            {
				srcSubSeq = er.ReadInt16();
				srcID = er.ReadUInt16();
				dstSubSeq = er.ReadInt16();
				dstID = er.ReadUInt16();

				OwnSequenceID = seqID;
            }
			public String PrintBasicInfo()
            {
				return "Src: " + srcID + " (" + srcSubSeq + "), Dst: " + dstID + "(" + dstSubSeq + ")";

			}
			public override string ToString()
            {
				BSEQSectionBlock block = BSEQManager.GetInstance().GetSectionBlockForSequenceID(OwnSequenceID.SequenceID);
				if (block == null || !(block is BSEQSecuenceSectionBlock)) return PrintBasicInfo();

				BSEQSecuenceSectionBlock seqBlock = block as BSEQSecuenceSectionBlock;

				BSEQSectionBlock srcBlock = (srcSubSeq == -1) ? seqBlock : BSEQManager.GetInstance().GetSectionBlockForSequenceID(seqBlock.SequenceBlock.SubSectionTable.Entries[srcSubSeq].SequenceID.SequenceID);
				BSEQSectionBlock dstBlock = (dstSubSeq == -1) ? seqBlock : BSEQManager.GetInstance().GetSectionBlockForSequenceID(seqBlock.SequenceBlock.SubSectionTable.Entries[dstSubSeq].SequenceID.SequenceID);

				String srcName = srcBlock.Name.ToString() + "::" + srcBlock.ExitCodeList.GetEntryFromID(srcID).NameOffset.ToString();
				String dstName = dstBlock.Name.ToString() + "::" + dstBlock.EnterCodeList.GetEntryFromID(dstID).NameOffset.ToString();
				return srcName + " -> " + dstName;
			}
        }
		public class BSEQFlowTable
        {
			public UInt16 Unknown;
			public List<BSEQFlowEntry> Entries;
			public BSEQFlowTable(EndianBinaryReaderEx er, BSEQSequenceID seqID)
            {
				Entries = new List<BSEQFlowEntry>();
				UInt16 entryCount = er.ReadUInt16();
				Unknown = er.ReadUInt16();
				for (int i = 0; i < entryCount; i++)
                {
					Entries.Add(new BSEQFlowEntry(er, seqID));
                }
            }
        }
		public class BSEQSequenceBlock
        {
			public UInt16 SequenceID2;
			public BSEQNameOffset SequenceName;
			public BSEQSubSectionTable SubSectionTable;
			public BSEQFlowTable FlowTable;
			public BSEQSequenceBlock(EndianBinaryReaderEx er, BSEQNameTable nameTable, BSEQSequenceID seqID)
            {
				long startPos = er.BaseStream.Position;
				SequenceID2 = er.ReadUInt16();
				SequenceName = new BSEQNameOffset(er, nameTable);
				UInt16 subSectionOffset = er.ReadUInt16();
				UInt16 flowOffset = er.ReadUInt16();
				er.BaseStream.Position = startPos + subSectionOffset;
				SubSectionTable = new BSEQSubSectionTable(er);
				er.BaseStream.Position = startPos + flowOffset;
				FlowTable = new BSEQFlowTable(er, seqID);
            }
        }
		public class BSEQSecuenceSectionBlock : BSEQSectionBlock
        {
			public BSEQSequenceBlock SequenceBlock;
			public BSEQSecuenceSectionBlock(EndianBinaryReaderEx er, BSEQNameTable nameTable) {
				long startPos = er.BaseStream.Position;
				SectionType = (SByte)er.ReadUInt32();
				SequenceID = new BSEQSequenceID(er);
				Name = new BSEQNameOffset(er, nameTable);
				UInt16 enterTableOffset = er.ReadUInt16();
				UInt16 exitTableOffset = er.ReadUInt16();
				BlockType = er.ReadUInt16();
				UInt16 sequenceBlockOffset = er.ReadUInt16();
				Unknown = er.ReadUInt16();
				er.BaseStream.Position = startPos + enterTableOffset;
				EnterCodeList = new BSEQCodeNameList(er, nameTable);
				er.BaseStream.Position = startPos + exitTableOffset;
				ExitCodeList = new BSEQCodeNameList(er, nameTable);
				er.BaseStream.Position = startPos + sequenceBlockOffset;
				SequenceBlock = new BSEQSequenceBlock(er, nameTable, SequenceID);

				SequenceID.RegisterSectionBlock(this);
			}
            public override string ToString()
            {
				return Name + " (SequenceSection)";
			}
        }
		public class BSEQSceneSequenceProxyBlock
        {
			public UInt16 Count; //Always 1
			public BSEQNameOffset UnknownName;
			public BSEQNameOffset SceneName;
			public UInt16 Unknown;
			public BSEQSceneSequenceProxyBlock(EndianBinaryReaderEx er, BSEQNameTable nameTable)
            {
				Count = er.ReadUInt16();
				if (Count != 1) throw new InvalidDataException("ProxyBlock Count not 1: (" + Count + ")");
				UnknownName = new BSEQNameOffset(er, nameTable);
				SceneName = new BSEQNameOffset(er, nameTable);
				Unknown = er.ReadUInt16();
            }
		}
		public class BSEQSceneSequenceProxySectionBlock : BSEQSectionBlock
        {
			BSEQSceneSequenceProxyBlock ProxyBlock;
			public BSEQSceneSequenceProxySectionBlock(EndianBinaryReaderEx er, BSEQNameTable nameTable)
            {
				long startPos = er.BaseStream.Position;
				SectionType = (SByte)er.ReadUInt32();
				SequenceID = new BSEQSequenceID(er);
				Name = new BSEQNameOffset(er, nameTable);
				UInt16 enterTableOffset = er.ReadUInt16();
				UInt16 exitTableOffset = er.ReadUInt16();
				BlockType = er.ReadUInt16();
				UInt16 proxyBlockOffset = er.ReadUInt16();
				Unknown = er.ReadUInt16();
				er.BaseStream.Position = startPos + enterTableOffset;
				EnterCodeList = new BSEQCodeNameList(er, nameTable);
				er.BaseStream.Position = startPos + exitTableOffset;
				ExitCodeList = new BSEQCodeNameList(er, nameTable);
				er.BaseStream.Position = startPos + proxyBlockOffset;
				ProxyBlock = new BSEQSceneSequenceProxyBlock(er, nameTable);

				SequenceID.RegisterSectionBlock(this);
			}
			public override string ToString()
			{
				return Name + " (SceneSequenceProxy)";
			}
		}
		public class BSEQEngineCreatorEntry
        {
			BSEQNameOffset CreatorName;
			BSEQNameOffset TargetName;
			public BSEQEngineCreatorEntry(EndianBinaryReaderEx er, BSEQNameTable nameTable)
            {
				CreatorName = new BSEQNameOffset(er, nameTable);
				TargetName = new BSEQNameOffset(er, nameTable);
            }
        }
		public class BSEQNameTable
        {
			byte[] Data = null;
			public BSEQNameTable(EndianBinaryReaderEx er)
            {
				long size = er.BaseStream.Length - er.BaseStream.Position;
				Data = er.ReadBytes((int)size);
            }
			public String GetNameFromOffset(uint offset)
            {
				if (offset >= Data.Length) throw new IndexOutOfRangeException();
				StringBuilder stringBuilder = new StringBuilder();
				for (uint i = offset; i < Data.Length && Data[i] != '\0'; i++)
                {
					stringBuilder.Append((char)Data[i]);
                }
				return stringBuilder.ToString();
			}
        }
        public Form GetDialog()
        {
			return new Form();
        }

        public class BSEQIdentifier : FileFormatIdentifier
		{
			public override string GetCategory()
			{
				return "Mario Kart 7";
			}

			public override string GetFileDescription()
			{
				return "Mario Kart 7 Binary Scene Sequence (BSS)";
			}

			public override string GetFileFilter()
			{
				return "Mario Kart 7 Binary Scene Sequence (*.bss)|*.bss";
			}

			public override Bitmap GetIcon()
			{
				return Resource.config_bss;
			}

			public override FormatMatch IsFormat(EFEFile File)
			{
				if (File.Data.Length > 4 && File.Data[0] == 'B' && File.Data[1] == 'S' && File.Data[2] == 'E' && File.Data[3] == 'Q') return FormatMatch.Content;
				return FormatMatch.No;
			}
		}
	}
}
