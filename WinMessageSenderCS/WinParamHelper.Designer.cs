namespace WinMessageSenderCS
{
    partial class WinParamHelper
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
            this.cbxParams = new System.Windows.Forms.ComboBox();
            this.btnOK = new System.Windows.Forms.Button();
            this.txtInfo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cbxParams
            // 
            this.cbxParams.FormattingEnabled = true;
            this.cbxParams.Location = new System.Drawing.Point(110, 6);
            this.cbxParams.Name = "cbxParams";
            this.cbxParams.Size = new System.Drawing.Size(254, 21);
            this.cbxParams.TabIndex = 0;
            // 
            // btnOK
            // 
            this.btnOK.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnOK.Location = new System.Drawing.Point(370, 4);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(75, 23);
            this.btnOK.TabIndex = 1;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            // 
            // txtInfo
            // 
            this.txtInfo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtInfo.Location = new System.Drawing.Point(15, 33);
            this.txtInfo.Multiline = true;
            this.txtInfo.Name = "txtInfo";
            this.txtInfo.ReadOnly = true;
            this.txtInfo.Size = new System.Drawing.Size(430, 101);
            this.txtInfo.TabIndex = 2;
            this.txtInfo.Text = "No info found. Please look info in microsoft documentation.\r\nIt will be avalible " +
    "in microsoft website.\r\nhttps://docs.microsoft.com/";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Possible param(s):";
            // 
            // WinParamHelper
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(455, 146);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtInfo);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.cbxParams);
            this.Name = "WinParamHelper";
            this.Text = "WinParamHelper";
            this.Load += new System.EventHandler(this.WinParamHelper_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbxParams;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.TextBox txtInfo;
        private System.Windows.Forms.Label label1;
    }
}