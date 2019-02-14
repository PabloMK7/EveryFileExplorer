using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace _3DS.UI
{
    public partial class SARCFileAdd : Form
    {
        public uint calculatedHash;
        SARC Archive;

        public SARCFileAdd(SARC Archive, string fileName)
        {
            InitializeComponent();
            calculatedHash = 0;
            this.Archive = Archive;
            fileNameLabel.Text = "File: " + fileName;
        }

        private void fromNameCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if ((sender as CheckBox).Checked)
            {
                fromHashCheckBox.Checked = false;
                fromHashTextBox.Enabled = false;
                fromNameTextBox.Enabled = true;
                fromHashTextBox.Text = "";
                calculatedHash = 0;
                updateDisplayHash();
            } else
            {
                fromNameCheckBox.Checked = true;
            }
        }

        private void fromHashCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if ((sender as CheckBox).Checked)
            {
                fromNameCheckBox.Checked = false;
                fromNameTextBox.Enabled = false;
                fromHashTextBox.Enabled = true;
                fromNameTextBox.Text = "";
                calculatedHash = 0;
                updateDisplayHash();
            } else
            {
                fromHashCheckBox.Checked = true;
            }
        }

        private void okButton_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
            this.Close();
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void updateDisplayHash()
        {
            outputFileNameLabel.Text = string.Format("Output File Name: 0x{0:X8}", calculatedHash);
        }

        private void fromNameTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                calculatedHash = Archive.GetHashFromName((sender as TextBox).Text);
            } catch (Exception ex) {
                calculatedHash = 0;
            }
            updateDisplayHash();
        }

        private void fromHashTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                calculatedHash = Convert.ToUInt32((sender as TextBox).Text, 16);
            }
            catch (Exception ex)
            {
                calculatedHash = 0;
            }
            updateDisplayHash();
        }

        private void SARCFileAdd_Shown(object sender, EventArgs e)
        {
            fromNameTextBox.Select();
        }

        private void SARCFileAdd_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Return)
            {
                okButton.PerformClick();
            }
        }
    }
}
