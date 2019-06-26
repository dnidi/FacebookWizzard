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

namespace FacebookWizzard.Form
{
    public partial class frmMain : System.Windows.Forms.Form
    {
        public string Token
        {
            get {
                Common.Token = txtToken.Text;
                return txtToken.Text;
               
            }
            set
            {
                txtToken.Text = value;
                
            }
        }
        public string Errors { get; set; }
        public frmMain()
        {
            InitializeComponent();
            
            //LoadUrls("facebook.com,google.com".Split(',').ToList());
            txtToken.Text = "EAAAAUaZA8jlABAJBWTeZBffGN25J9UIkseOVnuZAoxtHUbwdfDlPZApiEqCmcMWYUGdUs1ZAwt1W7sp4OOZBRZAD6NAFVOZClxFL09M98tvb6NNwqBeO0vWn80nLyJ1zjeYwlIAi2npDZA0AnxQ2VStumXVBRsOaMy10uuK1Ff7RMGuZAPaKXFZATjP";
            LoadComboChucNang();
            InitEvents();
        }

        void InitEvents()
        {
            cbChucNang.SelectedIndexChanged += (o, e) =>
            {
                lblError.Visible = false;
                try
                {
                    int index = cbChucNang.SelectedIndex;
                    object Result = null;
                    FacebookClient fc = new FacebookClient(Token);
                    var request = "";

                    switch (index)
                    {
                        case 0:
                            request = "https://graph.facebook.com/v3.3/me/groups?access_token=" + Token;
                            Result = fc.Get(request).ToString();
                            Response_JoinedGroups response = JsonConvert.DeserializeObject<Response_JoinedGroups>(Result.ToString());
                            if (response != null)
                            {
                                usGroup usGroup = new usGroup(response);
                                usGroup.TopLevel = false;
                                usGroup.Dock = DockStyle.Fill;
                                pnFill.Controls.Add(usGroup);
                                usGroup.BringToFront();
                                usGroup.Show();
                            }
                            break;
                        case 1:
                            request = "https://graph.facebook.com/v3.3/me/posts?access_token=" + Token;
                            Result = fc.Get(request).ToString();
                            Response_Posts response_Posts = JsonConvert.DeserializeObject<Response_Posts>(Result.ToString());
                            if (response_Posts != null)
                            {
                                usPost usPosts = new usPost(response_Posts);
                                usPosts.TopLevel = false;
                                usPosts.Dock = DockStyle.Fill;
                                pnFill.Controls.Add(usPosts);
                                usPosts.Show();
                            }
                            break;
                        case 2:
                            request = "https://graph.facebook.com/v3.3/me/feed?access_token=" + Token;
                            Result = fc.Get(request).ToString();
                            Response_Posts response_Feed = JsonConvert.DeserializeObject<Response_Posts>(Result.ToString());
                            if (response_Feed != null)
                            {
                                usFeed usFeeds = new usFeed(response_Feed);
                                usFeeds.TopLevel = false;
                                usFeeds.Dock = DockStyle.Fill;
                                pnFill.Controls.Add(usFeeds);
                                usFeeds.Show();
                            }
                            break;

                    }
                }
                catch (Exception ex)
                {
                    lblError.Visible = true;
                    lblError.Text = ex.Message;
                }

            };
            btnProcess.Click += (o, e) =>
            {
                try
                {

                }
                catch (Exception ex)
                {

                }
            };
            //gridView.DoubleClick += (o, e) =>
            //{
            //    DXMouseEventArgs ea = e as DXMouseEventArgs;
            //    GridView view = o as GridView;
            //    GridHitInfo info = view.CalcHitInfo(ea.Location);
            //    if (info.InRow || info.InRowCell)
            //    {
            //        try
            //        {


            //        }
            //        catch (Exception ex)
            //        {

            //        }
            //    }
            //};
        }
        //====================Methods==================
        bool LikePost(string PostID)
        {
            var req = "https://graph.facebook.com/" + PostID + "/likes?access_token=" + Token + "&method=POST";
            var request = (HttpWebRequest)WebRequest.Create(req);
            request.GetResponse();
            return false;
        }
        void LoadComboChucNang()
        {
            cbChucNang.ValueMember = "MaChucNang";
            cbChucNang.DisplayMember = "TenChucNang";
            cbChucNang.SelectedIndex = -1;
            cbChucNang.DataSource = InitChucNang();

        }
        List<BoxItem> InitChucNang()
        {
            List<BoxItem> lstItem = new List<BoxItem>();
            lstItem.Add(new BoxItem(1, "Lấy danh sách nhóm tham gia"));
            lstItem.Add(new BoxItem(2, "Lấy danh sách post"));
            lstItem.Add(new BoxItem(3, "Lấy danh sách post trên newfeed"));
            //lstItem.Add(new BoxItem(4, "Đếm like trang"));
            //lstItem.Add(new BoxItem(5, "Gửi tin nhắn theo list id"));
            //lstItem.Add(new BoxItem(6, "Mời thích trang"));
            //lstItem.Add(new BoxItem(7, "Mời tham gia sự kiện"));
            //lstItem.Add(new BoxItem(8, "Share post trên group"));
            //lstItem.Add(new BoxItem(9, "Share post lên tường bạn bè"));
            return lstItem;
        }

        void LoadUrls(List<string> urls)
        {
            try
            {
                //foreach (string item in urls)
                {
                    ctrEmbedBrowser browser = new ctrEmbedBrowser();
                    browser.LoadUrl("google.com");

                }
            }
            catch (Exception ex)
            {

            }
        }
    }

    public class BoxItem
    {
        public int MaChucNang { get; set; }
        public string TenChucNang { get; set; }
        public BoxItem(int ma, string ten)
        {
            this.MaChucNang = ma;
            this.TenChucNang = ten;
        }
    }

}
