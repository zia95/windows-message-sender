using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WinMessageSenderCS
{
    public static class StartupSettings
    {
        public static IEnumerable<Message> LoadMessages()
        {
            var names = Properties.Settings.Default.itms_name;
            var hwnds = Properties.Settings.Default.itm_hWnd;
            var msgs = Properties.Settings.Default.itm_msg;
            var wparams = Properties.Settings.Default.itm_wparam;
            var lparams = Properties.Settings.Default.itm_lparam;

            if(names != null)
            {
                int count = names.Count;
                if (count == hwnds.Count &&
                    count == msgs.Count &&
                    count == wparams.Count &&
                    count == lparams.Count)
                {
                    for (int i = 0; i < count; i++)
                    {
                        Message parsed = Message.Parse(hwnds[i], msgs[i], wparams[i], lparams[i], names[i]);
                        if (parsed != null)
                        {
                            yield return parsed;
                        }
                    }
                }
            }

            
            yield break;
        }

        public static void SaveMessages(IEnumerable<Message> mesgs)
        {
            var _names = new System.Collections.Specialized.StringCollection();
            var _hwnds = new System.Collections.Specialized.StringCollection();
            var _msgs = new System.Collections.Specialized.StringCollection();
            var _wparams = new System.Collections.Specialized.StringCollection();
            var _lparams = new System.Collections.Specialized.StringCollection();

            foreach(var m in mesgs)
            {
                _names.Add(m.Name);
                _hwnds.Add(m.hWnd.ToString());
                _msgs.Add(m.Msg.ToString());
                _wparams.Add(m.wParam.ToString());
                _lparams.Add(m.lParam.ToString());
            }

            Properties.Settings.Default.itms_name = _names;
            Properties.Settings.Default.itm_hWnd = _hwnds;
            Properties.Settings.Default.itm_msg = _msgs;
            Properties.Settings.Default.itm_wparam = _wparams;
            Properties.Settings.Default.itm_lparam = _lparams;

            Properties.Settings.Default.Save();
        }
    }
}
