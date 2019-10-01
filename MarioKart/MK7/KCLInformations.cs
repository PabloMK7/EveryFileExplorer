using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using System.Xml.Serialization;

namespace MarioKart.MK7
{
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "", IsNullable = false)]
    public partial class KCLInformations
    {

        private KCLInformationsKCLType[] kCLTypeField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("KCLType")]
        public KCLInformationsKCLType[] KCLType
        {
            get
            {
                return this.kCLTypeField;
            }
            set
            {
                this.kCLTypeField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class KCLInformationsKCLType
    {

        private KCLInformationsKCLTypeBasicEffect[] basicEffectField;

        private byte idField;

        private string nameField;

        private string descriptionField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("BasicEffect")]
        public KCLInformationsKCLTypeBasicEffect[] BasicEffect
        {
            get
            {
                return this.basicEffectField;
            }
            set
            {
                this.basicEffectField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public byte id
        {
            get
            {
                return this.idField;
            }
            set
            {
                this.idField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string name
        {
            get
            {
                return this.nameField;
            }
            set
            {
                this.nameField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string description
        {
            get
            {
                return this.descriptionField;
            }
            set
            {
                this.descriptionField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class KCLInformationsKCLTypeBasicEffect
    {

        private byte idField;

        private string nameField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public byte id
        {
            get
            {
                return this.idField;
            }
            set
            {
                this.idField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string name
        {
            get
            {
                return this.nameField;
            }
            set
            {
                this.nameField = value;
            }
        }
    }

    /// <remarks/>
    [Serializable, XmlRoot("KclUserSettings")]
    public partial class KclUserSettings
    {

        private KclUserSettingsKclFile[] kclFileField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("KclFile")]
        public KclUserSettingsKclFile[] KclFile
        {
            get
            {
                return this.kclFileField;
            }
            set
            {
                this.kclFileField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class KclUserSettingsKclFile
    {

        private KclUserSettingsKclFileColEntry[] colEntryField;

        private string srcField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("colEntry")]
        public KclUserSettingsKclFileColEntry[] colEntry
        {
            get
            {
                return this.colEntryField;
            }
            set
            {
                this.colEntryField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string src
        {
            get
            {
                return this.srcField;
            }
            set
            {
                this.srcField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class KclUserSettingsKclFileColEntry
    {

        private string matField;

        private bool enableField;

        private ushort valField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string mat
        {
            get
            {
                return this.matField;
            }
            set
            {
                this.matField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool enable
        {
            get
            {
                return this.enableField;
            }
            set
            {
                this.enableField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public ushort val
        {
            get
            {
                return this.valField;
            }
            set
            {
                this.valField = value;
            }
        }
    }

    public class KCLInformationsHandler
    {
        public Dictionary<ushort, Tuple<string, string, Dictionary<ushort, string>>> colInfo;
        KCLInformations kclInfo;
        KclUserSettings kclUser;
        public KCLInformationsHandler()
        {
            byte[] xmlfile = File.ReadAllBytes(Application.StartupPath + @"\Plugins\KCLInfos\KCLInformations.xml");
            MemoryStream m = new MemoryStream(xmlfile);
            XmlSerializer deserializer = new XmlSerializer(typeof(KCLInformations));
            TextReader reader = new StreamReader(m);
            kclInfo = (KCLInformations)deserializer.Deserialize(reader);
            reader.Close();
            populateDictionaries();
            try
            {
                byte[] xmlfileUser = File.ReadAllBytes(Application.StartupPath + @"\Plugins\KCLInfos\KclUserSettings.xml");
                MemoryStream m2 = new MemoryStream(xmlfileUser);
                XmlSerializer deserializer2 = new XmlSerializer(typeof(KclUserSettings));
                TextReader reader2 = new StreamReader(m2);
                kclUser = (KclUserSettings)deserializer2.Deserialize(reader2);
                reader2.Close();
            } catch (Exception e)
            {
                kclUser = new KclUserSettings();
                kclUser.KclFile = new KclUserSettingsKclFile[0];
            }
        }

        public Tuple<Dictionary<string, ushort>, Dictionary<string, bool>> getColIDForFile(string filename, string[] newMats)
        {
            Dictionary<string, ushort> mapping = new Dictionary<string, ushort>();
            Dictionary<string, bool> coli = new Dictionary<string, bool>();
            bool found = false;
            for (int i = 0; i < kclUser.KclFile.Length; i++)
            {
                if (String.Compare(Path.GetFullPath(filename), Path.GetFullPath(kclUser.KclFile[i].src), true) == 0)
                {
                    found = true;
                    for (int j = 0; j < newMats.Length; j++)
                    {
                        bool enabled = true;
                        ushort val = 0;
                        for (int k = 0; k < kclUser.KclFile[i].colEntry.Length; k++)
                        {
                            if (newMats[j].Equals(kclUser.KclFile[i].colEntry[k].mat))
                            {
                                enabled = kclUser.KclFile[i].colEntry[k].enable;
                                val = kclUser.KclFile[i].colEntry[k].val;
                                break;
                            }
                        }
                        mapping[newMats[j]] = val;
                        coli[newMats[j]] = enabled;
                    }
                    break;
                }
            }
            if (!found)
            {
                for (int j = 0; j < newMats.Length; j++)
                {
                    mapping[newMats[j]] = 0;
                    coli[newMats[j]] = true;
                }
            }
            return Tuple.Create(mapping, coli);
        }

        public void saveColForFile(string filename, Dictionary<string,ushort> mapping, Dictionary<string, bool> coli)
        {
            List<KclUserSettingsKclFile> fileList = new List<KclUserSettingsKclFile>(kclUser.KclFile);
            for (int i = 0; i < fileList.Count; i++)
            {
                if (fileList[i].src == filename)
                {
                    fileList.RemoveAt(i);
                    break;
                }
            }
            List<KclUserSettingsKclFileColEntry> colList = new List<KclUserSettingsKclFileColEntry>();
            foreach(var s in mapping.Keys)
            {
                colList.Add(new KclUserSettingsKclFileColEntry() { mat = s, enable = coli[s], val = mapping[s] });
            }
            fileList.Insert(0, new KclUserSettingsKclFile() { src = filename, colEntry = colList.ToArray() });
            if (fileList.Count > 30) fileList.RemoveRange(30, fileList.Count - 30);
            kclUser.KclFile = fileList.ToArray();
            saveKclUserToXML();
        }

        public static byte[] RemoveAllNamespaces(byte[] xmlDocument)
        {
            XElement xmlDocumentWithoutNs = RemoveAllNamespaces(XElement.Parse(Encoding.UTF8.GetString(xmlDocument)));

            return Encoding.UTF8.GetBytes(xmlDocumentWithoutNs.ToString());
        }

        public static XElement RemoveAllNamespaces(XElement e)
        {
            return new XElement(e.Name.LocalName,
              (from n in e.Nodes()
               select ((n is XElement) ? RemoveAllNamespaces(n as XElement) : n)),
                  (e.HasAttributes) ?
                    (from a in e.Attributes()
                     where (!a.IsNamespaceDeclaration)
                     select new XAttribute(a.Name.LocalName, a.Value)) : null);
        }

        public void saveKclUserToXML()
        {
            MemoryStream m = new MemoryStream();
            XmlSerializer serializer = new XmlSerializer(typeof(KclUserSettings));
            using (TextWriter writer = new StreamWriter(m))
            {
                serializer.Serialize(writer, kclUser);
                writer.Close();
            }
            File.WriteAllBytes(Application.StartupPath + @"\Plugins\KCLInfos\KclUserSettings.xml", m.ToArray()); //RemoveAllNamespaces(m.ToArray()));
        }

        private void populateDefaultValues()
        {
            Dictionary<ushort, string> emptyDict = new Dictionary<ushort, string>();
            for (byte i = 0; i < 8; i++)
            {
                emptyDict[i] = "";
            }
            for (byte i = 0; i < 0x20; i++)
            {
                colInfo[i] = new Tuple<string, string, Dictionary<ushort, string>>("", "", emptyDict);
            }
        }

        private void populateDictionaries()
        {
            colInfo = new Dictionary<ushort, Tuple<string, string, Dictionary<ushort, string>>>();
            populateDefaultValues();
            foreach (var v in kclInfo.KCLType)
            {
                if (v.id > 0x1F) throw new InvalidDataException("KCL Type: " + v.id + " is not valid.");
                Dictionary<ushort, string> basicEffect = new Dictionary<ushort, string>();
                for (byte i = 0; i < 8; i++)
                {
                    basicEffect[i] = "";
                }
                foreach (var b in v.BasicEffect)
                {
                    if (b.id > 0x7) throw new InvalidDataException("Basic Effect: " + v.id + " is not valid.");
                    basicEffect[b.id] = b.name;
                }
                colInfo[v.id] = new Tuple<string, string, Dictionary<ushort, string>>(v.name, v.description, basicEffect);               
            }
        }
    }
}
