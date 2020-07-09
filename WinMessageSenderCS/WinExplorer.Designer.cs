namespace WinMessageSenderCS
{
    partial class WinExplorer
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
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.lstProcess = new System.Windows.Forms.ListView();
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lstWindows = new System.Windows.Forms.ListView();
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.lstProcess);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.lstWindows);
            this.splitContainer1.Size = new System.Drawing.Size(532, 450);
            this.splitContainer1.SplitterDistance = 177;
            this.splitContainer1.TabIndex = 0;
            // 
            // lstProcess
            // 
            this.lstProcess.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader2,
            this.columnHeader3});
            this.lstProcess.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lstProcess.FullRowSelect = true;
            this.lstProcess.GridLines = true;
            this.lstProcess.HideSelection = false;
            this.lstProcess.Location = new System.Drawing.Point(0, 0);
            this.lstProcess.MultiSelect = false;
            this.lstProcess.Name = "lstProcess";
            this.lstProcess.Size = new System.Drawing.Size(177, 450);
            this.lstProcess.TabIndex = 0;
            this.lstProcess.UseCompatibleStateImageBehavior = false;
            this.lstProcess.View = System.Windows.Forms.View.Details;
            this.lstProcess.SelectedIndexChanged += new System.EventHandler(this.LstProcess_SelectedIndexChanged);
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Name";
            this.columnHeader2.Width = 103;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Id";
            this.columnHeader3.Width = 50;
            // 
            // lstWindows
            // 
            this.lstWindows.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6,
            this.columnHeader7});
            this.lstWindows.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lstWindows.FullRowSelect = true;
            this.lstWindows.GridLines = true;
            this.lstWindows.HideSelection = false;
            this.lstWindows.Location = new System.Drawing.Point(0, 0);
            this.lstWindows.MultiSelect = false;
            this.lstWindows.Name = "lstWindows";
            this.lstWindows.Size = new System.Drawing.Size(351, 450);
            this.lstWindows.TabIndex = 0;
            this.lstWindows.UseCompatibleStateImageBehavior = false;
            this.lstWindows.View = System.Windows.Forms.View.Details;
            this.lstWindows.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.LstWindows_MouseDoubleClick);
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "#";
            this.columnHeader4.Width = 20;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "hWnd";
            this.columnHeader5.Width = 95;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Class";
            this.columnHeader6.Width = 113;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "Title";
            this.columnHeader7.Width = 119;
            // 
            // WinExplorer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(532, 450);
            this.Controls.Add(this.splitContainer1);
            this.Name = "WinExplorer";
            this.Text = "WinExplorer";
            this.Load += new System.EventHandler(this.WinExplorer_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.ListView lstProcess;
        private System.Windows.Forms.ListView lstWindows;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader7;
    }
}