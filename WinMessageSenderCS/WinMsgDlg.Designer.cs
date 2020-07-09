namespace WinMessageSenderCS
{
    partial class WinMsgDlg
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtHwnd = new System.Windows.Forms.TextBox();
            this.btnHwnd = new System.Windows.Forms.Button();
            this.txtWMsg = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtWParam = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtLParam = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnWMsg = new System.Windows.Forms.Button();
            this.btnWParam = new System.Windows.Forms.Button();
            this.btnLParam = new System.Windows.Forms.Button();
            this.btnOK = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.txtName = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "hWnd:";
            // 
            // txtHwnd
            // 
            this.txtHwnd.Location = new System.Drawing.Point(60, 33);
            this.txtHwnd.Name = "txtHwnd";
            this.txtHwnd.Size = new System.Drawing.Size(301, 20);
            this.txtHwnd.TabIndex = 1;
            this.txtHwnd.Text = "0";
            // 
            // btnHwnd
            // 
            this.btnHwnd.Location = new System.Drawing.Point(367, 31);
            this.btnHwnd.Name = "btnHwnd";
            this.btnHwnd.Size = new System.Drawing.Size(25, 23);
            this.btnHwnd.TabIndex = 2;
            this.btnHwnd.Text = "...";
            this.btnHwnd.UseVisualStyleBackColor = true;
            this.btnHwnd.Click += new System.EventHandler(this.BtnHwnd_Click);
            // 
            // txtWMsg
            // 
            this.txtWMsg.Location = new System.Drawing.Point(60, 59);
            this.txtWMsg.Name = "txtWMsg";
            this.txtWMsg.Size = new System.Drawing.Size(301, 20);
            this.txtWMsg.TabIndex = 4;
            this.txtWMsg.Text = "0";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Msg:";
            // 
            // txtWParam
            // 
            this.txtWParam.Location = new System.Drawing.Point(60, 85);
            this.txtWParam.Name = "txtWParam";
            this.txtWParam.Size = new System.Drawing.Size(301, 20);
            this.txtWParam.TabIndex = 6;
            this.txtWParam.Text = "0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 88);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "wParam:";
            // 
            // txtLParam
            // 
            this.txtLParam.Location = new System.Drawing.Point(60, 111);
            this.txtLParam.Name = "txtLParam";
            this.txtLParam.Size = new System.Drawing.Size(301, 20);
            this.txtLParam.TabIndex = 8;
            this.txtLParam.Text = "0";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 114);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "lParam:";
            // 
            // btnWMsg
            // 
            this.btnWMsg.Location = new System.Drawing.Point(367, 57);
            this.btnWMsg.Name = "btnWMsg";
            this.btnWMsg.Size = new System.Drawing.Size(25, 23);
            this.btnWMsg.TabIndex = 9;
            this.btnWMsg.Text = "...";
            this.btnWMsg.UseVisualStyleBackColor = true;
            this.btnWMsg.Click += new System.EventHandler(this.BtnWMsg_Click);
            // 
            // btnWParam
            // 
            this.btnWParam.Location = new System.Drawing.Point(367, 83);
            this.btnWParam.Name = "btnWParam";
            this.btnWParam.Size = new System.Drawing.Size(25, 23);
            this.btnWParam.TabIndex = 10;
            this.btnWParam.Text = "...";
            this.btnWParam.UseVisualStyleBackColor = true;
            this.btnWParam.Click += new System.EventHandler(this.BtnWParam_Click);
            // 
            // btnLParam
            // 
            this.btnLParam.Location = new System.Drawing.Point(367, 109);
            this.btnLParam.Name = "btnLParam";
            this.btnLParam.Size = new System.Drawing.Size(25, 23);
            this.btnLParam.TabIndex = 11;
            this.btnLParam.Text = "...";
            this.btnLParam.UseVisualStyleBackColor = true;
            this.btnLParam.Click += new System.EventHandler(this.BtnLParam_Click);
            // 
            // btnOK
            // 
            this.btnOK.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnOK.Location = new System.Drawing.Point(242, 138);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(150, 23);
            this.btnOK.TabIndex = 12;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            // 
            // btnClose
            // 
            this.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnClose.Location = new System.Drawing.Point(15, 138);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(150, 23);
            this.btnClose.TabIndex = 13;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(60, 7);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(301, 20);
            this.txtName.TabIndex = 15;
            this.txtName.Text = "<noname>";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 10);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(38, 13);
            this.label5.TabIndex = 14;
            this.label5.Text = "Name:";
            // 
            // WinMsgDlg
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(403, 167);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.btnLParam);
            this.Controls.Add(this.btnWParam);
            this.Controls.Add(this.btnWMsg);
            this.Controls.Add(this.txtLParam);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtWParam);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtWMsg);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnHwnd);
            this.Controls.Add(this.txtHwnd);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "WinMsgDlg";
            this.Text = "WinMsgDlg";
            this.Load += new System.EventHandler(this.WinMsgDlg_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtHwnd;
        private System.Windows.Forms.Button btnHwnd;
        private System.Windows.Forms.TextBox txtWMsg;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtWParam;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtLParam;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnWMsg;
        private System.Windows.Forms.Button btnWParam;
        private System.Windows.Forms.Button btnLParam;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label label5;
    }
}