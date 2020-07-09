using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

using KVMsg = System.Collections.Generic.KeyValuePair<string, int>;
using KVList = System.Collections.Generic.List<System.Collections.Generic.KeyValuePair<string, int>>;

namespace WinMessageSenderCS
{
    public partial class WinMsgChoose : Form
    {
        private KVList m_messages = new KVList();
        private int m_index;

        public KVMsg ResultMessage { get { return m_messages[m_index]; } }


        private const string MSG_FILENAME = "winmsg.ini";

        

        private void populate_list()
        {
            if(File.Exists(MSG_FILENAME))
            {
                using (var sr = new StreamReader(MSG_FILENAME))
                {
                    string line = null;
                    //Logger.ShowLogger();
                    while ((line = sr.ReadLine()) != null)
                    {
                        int idx = line.IndexOf('=');
                        if (idx > 0)
                        {
                            string key = line.Substring(0, idx);
                            string val = line.Substring(++idx);
                            if(int.TryParse(val, out int ival))
                            {
                                m_messages.Add(new KVMsg(key, ival));
                            }
                            else
                            {
                                Logger.WriteLine($"[WinMsgChooser]Failed to parse winmsg.ini line '{line}'");
                            }
                        }
                    }
                }
            }
            else
            {
                string[] keys = Enum.GetNames(typeof(FunctionImports.WMsg));
                Array vals = Enum.GetValues(typeof(FunctionImports.WMsg));
                
                for(int i = 0; i < keys.Length; i++)
                {
                    int v = (int)vals.GetValue(i);
                    m_messages.Add(new KVMsg(keys[i], v));
                }
            }
            

            if(m_messages.Count > 0)
            {
                foreach(var m in m_messages)
                {
                    lstMessages.Items.Add($"{m.Value} -- {m.Key}");
                    if (m_sel == m.Value)//select previously selected item
                    {
                        lstMessages.SelectedIndex = (lstMessages.Items.Count - 1);
                    }
                }
            }
            this.Text = $"{m_messages.Count} messages";
        }

        private readonly int m_sel = -1;
        public WinMsgChoose(int selected)
        {
            InitializeComponent();
            this.m_sel = selected;
        }

        private void WinMsgChoose_Load(object sender, EventArgs e)
        {
            populate_list();
            //Logger.LoggerInst.WriteLog("this is test");
            //Logger.LoggerInst.WriteLog("this is test222222222");
        }

        private void LstMessages_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            m_index = lstMessages.SelectedIndex;
            this.DialogResult = DialogResult.OK;
        }
    }
}
