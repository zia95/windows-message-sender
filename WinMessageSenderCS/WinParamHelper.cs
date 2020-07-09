using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using KVParam = System.Collections.Generic.KeyValuePair<string, string>;
namespace WinMessageSenderCS
{
    public partial class WinParamHelper : Form
    {

        
        public KVParam ParamKVResult { get { return m_poss[this.cbxParams.SelectedIndex]; } }
        public string ParamResult { get { return ParamKVResult.Value; } }

        public List<KVParam> m_poss = new List<KVParam>();

        public enum ParamType { WParam, LParam };

        private readonly ParamType m_pt;
        private readonly FunctionImports.WMsg m_wmsg;
        public WinParamHelper(FunctionImports.WMsg wmsg, ParamType pt)
        {
            InitializeComponent();

            this.m_wmsg = wmsg;
            this.m_pt = pt;
        }
        

        private void WinParamHelper_Load(object sender, EventArgs e)
        {
            this.Text = $"{m_pt.ToString()}:{m_wmsg}";
            
            if(m_wmsg == FunctionImports.WMsg.WM_KEYDOWN || m_wmsg == FunctionImports.WMsg.WM_KEYUP)
            {
                if(m_pt == ParamType.WParam)
                {
                    this.txtInfo.Text = "Must be virtual keycode.";
                    pop_cb_keys();
                    return;
                }
                else
                {
                    //this.txtInfo.Text = "";
                }
            }
            this.pop_cb_def();
        }

        private void pop_cb_def()
        {
            this.m_poss.Add(new KVParam("NULL (0)", "0"));
            this.cbxParams.Items.Add(this.m_poss.Last().Key);
            this.cbxParams.SelectedIndex = 0;
        }
        private void pop_cb_keys()
        {
            //string[] keys = Enum.GetNames(typeof(Keys));
            Array vals = Enum.GetValues(typeof(Keys));

            for (int i = 0; i < vals.Length; i++)
            {
                string k = vals.GetValue(i).ToString();
                int v = (int)vals.GetValue(i);
                this.m_poss.Add(new KVParam(k, v.ToString()));
                this.cbxParams.Items.Add(k);
            }
            this.cbxParams.SelectedIndex = 0;
        }
    }
}
