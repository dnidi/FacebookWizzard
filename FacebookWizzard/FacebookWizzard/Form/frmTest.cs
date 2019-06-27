using FacebookWizzard.UserControl;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using Facebook;
using Newtonsoft.Json;
using DevExpress.Utils;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraGrid.Views.Grid.ViewInfo;
using FacebookWizzard.JSONResponse;
using System.Net;
using FacebookWizzard.Util;
using CefSharp;
using CefSharp.WinForms;

namespace FacebookWizzard.Form
{
    public partial class frmTest : System.Windows.Forms.Form
    {
        
        public frmTest()
        {
            InitializeComponent();

            //LoadUrls("facebook.com,google.com".Split(',').ToList());
            OnView("facebook.com");
        }

        public ChromiumWebBrowser browser;
        public void OnView(string link)
        {
            try
            {

                Cef.Initialize(new CefSettings());
                browser = new ChromiumWebBrowser(link);
            }
            catch (Exception ex)
            {
                if (ex.Message.Equals("Cef can only be initialized once. Use Cef.IsInitialized to guard against this exception."))
                {
                    browser = new ChromiumWebBrowser(link);
                    
                }

            }
            finally
            {
                pnFill.Controls.Add(browser);
                browser.Dock = DockStyle.Fill;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            browser.Load("google.com");
          //  browser.Reload(false);
            //OnView("google.com");
        }
    }

    

}
