using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using LibEveryFileExplorer;
using LibEveryFileExplorer.Script;
using System.IO;
using CommonFiles;
using LibEveryFileExplorer.IO;

namespace MarioKart
{
	public class MarioKartPlugin : EFEPlugin
	{
		public override void OnLoad()
		{
			EFEScript.RegisterCommand("MarioKart.MKDS.KCL.Generate", (Action<String, String, Dictionary<String, ushort>>)MarioKart_MKDS_KCL_Generate);
            EFEScript.RegisterCommand("MarioKart.MK7.KCL.Regenerate", (Action<String, String>)MarioKart_MK7_KCL_Regenerate);
        }

        public static void MarioKart_MK7_KCL_Regenerate(String OrigPath, String NewPath)
        {
            MK7.KCL oldkcl = new MK7.KCL(File.ReadAllBytes(OrigPath));
            List<LibEveryFileExplorer._3D.Triangle> trilist = new List<LibEveryFileExplorer._3D.Triangle>();
            foreach (var v in oldkcl.Planes)
            {
                trilist.Add(oldkcl.GetTriangle(v));
            }
            oldkcl.Octree = KCLOctree.FromTriangles(trilist.ToArray(), oldkcl.Header, 2048, 128, 32, 10, null, null);
            File.WriteAllBytes(NewPath, oldkcl.Write());
        }

		public static void MarioKart_MKDS_KCL_Generate(String OBJPath, String OutPath, Dictionary<String, ushort> TypeMapping)
		{
			MKDS.KCL k = new MKDS.KCL();
			OBJ o = new OBJ(File.ReadAllBytes(OBJPath));
			List<String> matnames = new List<string>();
			foreach (var v in o.Faces) if (!matnames.Contains(v.Material)) matnames.Add(v.Material);
			Dictionary<string, bool> Colli = new Dictionary<string,bool>();
			foreach (string s in matnames)
			{
				if (!TypeMapping.ContainsKey(s)) TypeMapping.Add(s, 0);
				Colli.Add(s, true);
			}
			k.FromOBJ(o, TypeMapping, Colli);
			File.Create(OutPath).Close();
			File.WriteAllBytes(OutPath, k.Write());
		}
	}
}
