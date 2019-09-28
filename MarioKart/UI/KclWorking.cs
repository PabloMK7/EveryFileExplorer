using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MarioKart.UI
{
    public partial class KclWorking : Form
    {
        public MK7.KCL kcl;
        public bool result;
        MK7.KCL.BGArgs arg;
        public KclWorking(MK7.KCL kcl, string filename)
        {
            this.kcl = kcl;
            arg = new MK7.KCL.BGArgs();
            arg.filename = filename;
            InitializeComponent();
            progressBar1.Style = ProgressBarStyle.Marquee;
        }

        private void kclBackgroundWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            result = kcl.BackGroundWorkerTask(sender as System.ComponentModel.BackgroundWorker, e.Argument);
        }

        private void updateInfo()
        {
            progressBar1.Style = ProgressBarStyle.Continuous;
            progress_label.Text = "Step: " + arg.state + "/2; Progress: " + arg.currProg + "/" + arg.totProg;
            if (progressBar1.Maximum != arg.totProg) { progressBar1.Maximum = arg.totProg; progressBar1.Value = 0; }
            progressBar1.PerformStep();
        }

        private void kclBackgroundWorker_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            updateInfo();
        }

        private void kclBackgroundWorker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            if (result)
            {
                DialogResult = DialogResult.OK;
            } else
            {
                DialogResult = DialogResult.Cancel;
            }
        }

        private void KclWorking_Shown(object sender, EventArgs e)
        {
            if (kclBackgroundWorker.IsBusy != true)
            {
                kclBackgroundWorker.RunWorkerAsync(arg);
            }
        }

        private void cancel_btn_Click(object sender, EventArgs e)
        {
            if (kclBackgroundWorker.WorkerSupportsCancellation)
            {
                kclBackgroundWorker.CancelAsync();
            }
        }
    }
}
