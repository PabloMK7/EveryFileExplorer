using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
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


    public class KCLInformationsHandler
    {
        public Dictionary<ushort, Tuple<string, string, Dictionary<ushort, string>>> colInfo;
        KCLInformations kclInfo;
        public KCLInformationsHandler()
        {
            byte[] xmlfile = File.ReadAllBytes(Application.StartupPath + @"\Plugins\KCLInfos\KCLInformations.xml");
            MemoryStream m = new MemoryStream(xmlfile);
            XmlSerializer deserializer = new XmlSerializer(typeof(KCLInformations));
            TextReader reader = new StreamReader(m);
            kclInfo = (KCLInformations)deserializer.Deserialize(reader);
            reader.Close();
            populateDictionaries();
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
