using CefSharp;
using CefSharp.WinForms;
using Facebook;
using FacebookWizzard.JSONResponse;
using FacebookWizzard.Util;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FacebookWizzard.UserControl
{
    public partial class frmSingleResult : System.Windows.Forms.Form
    {
        public ChromiumWebBrowser browser;
        Response_PostDetail dataTMP = new Response_PostDetail();
        public frmSingleResult(Response_PostDetail obj)
        {
            InitializeComponent();
            InitEvent();
            dataTMP = obj;
            OnView(obj.id);
        }
        void InitEvent()
        {
            btnReload.Click += (o, e) =>
              {
                  try
                  {
                      var spl = dataTMP.id.Split('_');
                      browser.Load(@"https://www.facebook.com/" + spl[0] + "/posts/" + spl[1]);
                     
                  }
                  catch (Exception ex)
                  {

                  }
              };
            btnLikeAll.Click += (o, e) =>
            {
                if (dataTMP != null)
                {
                    try
                    {
                        foreach (dataCommentsClass item in dataTMP.comments.data)
                        {
                            string graph = @"https://graph.facebook.com/" + item.id + "/likes?access_token=" + Common.Token + "&method=POST";
                            //string graph = @"https://graph.facebook.com/1235717999927120_452237634941831_452238408275087/likes?access_token=EAAAAUaZA8jlABAPIYHZAhdtR6RVaa5zsniA82R1mgG1J3ZAz71XnOmEZAyKXocsFMRsW8Ni449TLekOzimk4vf3KyYtc4BYHtGNZBMuABBAAcBYtPDUv0fsbmVZAkZAoALwAVGaDL3TrBiILcKT8ZAlHRI3ZC4eMX1p75hBSnUKEK6B94zALBGeuf&method=POST";
                            HttpWebRequest myRequest = (HttpWebRequest)WebRequest.Create(graph);

                            // Send the data.
                            myRequest.Timeout = 5000;
                            myRequest.GetResponse();
                            //FacebookClient fc = new FacebookClient();
                            //fc.Post(graph);
                        }
                    }
                    catch (Exception ex)
                    {

                    }
                }
            };
        }
        public void OnView(string id)
        {
            try
            {

                Cef.Initialize(new CefSettings());
                browser = new ChromiumWebBrowser(@"https://www.facebook.com/" + id);
            }
            catch (Exception ex)
            {
                if (ex.Message.Equals("Cef can only be initialized once. Use Cef.IsInitialized to guard against this exception."))
                {
                    browser = new ChromiumWebBrowser(@"https://www.facebook.com/" + id);

                }

            }
            finally
            {
                pnFill.Controls.Add(browser);
                browser.Dock = DockStyle.Fill;
            }
        }
    }
}
