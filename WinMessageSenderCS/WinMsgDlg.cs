using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using KVMsg = System.Collections.Generic.KeyValuePair<string, int>;

namespace WinMessageSenderCS
{
    public partial class WinMsgDlg : Form
    {

        public Message Result
        {
            get
            {
                return Message.Parse(this.txtHwnd.Text, this.txtWMsg.Text, this.txtWParam.Text, this.txtLParam.Text, this.txtName.Text);
            }
        }

        public readonly Message m_edt;
        public WinMsgDlg(Message msg)
        {
            InitializeComponent();
            m_edt = msg;
        }

        private void WinMsgDlg_Load(object sender, EventArgs e)
        {
            if(m_edt != null)
            {
                this.txtName.Text = m_edt.Name;
                this.txtHwnd.Text = m_edt.hWnd.ToString();
                this.txtWMsg.Text = m_edt.Msg.ToString();
                this.txtWParam.Text = m_edt.wParam.ToString();
                this.txtLParam.Text = m_edt.lParam.ToString();
            }
        }

        private void BtnHwnd_Click(object sender, EventArgs e)
        {
            int ihwd = 0;
            if (!int.TryParse(this.txtHwnd.Text, out ihwd))
                ihwd = 0;
            using (var winexp = new WinExplorer((IntPtr)ihwd))
            {
                if(winexp.ShowDialog() == DialogResult.OK)
                {
                    this.txtHwnd.Text = winexp.Result.hWnd.ToString();
                }
            }
        }

        private void BtnWMsg_Click(object sender, EventArgs e)
        {
            int myi = -1;
            if (int.TryParse(this.txtWMsg.Text, out myi) == false)
                myi = -1;

            using (var msg = new WinMsgChoose(myi))
            {
                if(msg.ShowDialog() == DialogResult.OK)
                {
                    this.txtWMsg.Text = msg.ResultMessage.Value.ToString();
                }
            }
        }

        private void open_paramdlg(WinParamHelper.ParamType pt)
        {
            if(string.IsNullOrWhiteSpace(this.txtWMsg.Text))
            {
                MessageBox.Show("You must choose wmsg first.", "info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }


            if (int.TryParse(this.txtWMsg.Text, out int wmsg))
            {
                using (var param = new WinParamHelper((FunctionImports.WMsg)wmsg, pt))
                {
                    if (param.ShowDialog() == DialogResult.OK)
                    {
                        (pt == WinParamHelper.ParamType.WParam ? this.txtWParam : this.txtLParam).Text = param.ParamResult;
                    }
                }
            }
            else
            {
                MessageBox.Show("invalid wmsg", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            
        }
        private void BtnWParam_Click(object sender, EventArgs e)
        {
            open_paramdlg(WinParamHelper.ParamType.WParam);
        }

        private void BtnLParam_Click(object sender, EventArgs e)
        {
            open_paramdlg(WinParamHelper.ParamType.LParam);
        }
    }
}
