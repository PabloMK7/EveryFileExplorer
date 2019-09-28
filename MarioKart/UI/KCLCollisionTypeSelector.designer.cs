namespace MarioKart.UI
{
	partial class KCLCollisionTypeSelector
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Collide = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Type = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ItemTemplate = new Microsoft.VisualBasic.PowerPacks.DataRepeaterItem();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.cannonRadio = new System.Windows.Forms.RadioButton();
            this.trickableCheck = new System.Windows.Forms.CheckBox();
            this.normalRadio = new System.Windows.Forms.RadioButton();
            this.pushBackRadio = new System.Windows.Forms.RadioButton();
            this.stickyRadio = new System.Windows.Forms.RadioButton();
            this.basicEfComboBox = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.shadowComboBox = new System.Windows.Forms.ComboBox();
            this.typeComboBox = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.descriptionLabel1 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.descriptionLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.name,
            this.Collide,
            this.Type});
            this.dataGridView1.Location = new System.Drawing.Point(3, 3);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dataGridView1.ShowEditingIcon = false;
            this.dataGridView1.Size = new System.Drawing.Size(553, 199);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellEndEdit);
            this.dataGridView1.CellValidating += new System.Windows.Forms.DataGridViewCellValidatingEventHandler(this.dataGridView1_CellValidating);
            this.dataGridView1.SelectionChanged += new System.EventHandler(this.DataGridView1_SelectionChanged);
            // 
            // name
            // 
            this.name.HeaderText = "Name";
            this.name.Name = "name";
            this.name.ReadOnly = true;
            // 
            // Collide
            // 
            this.Collide.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.Collide.HeaderText = "Collide";
            this.Collide.Name = "Collide";
            // 
            // Type
            // 
            this.Type.HeaderText = "Type";
            this.Type.MaxInputLength = 4;
            this.Type.Name = "Type";
            // 
            // ItemTemplate
            // 
            this.ItemTemplate.Size = new System.Drawing.Size(232, 100);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.splitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel2;
            this.splitContainer1.Location = new System.Drawing.Point(12, 12);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.dataGridView1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.descriptionLabel);
            this.splitContainer1.Panel2.Controls.Add(this.cannonRadio);
            this.splitContainer1.Panel2.Controls.Add(this.trickableCheck);
            this.splitContainer1.Panel2.Controls.Add(this.normalRadio);
            this.splitContainer1.Panel2.Controls.Add(this.pushBackRadio);
            this.splitContainer1.Panel2.Controls.Add(this.stickyRadio);
            this.splitContainer1.Panel2.Controls.Add(this.basicEfComboBox);
            this.splitContainer1.Panel2.Controls.Add(this.label4);
            this.splitContainer1.Panel2.Controls.Add(this.shadowComboBox);
            this.splitContainer1.Panel2.Controls.Add(this.typeComboBox);
            this.splitContainer1.Panel2.Controls.Add(this.label3);
            this.splitContainer1.Panel2.Controls.Add(this.descriptionLabel1);
            this.splitContainer1.Panel2.Controls.Add(this.label1);
            this.splitContainer1.Size = new System.Drawing.Size(559, 315);
            this.splitContainer1.SplitterDistance = 205;
            this.splitContainer1.TabIndex = 1;
            // 
            // cannonRadio
            // 
            this.cannonRadio.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.cannonRadio.AutoSize = true;
            this.cannonRadio.Location = new System.Drawing.Point(457, 65);
            this.cannonRadio.Name = "cannonRadio";
            this.cannonRadio.Size = new System.Drawing.Size(62, 17);
            this.cannonRadio.TabIndex = 11;
            this.cannonRadio.Text = "Cannon";
            this.cannonRadio.UseVisualStyleBackColor = true;
            this.cannonRadio.CheckedChanged += new System.EventHandler(this.OtherComboBox_SelectedIndexChanged);
            // 
            // trickableCheck
            // 
            this.trickableCheck.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.trickableCheck.AutoSize = true;
            this.trickableCheck.Location = new System.Drawing.Point(409, 19);
            this.trickableCheck.Name = "trickableCheck";
            this.trickableCheck.Size = new System.Drawing.Size(70, 17);
            this.trickableCheck.TabIndex = 7;
            this.trickableCheck.Text = "Trickable";
            this.trickableCheck.UseVisualStyleBackColor = true;
            this.trickableCheck.CheckedChanged += new System.EventHandler(this.OtherComboBox_SelectedIndexChanged);
            // 
            // normalRadio
            // 
            this.normalRadio.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.normalRadio.AutoSize = true;
            this.normalRadio.Checked = true;
            this.normalRadio.Location = new System.Drawing.Point(366, 42);
            this.normalRadio.Name = "normalRadio";
            this.normalRadio.Size = new System.Drawing.Size(58, 17);
            this.normalRadio.TabIndex = 8;
            this.normalRadio.TabStop = true;
            this.normalRadio.Text = "Normal";
            this.normalRadio.UseVisualStyleBackColor = true;
            this.normalRadio.CheckedChanged += new System.EventHandler(this.OtherComboBox_SelectedIndexChanged);
            // 
            // pushBackRadio
            // 
            this.pushBackRadio.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.pushBackRadio.AutoSize = true;
            this.pushBackRadio.Location = new System.Drawing.Point(366, 65);
            this.pushBackRadio.Name = "pushBackRadio";
            this.pushBackRadio.Size = new System.Drawing.Size(77, 17);
            this.pushBackRadio.TabIndex = 10;
            this.pushBackRadio.Text = "Push Back";
            this.pushBackRadio.UseVisualStyleBackColor = true;
            this.pushBackRadio.CheckedChanged += new System.EventHandler(this.OtherComboBox_SelectedIndexChanged);
            // 
            // stickyRadio
            // 
            this.stickyRadio.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.stickyRadio.AutoSize = true;
            this.stickyRadio.Location = new System.Drawing.Point(457, 42);
            this.stickyRadio.Name = "stickyRadio";
            this.stickyRadio.Size = new System.Drawing.Size(54, 17);
            this.stickyRadio.TabIndex = 9;
            this.stickyRadio.Text = "Sticky";
            this.stickyRadio.UseVisualStyleBackColor = true;
            this.stickyRadio.CheckedChanged += new System.EventHandler(this.OtherComboBox_SelectedIndexChanged);
            // 
            // basicEfComboBox
            // 
            this.basicEfComboBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.basicEfComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.basicEfComboBox.FormattingEnabled = true;
            this.basicEfComboBox.Location = new System.Drawing.Point(82, 50);
            this.basicEfComboBox.Name = "basicEfComboBox";
            this.basicEfComboBox.Size = new System.Drawing.Size(234, 21);
            this.basicEfComboBox.TabIndex = 5;
            this.basicEfComboBox.SelectedIndexChanged += new System.EventHandler(this.OtherComboBox_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(27, 80);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Shadow:";
            // 
            // shadowComboBox
            // 
            this.shadowComboBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.shadowComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.shadowComboBox.FormattingEnabled = true;
            this.shadowComboBox.Items.AddRange(new object[] {
            "0x0 - Default Light",
            "0x1 - Default Shadow",
            "0x2 - SARC Light 0",
            "0x3 - SARC Light 1",
            "0x4 - SARC Light 2",
            "0x5 - SARC Light 3",
            "0x6 - SARC Light 4",
            "0x7 - SARC Light 5",
            "0x8 - SARC Light 6",
            "0x9 - SARC Light 7",
            "0xA - SARC Light 8",
            "0xB - SARC Light 9",
            "0xC - SARC Light 10",
            "0xD - SARC Light 11",
            "0xE - SARC Light 12",
            "0xF - SARC Light 13"});
            this.shadowComboBox.Location = new System.Drawing.Point(82, 77);
            this.shadowComboBox.Name = "shadowComboBox";
            this.shadowComboBox.Size = new System.Drawing.Size(234, 21);
            this.shadowComboBox.TabIndex = 6;
            this.shadowComboBox.SelectedIndexChanged += new System.EventHandler(this.OtherComboBox_SelectedIndexChanged);
            // 
            // typeComboBox
            // 
            this.typeComboBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.typeComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.typeComboBox.FormattingEnabled = true;
            this.typeComboBox.Location = new System.Drawing.Point(82, 5);
            this.typeComboBox.Name = "typeComboBox";
            this.typeComboBox.Size = new System.Drawing.Size(234, 21);
            this.typeComboBox.TabIndex = 4;
            this.typeComboBox.SelectedIndexChanged += new System.EventHandler(this.TypeComboBox_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 54);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Basic Effect:";
            // 
            // descriptionLabel1
            // 
            this.descriptionLabel1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.descriptionLabel1.AutoSize = true;
            this.descriptionLabel1.Location = new System.Drawing.Point(13, 30);
            this.descriptionLabel1.Name = "descriptionLabel1";
            this.descriptionLabel1.Size = new System.Drawing.Size(63, 13);
            this.descriptionLabel1.TabIndex = 1;
            this.descriptionLabel1.Text = "Description:";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(42, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Type:";
            // 
            // descriptionLabel
            // 
            this.descriptionLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.descriptionLabel.AutoSize = true;
            this.descriptionLabel.Location = new System.Drawing.Point(79, 30);
            this.descriptionLabel.Name = "descriptionLabel";
            this.descriptionLabel.Size = new System.Drawing.Size(0, 13);
            this.descriptionLabel.TabIndex = 12;
            this.descriptionLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // KCLCollisionTypeSelector
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(583, 339);
            this.Controls.Add(this.splitContainer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "KCLCollisionTypeSelector";
            this.Text = "Collision Type Selector";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.kclType_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.kclType_FormClosed);
            this.Load += new System.EventHandler(this.kclType_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn name;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Collide;
        private System.Windows.Forms.DataGridViewTextBoxColumn Type;
		private Microsoft.VisualBasic.PowerPacks.DataRepeaterItem ItemTemplate;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label descriptionLabel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox trickableCheck;
        private System.Windows.Forms.RadioButton normalRadio;
        private System.Windows.Forms.RadioButton pushBackRadio;
        private System.Windows.Forms.RadioButton stickyRadio;
        private System.Windows.Forms.ComboBox basicEfComboBox;
        private System.Windows.Forms.ComboBox shadowComboBox;
        private System.Windows.Forms.ComboBox typeComboBox;
        private System.Windows.Forms.RadioButton cannonRadio;
        private System.Windows.Forms.Label descriptionLabel;
    }
}