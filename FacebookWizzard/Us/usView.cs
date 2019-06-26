using CefSharp;
using CefSharp.WinForms;
using FacebookWizzard.Viewer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FacebookWizzard.Us
{
    public partial class usView : Form
    {
        public ChromiumWebBrowser browser;
        JSON_Response json = null;
        public string Token { get; set; }
        public usView(string link, string token)
        {
            InitializeComponent();
            OnView(link);
        }
        void InitEvents()
        {
            btnLikeAll.Click += (o, e) =>
            {
                if (json != null)
                {
                    foreach (dataCommentsClass item in json.comments.data)
                    {
                        string graph = @"https://graph.facebook.com/"+item.id+"/likes?access_token="+ Token + "&method=POST";
                    }
                }
            };
        }
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
                pnView.Controls.Add(browser);
                browser.Dock = DockStyle.Fill;
            }
        }
    }
}
