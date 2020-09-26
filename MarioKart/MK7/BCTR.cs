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

		public BCTR()
        {

        }
		public BCTR(byte[] Data)
        {

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
