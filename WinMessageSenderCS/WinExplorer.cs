using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Diagnostics;

namespace WinMessageSenderCS
{
    public partial class WinExplorer : Form
    {
        private hWndInfo m_result = null;
        public hWndInfo Result { get { return m_result; } }

        public class hWndInfo
        {
            public IntPtr hWnd { get; set; }
            public string WindowText { get; set; }
            public string ClassName { get; set; }

            public uint Pid { get; set; }
            public string Name { get; set; }

            public Process Process { get; set; }

            public hWndInfo(IntPtr hWnd, string WindowText, string ClassName)
            {
                this.hWnd = hWnd;
                this.WindowText = WindowText;
                this.ClassName = ClassName;
            }

            public void UpdateProcess()
            {
                foreach (var proc in Process.GetProcesses())
                {
                    if (proc.Id == this.Pid)
                    {
                        this.Process = proc;
                    }
                    else
                    {
                        foreach (ProcessThread t in proc.Threads)
                        {
                            if (t.Id == this.Pid)
                            {
                                this.Process = proc;
                                return;
                            }
                        }
                    }
                }
            }
            public void UpdateWindowText() => this.WindowText = FunctionImports.GetWindowText(this.hWnd);
            public void UpdateClassName() => this.ClassName = FunctionImports.GetClassName(this.hWnd);
            public void UpdatePid() => this.Pid = FunctionImports.GetProcessId(this.hWnd);
            //public void UpdateName() => this.Name = FunctionImports.GetProcessNameById(this.Pid);
            public void UpdateName()
            {
                this.UpdateProcess();
                this.Name = this.Process?.ProcessName;
            }
        }
        public class ParenthWndInfo
        {
            public hWndInfo Parent { get; set; } = null;
            public List<hWndInfo> ChildList { get; set; } = null;

            public bool ChildExist(IntPtr hWnd) => ChildList.Where(x => x.hWnd == hWnd).Count() > 0;

            public ParenthWndInfo(hWndInfo Parent, List<hWndInfo> ChildList)
            {
                this.Parent = Parent;
                this.ChildList = ChildList;
            }
            public void UpdateChilds()
            {
                List<IntPtr> chwnd = FunctionImports.GetAllChildWindows(this.Parent.hWnd);

                if (this.ChildList == null)
                    this.ChildList = new List<hWndInfo>();
                this.ChildList.Add(this.Parent); // add parent window too
                if (chwnd != null)
                {
                    foreach (var ch in chwnd)
                    {
                        hWndInfo chinfo = new hWndInfo(ch, null, null);
                        chinfo.UpdateClassName();
                        chinfo.UpdateWindowText();

                        

                        this.ChildList.Add(chinfo);
                    }
                } 
            }

            public static IEnumerable<ParenthWndInfo> GetAll()
            {
                List<IntPtr> phwnd = FunctionImports.GetAllParentWindow();
                if (phwnd != null)
                {
                    foreach (var ph in phwnd)
                    {
                        ParenthWndInfo phinfo = new ParenthWndInfo(null, null);
                        phinfo.Parent = new hWndInfo(ph, null, null);

                        phinfo.Parent.UpdateClassName();
                        phinfo.Parent.UpdateWindowText();
                        phinfo.Parent.UpdatePid();
                        phinfo.Parent.UpdateName();

                        phinfo.UpdateChilds();

                        yield return phinfo;
                    }
                }
                
            }
        }

        public void RefreshList()
        {
            this.lstProcess.Items.Clear();
            foreach (var ph in ParenthWndInfo.GetAll())
            {
                String[] subitms = { ph.Parent.Pid.ToString() };
                ListViewItem lvi = new ListViewItem();
                lvi.Tag = ph;
                lvi.Text = ph.Parent.Name?.ToString();
                lvi.SubItems.AddRange(subitms);
                var itm = this.lstProcess.Items.Add(lvi);

                if (ph.ChildExist(m_sel))
                {
                    itm.Selected = true;
                }
            }
        }
        public void RefreshChildList(ParenthWndInfo info)
        {
            this.lstWindows.Items.Clear();

            //idx, hwnd, class, title
            if (info.ChildList?.Count > 0)
            {
                for (int i = 0; i < info.ChildList.Count; i++)
                {
                    hWndInfo chwnd = info.ChildList[i];

                    String[] subitms = { chwnd.hWnd.ToString(), chwnd.ClassName, chwnd.WindowText };


                    ListViewItem lvi = new ListViewItem();
                    lvi.Tag = info;
                    lvi.Text = (i+1).ToString();
                    lvi.SubItems.AddRange(subitms);
                    var itm = this.lstWindows.Items.Add(lvi);
                    if(chwnd.hWnd.Equals(m_sel))
                    {
                        itm.Selected = true;
                    }
                }
            }
        }

        public void DialogEnd()
        {
            var idxs = this.lstWindows.SelectedIndices;

            if(idxs.Count > 0)
            {
                int idx = idxs[0];
                var itm = this.lstWindows.Items[idx];
                var info = itm.Tag as ParenthWndInfo;
                this.m_result = info.ChildList[idx];

                this.DialogResult = DialogResult.OK;
            }
            
        }

        //private int m_csel;//index of item to select in child window
        private readonly IntPtr m_sel;// selected child hWnd
        public WinExplorer(IntPtr selected)
        {
            InitializeComponent();
            m_sel = selected;
        }

        private void WinExplorer_Load(object sender, EventArgs e)
        {
            RefreshList();
        }

        private void LstProcess_SelectedIndexChanged(object sender, EventArgs e)
        {
            var slvis = this.lstProcess.SelectedItems;
            if(slvis?.Count > 0)
            {
                ListViewItem slvi = slvis[0];
                var info = slvi.Tag as ParenthWndInfo;
                if (info != null)
                    this.RefreshChildList(info);
            }
        }

        private void LstWindows_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            DialogEnd();
        }
    }
}
