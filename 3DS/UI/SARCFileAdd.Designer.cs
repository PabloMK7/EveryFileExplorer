namespace _3DS.UI
{
    partial class SARCFileAdd
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
            this.fileNameLabel = new System.Windows.Forms.Label();
            this.fromNameCheckBox = new System.Windows.Forms.CheckBox();
            this.fromHashCheckBox = new System.Windows.Forms.CheckBox();
            this.cancelButton = new System.Windows.Forms.Button();
            this.okButton = new System.Windows.Forms.Button();
            this.separator1 = new System.Windows.Forms.Label();
            this.separator2 = new System.Windows.Forms.Label();
            this.outputFileNameLabel = new System.Windows.Forms.Label();
            this.fromNameTextBox = new System.Windows.Forms.TextBox();
            this.fromHashTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // fileNameLabel
            // 
            this.fileNameLabel.AutoSize = true;
            this.fileNameLabel.Location = new System.Drawing.Point(9, 9);
            this.fileNameLabel.Name = "fileNameLabel";
            this.fileNameLabel.Size = new System.Drawing.Size(26, 13);
            this.fileNameLabel.TabIndex = 0;
            this.fileNameLabel.Text = "File:";
            // 
            // fromNameCheckBox
            // 
            this.fromNameCheckBox.AutoSize = true;
            this.fromNameCheckBox.Checked = true;
            this.fromNameCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.fromNameCheckBox.Location = new System.Drawing.Point(12, 31);
            this.fromNameCheckBox.Name = "fromNameCheckBox";
            this.fromNameCheckBox.Size = new System.Drawing.Size(80, 17);
            this.fromNameCheckBox.TabIndex = 1;
            this.fromNameCheckBox.Text = "From Name";
            this.fromNameCheckBox.UseVisualStyleBackColor = true;
            this.fromNameCheckBox.Click += new System.EventHandler(this.fromNameCheckBox_CheckedChanged);
            // 
            // fromHashCheckBox
            // 
            this.fromHashCheckBox.AutoSize = true;
            this.fromHashCheckBox.Location = new System.Drawing.Point(12, 55);
            this.fromHashCheckBox.Name = "fromHashCheckBox";
            this.fromHashCheckBox.Size = new System.Drawing.Size(77, 17);
            this.fromHashCheckBox.TabIndex = 2;
            this.fromHashCheckBox.Text = "From Hash";
            this.fromHashCheckBox.UseVisualStyleBackColor = true;
            this.fromHashCheckBox.Click += new System.EventHandler(this.fromHashCheckBox_CheckedChanged);
            // 
            // cancelButton
            // 
            this.cancelButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.cancelButton.Location = new System.Drawing.Point(262, 89);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(75, 23);
            this.cancelButton.TabIndex = 3;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // okButton
            // 
            this.okButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.okButton.Location = new System.Drawing.Point(181, 89);
            this.okButton.Name = "okButton";
            this.okButton.Size = new System.Drawing.Size(75, 23);
            this.okButton.TabIndex = 4;
            this.okButton.Text = "OK";
            this.okButton.UseVisualStyleBackColor = true;
            this.okButton.Click += new System.EventHandler(this.okButton_Click);
            // 
            // separator1
            // 
            this.separator1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.separator1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.separator1.Location = new System.Drawing.Point(12, 26);
            this.separator1.Name = "separator1";
            this.separator1.Size = new System.Drawing.Size(324, 2);
            this.separator1.TabIndex = 5;
            // 
            // separator2
            // 
            this.separator2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.separator2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.separator2.Location = new System.Drawing.Point(12, 78);
            this.separator2.Name = "separator2";
            this.separator2.Size = new System.Drawing.Size(324, 2);
            this.separator2.TabIndex = 6;
            // 
            // outputFileNameLabel
            // 
            this.outputFileNameLabel.AutoSize = true;
            this.outputFileNameLabel.Location = new System.Drawing.Point(12, 94);
            this.outputFileNameLabel.Name = "outputFileNameLabel";
            this.outputFileNameLabel.Size = new System.Drawing.Size(154, 13);
            this.outputFileNameLabel.TabIndex = 7;
            this.outputFileNameLabel.Text = "Output File Name: 0x00000000";
            // 
            // fromNameTextBox
            // 
            this.fromNameTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.fromNameTextBox.Location = new System.Drawing.Point(99, 32);
            this.fromNameTextBox.Name = "fromNameTextBox";
            this.fromNameTextBox.Size = new System.Drawing.Size(237, 20);
            this.fromNameTextBox.TabIndex = 8;
            this.fromNameTextBox.TextChanged += new System.EventHandler(this.fromNameTextBox_TextChanged);
            this.fromNameTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.SARCFileAdd_KeyDown);
            // 
            // fromHashTextBox
            // 
            this.fromHashTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.fromHashTextBox.Enabled = false;
            this.fromHashTextBox.Location = new System.Drawing.Point(99, 55);
            this.fromHashTextBox.Name = "fromHashTextBox";
            this.fromHashTextBox.Size = new System.Drawing.Size(237, 20);
            this.fromHashTextBox.TabIndex = 9;
            this.fromHashTextBox.TextChanged += new System.EventHandler(this.fromHashTextBox_TextChanged);
            this.fromHashTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.SARCFileAdd_KeyDown);
            // 
            // SARCFileAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(348, 124);
            this.ControlBox = false;
            this.Controls.Add(this.fromHashTextBox);
            this.Controls.Add(this.fromNameTextBox);
            this.Controls.Add(this.outputFileNameLabel);
            this.Controls.Add(this.separator2);
            this.Controls.Add(this.separator1);
            this.Controls.Add(this.okButton);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.fromHashCheckBox);
            this.Controls.Add(this.fromNameCheckBox);
            this.Controls.Add(this.fileNameLabel);
            this.MaximumSize = new System.Drawing.Size(1024, 163);
            this.MinimumSize = new System.Drawing.Size(364, 163);
            this.Name = "SARCFileAdd";
            this.Text = "Add File";
            this.Shown += new System.EventHandler(this.SARCFileAdd_Shown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label fileNameLabel;
        private System.Windows.Forms.CheckBox fromNameCheckBox;
        private System.Windows.Forms.CheckBox fromHashCheckBox;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Button okButton;
        private System.Windows.Forms.Label separator1;
        private System.Windows.Forms.Label separator2;
        private System.Windows.Forms.Label outputFileNameLabel;
        private System.Windows.Forms.TextBox fromNameTextBox;
        private System.Windows.Forms.TextBox fromHashTextBox;
    }
}