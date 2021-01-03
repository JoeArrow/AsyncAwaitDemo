
using System;
using System.Diagnostics;
using System.Windows.Forms;
using System.Collections.Generic;

using AsyncDemoLib;
using AboutJoeWare_Lib;

namespace AsyncAwaitDemo
{
    public partial class MainForm : Form
    {
        private eParadigm _paradigm;

        public MainForm()
        {
            InitializeComponent();
            _paradigm = eParadigm.Synchronous;
            lblFormSize.Text = Size.ToString();
        }

        // ------------------------------------------------

        private void OnExecutionParadigmChange(object sender, EventArgs e)
        {
            var rb = sender as RadioButton;

            if(rb.Checked)
            {
                _paradigm = (eParadigm)Enum.Parse(typeof(eParadigm), rb.Tag.ToString());
            }
        }

        // ------------------------------------------------

        private async void OnExecute(object sender, EventArgs e)
        {
            dgvData.DataSource = null;
            var demo = new AsyncDemo();
            var watch = Stopwatch.StartNew();

            Cursor = Cursors.WaitCursor;

            dgvData.DataSource = await demo.Execute(PrepData(), _paradigm);
            watch.Stop();

            tbTime.Text = (watch.ElapsedMilliseconds/1000.0).ToString();
            Cursor = Cursors.Default;
        }

        // ------------------------------------------------

        private void OnFormResize(object sender, EventArgs e)
        {
            lblFormSize.Text = Size.ToString();
        }
        
        // ------------------------------------------------

        private void OnShowSize(object sender, EventArgs e)
        {
            lblFormSize.Visible = !lblFormSize.Visible;
        }

        // ------------------------------------------------

        private void OnAbout(object sender, EventArgs e)
        {
            new AboutJoeWareDlg().ShowDialog();
        }

        // ------------------------------------------------

        private List<string> PrepData()
        {
            var output = new List<string>();

            output.Add("https://www.cnn.com");
            output.Add("http://www.aflac.com");
            output.Add("https://www.yahoo.com");
            output.Add("https://www.google.com");
            output.Add("https://www.microsoft.com");
            output.Add("https://www.codeproject.com");
            output.Add("https://www.stackoverflow.com");

            return output;
        }
    }
}
