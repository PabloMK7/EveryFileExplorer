namespace MarioKart.UI
{
    partial class KclWorking
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
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.progress_label = new System.Windows.Forms.Label();
            this.cancel_btn = new System.Windows.Forms.Button();
            this.kclBackgroundWorker = new System.ComponentModel.BackgroundWorker();
            this.SuspendLayout();
            // 
            // progressBar1
            // 
            this.progressBar1.Cursor = System.Windows.Forms.Cursors.Default;
            this.progressBar1.Location = new System.Drawing.Point(12, 12);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(391, 23);
            this.progressBar1.Step = 1;
            this.progressBar1.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.progressBar1.TabIndex = 0;
            // 
            // progress_label
            // 
            this.progress_label.AutoSize = true;
            this.progress_label.Location = new System.Drawing.Point(12, 46);
            this.progress_label.Name = "progress_label";
            this.progress_label.Size = new System.Drawing.Size(122, 13);
            this.progress_label.TabIndex = 1;
            this.progress_label.Text = "Step: 1/2; Progress: 0/0";
            // 
            // cancel_btn
            // 
            this.cancel_btn.Location = new System.Drawing.Point(328, 41);
            this.cancel_btn.Name = "cancel_btn";
            this.cancel_btn.Size = new System.Drawing.Size(75, 23);
            this.cancel_btn.TabIndex = 2;
            this.cancel_btn.Text = "Cancel";
            this.cancel_btn.UseVisualStyleBackColor = true;
            this.cancel_btn.Click += new System.EventHandler(this.cancel_btn_Click);
            // 
            // kclBackgroundWorker
            // 
            this.kclBackgroundWorker.WorkerReportsProgress = true;
            this.kclBackgroundWorker.WorkerSupportsCancellation = true;
            this.kclBackgroundWorker.DoWork += new System.ComponentModel.DoWorkEventHandler(this.kclBackgroundWorker_DoWork);
            this.kclBackgroundWorker.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.kclBackgroundWorker_ProgressChanged);
            this.kclBackgroundWorker.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.kclBackgroundWorker_RunWorkerCompleted);
            // 
            // KclWorking
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(415, 70);
            this.ControlBox = false;
            this.Controls.Add(this.cancel_btn);
            this.Controls.Add(this.progress_label);
            this.Controls.Add(this.progressBar1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "KclWorking";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Generating KCL...";
            this.Shown += new System.EventHandler(this.KclWorking_Shown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Label progress_label;
        private System.Windows.Forms.Button cancel_btn;
        private System.ComponentModel.BackgroundWorker kclBackgroundWorker;
    }
}