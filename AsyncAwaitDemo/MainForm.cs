
using System;
using System.Diagnostics;
using System.Windows.Forms;
using System.Collections.Generic;

using AsyncDemoLib;

namespace AsyncAwaitDemo
{
    public partial class MainForm : Form
    {
        private eParadigm _paradigm;

        public MainForm()
        {
            InitializeComponent();
            _paradigm = eParadigm.Synchronous;
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

            tbTime.Text = watch.ElapsedMilliseconds.ToString();
            Cursor = Cursors.Default;
        }

        // ------------------------------------------------

        private List<string> PrepData()
        {
            var output = new List<string>();

            output.Add("https://www.cnn.com");
            output.Add("https://www.yahoo.com");
            output.Add("https://www.google.com");
            output.Add("https://www.microsoft.com");
            output.Add("https://www.codeproject.com");
            output.Add("https://www.stackoverflow.com");

            return output;
        }
    }
}
