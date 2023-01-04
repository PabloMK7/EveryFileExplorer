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

namespace MarioKart.MK7
{
    public class BCTR : FileFormat<BCTR.BCTRIdentifier>, IViewable
    {
		public BCTRHeader Header;
		public BCTRControlInfo ControlInfo;
		public BCTRElementInfo ElementInfo;
		public BCTRNameData NormalNameData;
		public List<BCTRRootElement> RootElements;
		public List<BCTRNormalElement> NormalElements;

		public class BCTRHeader
        {
			[BinaryStringSignature("BCTR")]
			[BinaryFixedSize(4)]
			public String Signature;
			public UInt32 Unknown;

			public BCTRHeader(EndianBinaryReaderEx er)
			{
				er.ReadObject(this);
			}
		}

		public class BCTRControlInfo
        {
			public UInt16 nameType1;
			public UInt16 nameOffset1;
			public UInt16 nameType2;
			public UInt16 nameOffset2;

			public String Name1;
			public String Name2;

			public BCTRControlInfo(EndianBinaryReaderEx er)
            {
				nameType1 = er.ReadUInt16();
				nameOffset1 = er.ReadUInt16();
				nameType2 = er.ReadUInt16();
				nameOffset2 = er.ReadUInt16();
            }

			public void PopulateNames(BCTRNameData nameData)
            {
				Name1 = nameData.GetName(nameOffset1);
				Name2 = nameData.GetName(nameOffset2);
            }
        }

		public class BCTRRootElement
        {
			public UInt16 nameOffset;
			public UInt16 Unknown;
			public String Name;
			public BCTRRootElement(EndianBinaryReaderEx er, BCTRNameData nameData)
            {
				nameOffset = er.ReadUInt16();
				Unknown = er.ReadUInt16();
				Name = nameData.GetName(nameOffset);
            }
        }

		public class BCTRNormalElement
        {
			public UInt16 nameOffset;
			public bool IsTopScreen;
			public Vector3 Offset;
			public UInt32 Unknown2;
			public String Name;
			public BCTRNormalElement(EndianBinaryReaderEx er, BCTRNameData nameData)
			{
				nameOffset = er.ReadUInt16();
				IsTopScreen = er.ReadUInt16() == 0;
				Offset = er.ReadVector3();
				Unknown2 = er.ReadUInt32();
				Name = nameData.GetName(nameOffset);
			}
		}

		public class BCTRElementInfo
        {
			public UInt16 RootElementCount;
			public UInt16 IDKElementCount;
			public UInt16[] UnknownElementCount;
			public UInt16 NormalElementCount;

			public UInt32 RootElementOffset;
			public UInt32 IDKElementOffset;
			public UInt32[] UnknownElementOffset;
			public UInt32 NormalElementOffset;

			public UInt32[] UnknownElementNameDataOffset;
			public UInt32 NormalElementNameDataOffset;

			public BCTRElementInfo(EndianBinaryReaderEx er)
			{
				RootElementCount = er.ReadUInt16();
				IDKElementCount = er.ReadUInt16();
				UnknownElementCount = er.ReadUInt16s(3);
				NormalElementCount = er.ReadUInt16();

				RootElementOffset = er.ReadUInt32();
				IDKElementOffset = er.ReadUInt32();
				UnknownElementOffset = er.ReadUInt32s(3);
				NormalElementOffset = er.ReadUInt32();

				UnknownElementNameDataOffset = er.ReadUInt32s(3);
				NormalElementNameDataOffset = er.ReadUInt32(); 
			}
		}

		public class BCTRNameData
        {
			public UInt32 SectionSize;
			public byte[] Data;
			public BCTRNameData(EndianBinaryReaderEx er)
			{
				SectionSize = er.ReadUInt32();
				Data = er.ReadBytes((int)SectionSize);
			}

			public String GetName(UInt32 offset)
            {
				int count = Array.FindIndex<byte>(Data, (int)offset, (x) => x == 0);
				return Encoding.ASCII.GetString(Data, (int)offset, count - (int)offset);
            }
		}

		public BCTR()
        {

        }
		public BCTR(byte[] Data)
        {
			EndianBinaryReaderEx er = new EndianBinaryReaderEx(new MemoryStream(Data), Endianness.LittleEndian);
			Header = new BCTRHeader(er);
			ControlInfo = new BCTRControlInfo(er);
			ElementInfo = new BCTRElementInfo(er);
			er.BaseStream.Position = ElementInfo.NormalElementNameDataOffset;
			NormalNameData = new BCTRNameData(er);

			RootElements = new List<BCTRRootElement>();
			NormalElements = new List<BCTRNormalElement>();

			er.BaseStream.Position = ElementInfo.RootElementOffset;
			for (int i = 0; i < ElementInfo.RootElementCount; i++)
            {
				RootElements.Add(new BCTRRootElement(er, NormalNameData));
            }

			er.BaseStream.Position = ElementInfo.NormalElementOffset;
			for (int i = 0; i < ElementInfo.NormalElementCount; i++)
            {
				NormalElements.Add(new BCTRNormalElement(er, NormalNameData));            
			}

			ControlInfo.PopulateNames(NormalNameData);
		}
		
        public Form GetDialog()
        {
			return new Form();
        }

        public class BCTRIdentifier : FileFormatIdentifier
		{
			public override string GetCategory()
			{
				return "Mario Kart 7";
			}

			public override string GetFileDescription()
			{
				return "Mario Kart 7 Binary Control (BCTR)";
			}

			public override string GetFileFilter()
			{
				return "Mario Kart 7 Binary Control (*.bctr)|*.bctr";
			}

			public override Bitmap GetIcon()
			{
				return Resource.config_bctr;
			}

			public override FormatMatch IsFormat(EFEFile File)
			{
				if (File.Data.Length > 4 && File.Data[0] == 'B' && File.Data[1] == 'C' && File.Data[2] == 'T' && File.Data[3] == 'R') return FormatMatch.Content;
				return FormatMatch.No;
			}
		}
	}
}
