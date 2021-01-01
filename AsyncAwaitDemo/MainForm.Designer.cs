
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
            this.lblFormSize = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.showSizeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvData)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.rbAsyncParallel);
            this.groupBox1.Controls.Add(this.rbAsync);
            this.groupBox1.Controls.Add(this.rbSync);
            this.groupBox1.Location = new System.Drawing.Point(309, 34);
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
            this.dgvData.Location = new System.Drawing.Point(12, 143);
            this.dgvData.Name = "dgvData";
            this.dgvData.Size = new System.Drawing.Size(426, 179);
            this.dgvData.TabIndex = 1;
            // 
            // btnExecute
            // 
            this.btnExecute.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExecute.Location = new System.Drawing.Point(33, 56);
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
            this.tbTime.Location = new System.Drawing.Point(393, 331);
            this.tbTime.Name = "tbTime";
            this.tbTime.ReadOnly = true;
            this.tbTime.Size = new System.Drawing.Size(46, 20);
            this.tbTime.TabIndex = 3;
            this.tbTime.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(259, 335);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(133, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Total Execution Time (sec)";
            // 
            // lblFormSize
            // 
            this.lblFormSize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblFormSize.AutoSize = true;
            this.lblFormSize.Location = new System.Drawing.Point(15, 335);
            this.lblFormSize.Name = "lblFormSize";
            this.lblFormSize.Size = new System.Drawing.Size(10, 13);
            this.lblFormSize.TabIndex = 5;
            this.lblFormSize.Text = " ";
            this.lblFormSize.Visible = false;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(450, 24);
            this.menuStrip1.TabIndex = 6;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.showSizeToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "&File";
            // 
            // showSizeToolStripMenuItem
            // 
            this.showSizeToolStripMenuItem.Name = "showSizeToolStripMenuItem";
            this.showSizeToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.showSizeToolStripMenuItem.Text = "Show Form &Size";
            this.showSizeToolStripMenuItem.Click += new System.EventHandler(this.OnShowSize);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.aboutToolStripMenuItem.Text = "A&bout";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.OnAbout);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(450, 362);
            this.Controls.Add(this.lblFormSize);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbTime);
            this.Controls.Add(this.btnExecute);
            this.Controls.Add(this.dgvData);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MinimumSize = new System.Drawing.Size(466, 401);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Async/Assert Demo";
            this.Resize += new System.EventHandler(this.OnFormResize);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvData)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
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
        private System.Windows.Forms.Label lblFormSize;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem showSizeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
    }
}

