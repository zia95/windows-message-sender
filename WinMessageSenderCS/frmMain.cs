using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace WinMessageSenderCS
{
    public partial class frmMain : Form
    {
        private delegate void DefaultListCtlDelegate();

        private void listctl_add()
        {
            using (var msgdg = new WinMsgDlg(null))
            {
                if(msgdg.ShowDialog() == DialogResult.OK)
                {
                    list_add_msg(msgdg.Result);
                }
            }
        }
        private void listctl_rmv()
        {
            var itms = this.lstMessages.SelectedItems;
            if(itms.Count > 0)
            {
                itms[0].Remove();
                list_update_items();
            }
        }
        private void listctl_clr()
        {
            this.lstMessages.Items.Clear();
        }
        private void listctl_mvup()
        {

        }
        private void listctl_mvdwn()
        {

        }
        private void listctl_dup()
        {
            var sel = lstMessages.SelectedItems;
            if (sel.Count > 0)
                list_add_msg(sel[0].Tag as Message);
        }
        

        private void list_add_msgs(IEnumerable<Message> mesgs)
        {
            foreach (var m in StartupSettings.LoadMessages())
            {
                list_add_msg(m);
            }
        }
        private ListViewItem list_add_msg(Message m)
        {
            if (m != null)
            {
                ListViewItem lvi = new ListViewItem();
                string[] sitms = { m.Name, m.hWnd.ToString(), m.Msg.ToString(), m.wParam.ToString(), m.lParam.ToString(), "0" };
                lvi.Tag = m;
                lvi.SubItems.AddRange(sitms);
                lvi.Text = (lstMessages.Items.Count + 1).ToString();
                return lstMessages.Items.Add(lvi);
            }
            else
            {
                MessageBox.Show("Invalid message cannot!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
        }
        private void list_update(ListViewItem lvi, Message new_msg)
        {
            lvi.Tag = new_msg;
            string idx = lvi.Text;
            string[] sitms = { new_msg.Name, new_msg.hWnd.ToString(),
                new_msg.Msg.ToString(), new_msg.wParam.ToString(), new_msg.lParam.ToString(), "0"};


            lvi.SubItems.Clear();
            lvi.SubItems.AddRange(sitms);
            lvi.Text = idx;
        }
        private void list_update_items()
        {
            for(int i = 0; i < lstMessages.Items.Count; i++)
            {
                lstMessages.Items[i].Text = (i+1).ToString();
            }
        }
        private void list_clear_status()
        {
            foreach (ListViewItem lvi in lstMessages.Items)
                list_set_status(lvi, "0");
        }
        private void list_set_status(ListViewItem lvi, string status)
        {
            lvi.SubItems[6].Text = status;
        }
        private IEnumerable<Message> list_get_messages()
        {
            foreach(ListViewItem lvi in lstMessages.Items)
            {
                yield return (Message)lvi.Tag;
            }
            yield break;
        }

        public frmMain()
        {
            InitializeComponent();
        }
        
        private void FrmMain_Load(object sender, EventArgs e)
        {
            //new WinMsgDlg().Show();
            tolMnuAdd.Tag = new DefaultListCtlDelegate(listctl_add);
            tolMnuClear.Tag = new DefaultListCtlDelegate(listctl_clr);
            tolMnuRemove.Tag = new DefaultListCtlDelegate(listctl_rmv);
            tolMnuMoveUp.Tag = new DefaultListCtlDelegate(listctl_mvup);
            tolMnuMoveDown.Tag = new DefaultListCtlDelegate(listctl_mvdwn);

            this.tolBtnListCtl.Text = this.tolMnuAdd.Text;
            this.tolBtnListCtl.Tag = this.tolMnuAdd.Tag;

            //context menu
            ctxAddItem.Tag = tolMnuAdd.Tag;
            ctxRemoveItem.Tag = tolMnuRemove.Tag;
            ctxClearItems.Tag = tolMnuClear.Tag;
            ctxDuplicateItem.Tag = new DefaultListCtlDelegate(listctl_dup);
            ctxMoveUp.Tag = tolMnuMoveUp.Tag;
            ctxMoveDown.Tag = tolMnuMoveDown.Tag;


            list_add_msgs(StartupSettings.LoadMessages());
            
        }
        private void FrmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            StartupSettings.SaveMessages(list_get_messages());
        }

        private void TolBtnListCtl_ButtonClick(object sender, EventArgs e)
        {
            ((DefaultListCtlDelegate)this.tolBtnListCtl.Tag)();
        }
        private void TolBtnListCtl_DropDownItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            //tool box
            if(e.ClickedItem is ToolStripMenuItem)
            {
                this.tolBtnListCtl.Text = e.ClickedItem.Text;
                this.tolBtnListCtl.Tag = e.ClickedItem.Tag;
                TolBtnListCtl_ButtonClick(this, e);
            }
        }
        private void CtxListMenu_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            //list context menu
            if(e.ClickedItem is ToolStripMenuItem)
            {
                ((DefaultListCtlDelegate)e.ClickedItem.Tag)();
            }
        }
        private void send_messages(FunctionImports.SMMethod mth)
        {
            foreach (ListViewItem itm in this.lstMessages.Items)
            {
                if (itm.Checked)
                {
                    Message msg = itm.Tag as Message;
                    int ret = msg.Fire(mth);
                    list_set_status(itm, ret.ToString());
                    //Logger.WriteLine($"[MessageSender] Info: Message {msg} sent. (Result:{ret})");
                }
                else
                {
                    list_set_status(itm, "0");
                }
            }
        }
        private void TolBtnSendMsg_Click(object sender, EventArgs e)
        {
            send_messages(FunctionImports.SMMethod.Send);
        }
        private void TolBtnPostMsgA_Click(object sender, EventArgs e)
        {
            send_messages(FunctionImports.SMMethod.PostA);
        }

        private void TolBtnPostMsgW_Click(object sender, EventArgs e)
        {
            send_messages(FunctionImports.SMMethod.PostW);
        }

        private void LstMessages_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            ListViewItem itm = lstMessages.SelectedItems[0];
            using (var msgdg = new WinMsgDlg(itm.Tag as Message))
            {
                if (msgdg.ShowDialog() == DialogResult.OK)
                {
                    list_update(itm, msgdg.Result);
                }
            }
        }

        
    }
}
