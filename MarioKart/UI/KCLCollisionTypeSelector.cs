using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Globalization;

namespace MarioKart.UI
{
    public partial class KCLCollisionTypeSelector : Form
    {
        public Dictionary<string, ushort> Mapping;
        public Dictionary<string, bool> Colli;
        public bool isMK7;
        public bool isRowUpdating;
        public bool isElementUpdating;
        public int currTableSelectedIndex;
        public string objFileName;
        MK7.KCLInformationsHandler mk7kclinfo;

        public KCLCollisionTypeSelector(string[] names, string objFileName)
        {
            InitializeComponent();
            this.objFileName = objFileName;
            isMK7 = false;
            isRowUpdating = false;
            isElementUpdating = false;
            currTableSelectedIndex = -1;
            enableMK7SpecificInfo(false);
            currKclValue = new KCLValue();
            mk7kclinfo = new MK7.KCLInformationsHandler();
            (Mapping, Colli) = mk7kclinfo.getColIDForFile(objFileName, names);
            foreach (var s in names)
            {
                dataGridView1.Rows.Add(s, Colli[s], string.Format("{0:X4}", Mapping[s], NumberStyles.HexNumber, CultureInfo.InvariantCulture));
            }
            if (Mapping.Count == 0)
            {
                Mapping.Add("Default", 0);
                Colli.Add("Default", true);
                dataGridView1.Rows.Add("Default", true, "0000");
            }
        }

        public class KCLValue
        {
            public KCLValue()
            {
                Value = 0;
            }

            public byte Type;
            public byte basicEf;
            public byte shadow;
            public bool trickable;
            public bool pushback;
            public bool sticky;
            public bool cannon;
            public ushort Value
            {
                get
                {
                    ushort retVal = (byte)(Type & 0x1F);
                    retVal |= (ushort)((basicEf & 0x7) << 5);
                    retVal |= (ushort)((shadow & 0xF) << 8);
                    retVal |= (ushort)((trickable ? 1 : 0) << 12);
                    if (pushback) retVal = (ushort)((retVal & 0x1FFF) | 0x2000);
                    else if (sticky) retVal = (ushort)((retVal & 0x1FFF) | 0x4000); 
                    else if (cannon) retVal = (ushort)((retVal & 0x1FFF) | 0x8000);
                    return retVal;
                }
                set
                {
                    Type = (byte)(value & 0x1F);
                    basicEf = (byte)((value >> 5) & 0x7);
                    shadow = (byte)((value >> 8) & 0xF);
                    trickable = ((value >> 12) & 1) == 1;
                    pushback = sticky = cannon = false;
                    if (((value >> 13) & 1) == 1) pushback = true;
                    else if (((value >> 14) & 1) == 1) sticky = true;
                    else if (((value >> 15) & 1) == 1) cannon = true;
                }
            }
        }

        KCLValue currKclValue;

        public void updateNewKclValue()
        {
            if (typeComboBox.SelectedIndex < 0) currKclValue.Type = 0;
            else currKclValue.Type = (byte)typeComboBox.SelectedIndex;

            if (basicEfComboBox.SelectedIndex < 0) currKclValue.basicEf = 0;
            else currKclValue.basicEf = (byte)basicEfComboBox.SelectedIndex;

            if (shadowComboBox.SelectedIndex < 0) currKclValue.shadow = 0;
            else currKclValue.shadow = (byte)shadowComboBox.SelectedIndex;

            currKclValue.trickable = trickableCheck.Checked;
            currKclValue.pushback = pushBackRadio.Checked;
            currKclValue.sticky = stickyRadio.Checked;
            currKclValue.cannon = cannonRadio.Checked;

            dataGridView1.Rows[currTableSelectedIndex].Cells[2].Value = string.Format("{0:X4}", currKclValue.Value, NumberStyles.HexNumber, CultureInfo.InvariantCulture);
            Mapping[dataGridView1.Rows[currTableSelectedIndex].Cells[0].Value as string] = currKclValue.Value;

        }

        public void updateFromKclValue()
        {
            currKclValue.Value = ushort.Parse(dataGridView1.Rows[currTableSelectedIndex].Cells[2].Value as string, NumberStyles.HexNumber, CultureInfo.InvariantCulture);
            typeComboBox.SelectedIndex = currKclValue.Type;
            updateTypeSpecificInfos();
            basicEfComboBox.SelectedIndex = currKclValue.basicEf;
            shadowComboBox.SelectedIndex = currKclValue.shadow;
            trickableCheck.Checked = currKclValue.trickable;
            pushBackRadio.Checked = currKclValue.pushback;
            stickyRadio.Checked = currKclValue.sticky;
            cannonRadio.Checked = currKclValue.cannon;
        }

		

        public void enableMK7SpecificInfo(bool mode)
        {
            typeComboBox.Enabled = basicEfComboBox.Enabled = shadowComboBox.Enabled = trickableCheck.Enabled =
                normalRadio.Enabled = pushBackRadio.Enabled = stickyRadio.Enabled = cannonRadio.Enabled = mode;
        }

        public void loadMK7KCLInformations()
        {
            isMK7 = true;
            for (byte i = 0; i < 0x20; i++)
            {
                typeComboBox.Items.Add(string.Format("0x{0:X2} - ", i) + mk7kclinfo.colInfo[i].Item1);
            }
        }

        private void kclType_Load(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellValidating(object sender, DataGridViewCellValidatingEventArgs e)
        {
            ushort hex;
            switch (e.ColumnIndex)
            {
                case 2:
                    e.Cancel = !ushort.TryParse(e.FormattedValue.ToString(), NumberStyles.HexNumber, CultureInfo.InvariantCulture, out hex);
                    break;
            }
        }

        private void dataGridView1_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            switch (e.ColumnIndex)
            {
                case 1:
                    Colli[dataGridView1.Rows[e.RowIndex].Cells[0].Value as string] = (bool)dataGridView1.Rows[e.RowIndex].Cells[1].Value;
                    break;
                case 2:
                    dataGridView1.Rows[e.RowIndex].Cells[2].Value = string.Format("{0:X4}", ushort.Parse(dataGridView1.Rows[e.RowIndex].Cells[2].Value as string, NumberStyles.HexNumber, CultureInfo.InvariantCulture));
                    Mapping[dataGridView1.Rows[e.RowIndex].Cells[0].Value as string] = ushort.Parse(dataGridView1.Rows[e.RowIndex].Cells[2].Value as string, NumberStyles.HexNumber, CultureInfo.InvariantCulture);
                    break;
            }
        }

        private void kclType_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }

        private void kclType_FormClosing(object sender, FormClosingEventArgs e)
        {
            dataGridView1.EndEdit();
            mk7kclinfo.saveColForFile(objFileName, Mapping, Colli);
        }

        public void updateTypeSpecificInfos()
        {
            descriptionLabel.Text = mk7kclinfo.colInfo[(byte)typeComboBox.SelectedIndex].Item2;
            Dictionary<ushort, string> currBasicEffects = mk7kclinfo.colInfo[(byte)typeComboBox.SelectedIndex].Item3;
            basicEfComboBox.Items.Clear();
            for (byte i = 0; i < 8; i++)
            {
                basicEfComboBox.Items.Add(string.Format("0x{0:X1} - ", i) + currBasicEffects[i]);
            }
            basicEfComboBox.SelectedIndex = 0;
        }

        private void TypeComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!isMK7 || isRowUpdating || currTableSelectedIndex == -1 || (sender as ComboBox).SelectedIndex == -1) return;
            updateTypeSpecificInfos();
            OtherComboBox_SelectedIndexChanged(sender, e);
        }

        private void OtherComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!isMK7 || isRowUpdating || currTableSelectedIndex == -1) return;
            isElementUpdating = true;
            updateNewKclValue();
            isElementUpdating = false;
        }

        private void DataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            if (!isMK7 || isElementUpdating) return;
            isRowUpdating = true;
            currTableSelectedIndex = dataGridView1.SelectedCells.Count == 0 ? -1 : dataGridView1.SelectedCells[0].RowIndex;
            if (currTableSelectedIndex == -1) enableMK7SpecificInfo(false);
            else
            {
                enableMK7SpecificInfo(true);
                updateFromKclValue();
            }

            isRowUpdating = false;
        }
    }
}
