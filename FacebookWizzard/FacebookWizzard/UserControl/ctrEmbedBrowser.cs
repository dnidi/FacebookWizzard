
using CefSharp;
using CefSharp.WinForms;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace FacebookWizzard.UserControl
{
    public partial class ctrEmbedBrowser : System.Windows.Forms.UserControl
    {
        public string Error { get; set; }
        public string Url { get; set; }
        public List<string> Urls { get; set; }
        public ChromiumWebBrowser browser;
        public ctrEmbedBrowser()
        {
            InitializeComponent();
        }
        //========================Events===================






        //=========================Methods====================
        public void InitCef()
        {
            
        }
        public void LoadUrl(string url)
        {
            try
            {
                Cef.Initialize(new CefSettings());
                browser = new ChromiumWebBrowser("google.com");
                this.pnFill.Controls.Add(browser);
                browser.Dock = DockStyle.Fill;
            }
            catch (Exception ex)
            {
                Error = ex.Message;
            }
        }
    }
}
