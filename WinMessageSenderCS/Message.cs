using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WinMessageSenderCS
{
    public class Message
    {
        public string   Name      { get; set; }// just for identfi
        public IntPtr   hWnd      { get; set; } = IntPtr.Zero;
        public int      Msg      { get; set; } = 0;
        public IntPtr   wParam    { get; set; } = IntPtr.Zero;
        public IntPtr   lParam    { get; set; } = IntPtr.Zero;


        public Message() { }
        public Message(IntPtr hWnd, int Msg, IntPtr wParam, IntPtr lParam, string Name = "<noname>")
        {
            this.hWnd = hWnd;
            this.Msg = Msg;
            this.wParam = wParam;
            this.lParam = lParam;
            this.Name = Name;
        }

        public void Set(IntPtr hWnd, int Msg, IntPtr wParam, IntPtr lParam, string Name = "<noname>")
        {
            this.hWnd = hWnd;
            this.Msg = Msg;
            this.wParam = wParam;
            this.lParam = lParam;
            this.Name = Name;
        }

        public int Fire(FunctionImports.SMMethod method) => FunctionImports.SendMessage(hWnd, Msg, wParam, lParam, method);

        public override string ToString() => $"[Name:{Name}, hWnd:{hWnd}, Msg:{Msg}, wParam:{wParam}, lParam:{lParam}]";

        public static Message Parse(string hWnd, string Msg, string wParam, string lParam, string Name = "<noname>")
        {
            if(uint.TryParse(hWnd, out uint ihwd))
            {
                if (uint.TryParse(Msg, out uint imsg))
                {
                    if (uint.TryParse(wParam, out uint iwp))
                    {
                        if (uint.TryParse(lParam, out uint ilp))
                        {
                            return new Message(new IntPtr(ihwd), (int)imsg, new IntPtr(iwp), new IntPtr(ilp), Name);
                        }
                    }
                }
            }
            return null;
        }
    }
}
