using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WinMessageSenderCS
{
    public partial class Logger : Form
    {
        public static Logger LoggerInst { get; set; }

        public static List<string> Lines { get; } = new List<string>();

        public static void WriteLine(string log, bool show_log = true)
        {
            if (show_log)
                ShowLogger();

            Lines.Add(log);

            if (string.IsNullOrWhiteSpace(LoggerInst.txtLog.Text))
                LoggerInst.txtLog.Text = log;
            else LoggerInst.txtLog.AppendText($"{Environment.NewLine}{log}");
        }
        


        //public TextBox LogBox { get { return this.txtLog; } }

        private string list_to_string(List<string> lst)
        {
            string str = null;
            foreach (var itm in lst)
            {
                if (str == null)
                    str = itm;
                str += $"\n{itm}";
            }
            return str;
        }
        public void UpdateLog()
        {
            if(Lines.Count > 0)
            {
                this.txtLog.Lines = Lines.ToArray();
                //this.txtLog.Text = "";
                //this.txtLog.Text = Logs.to
            }
        }

        
        public static void ShowLogger()
        {
            if (LoggerInst == null || LoggerInst.IsDisposed)
                LoggerInst = new Logger();

            LoggerInst.Show();
        }
        public new void Show()  
        {
            base.Show();
            this.UpdateLog();
        }
        
        public Logger()
        {
            InitializeComponent();
        }

        private void Logger_Load(object sender, EventArgs e)
        {

        }
    }
}
