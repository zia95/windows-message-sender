namespace WinMessageSenderCS
{
    partial class WinMsgChoose
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
            this.lstMessages = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // lstMessages
            // 
            this.lstMessages.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lstMessages.FormattingEnabled = true;
            this.lstMessages.Location = new System.Drawing.Point(0, 0);
            this.lstMessages.Name = "lstMessages";
            this.lstMessages.Size = new System.Drawing.Size(241, 316);
            this.lstMessages.TabIndex = 0;
            this.lstMessages.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.LstMessages_MouseDoubleClick);
            // 
            // WinMsgChoose
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(241, 316);
            this.Controls.Add(this.lstMessages);
            this.Name = "WinMsgChoose";
            this.Text = "WinMsgChoose";
            this.Load += new System.EventHandler(this.WinMsgChoose_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lstMessages;
    }
}