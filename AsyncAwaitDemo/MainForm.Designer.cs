
namespace AsyncAwaitDemo
{
    partial class MainForm
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
            if(disposing && (components != null))
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbAsyncParallel = new System.Windows.Forms.RadioButton();
            this.rbAsync = new System.Windows.Forms.RadioButton();
            this.rbSync = new System.Windows.Forms.RadioButton();
            this.dgvData = new System.Windows.Forms.DataGridView();
            this.btnExecute = new System.Windows.Forms.Button();
            this.tbTime = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvData)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.rbAsyncParallel);
            this.groupBox1.Controls.Add(this.rbAsync);
            this.groupBox1.Controls.Add(this.rbSync);
            this.groupBox1.Location = new System.Drawing.Point(278, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(129, 99);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Execution Paradigm";
            // 
            // rbAsyncParallel
            // 
            this.rbAsyncParallel.AutoSize = true;
            this.rbAsyncParallel.Location = new System.Drawing.Point(30, 70);
            this.rbAsyncParallel.Name = "rbAsyncParallel";
            this.rbAsyncParallel.Size = new System.Drawing.Size(91, 17);
            this.rbAsyncParallel.TabIndex = 2;
            this.rbAsyncParallel.Tag = "AsyncParallel";
            this.rbAsyncParallel.Text = "Async Parallel";
            this.rbAsyncParallel.UseVisualStyleBackColor = true;
            this.rbAsyncParallel.CheckedChanged += new System.EventHandler(this.OnExecutionParadigmChange);
            // 
            // rbAsync
            // 
            this.rbAsync.AutoSize = true;
            this.rbAsync.Location = new System.Drawing.Point(30, 47);
            this.rbAsync.Name = "rbAsync";
            this.rbAsync.Size = new System.Drawing.Size(92, 17);
            this.rbAsync.TabIndex = 1;
            this.rbAsync.Tag = "Asynchronous";
            this.rbAsync.Text = "Asynchronous";
            this.rbAsync.UseVisualStyleBackColor = true;
            this.rbAsync.CheckedChanged += new System.EventHandler(this.OnExecutionParadigmChange);
            // 
            // rbSync
            // 
            this.rbSync.AutoSize = true;
            this.rbSync.Checked = true;
            this.rbSync.Location = new System.Drawing.Point(30, 24);
            this.rbSync.Name = "rbSync";
            this.rbSync.Size = new System.Drawing.Size(87, 17);
            this.rbSync.TabIndex = 0;
            this.rbSync.TabStop = true;
            this.rbSync.Tag = "Synchronous";
            this.rbSync.Text = "Synchronous";
            this.rbSync.UseVisualStyleBackColor = true;
            this.rbSync.CheckedChanged += new System.EventHandler(this.OnExecutionParadigmChange);
            // 
            // dgvData
            // 
            this.dgvData.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvData.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvData.Location = new System.Drawing.Point(12, 117);
            this.dgvData.Name = "dgvData";
            this.dgvData.Size = new System.Drawing.Size(395, 156);
            this.dgvData.TabIndex = 1;
            // 
            // btnExecute
            // 
            this.btnExecute.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExecute.Location = new System.Drawing.Point(33, 34);
            this.btnExecute.Name = "btnExecute";
            this.btnExecute.Size = new System.Drawing.Size(210, 54);
            this.btnExecute.TabIndex = 2;
            this.btnExecute.Text = "Execute";
            this.btnExecute.UseVisualStyleBackColor = true;
            this.btnExecute.Click += new System.EventHandler(this.OnExecute);
            // 
            // tbTime
            // 
            this.tbTime.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.tbTime.Location = new System.Drawing.Point(332, 281);
            this.tbTime.Name = "tbTime";
            this.tbTime.ReadOnly = true;
            this.tbTime.Size = new System.Drawing.Size(74, 20);
            this.tbTime.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(189, 284);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(137, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Total Execution Time in ms:";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(419, 313);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbTime);
            this.Controls.Add(this.btnExecute);
            this.Controls.Add(this.dgvData);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(435, 352);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Async/Assert Demo";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvData)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbAsyncParallel;
        private System.Windows.Forms.RadioButton rbAsync;
        private System.Windows.Forms.RadioButton rbSync;
        private System.Windows.Forms.DataGridView dgvData;
        private System.Windows.Forms.Button btnExecute;
        private System.Windows.Forms.TextBox tbTime;
        private System.Windows.Forms.Label label1;
    }
}

