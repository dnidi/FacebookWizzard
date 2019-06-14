using FacebookWizzard.UserControl;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using Facebook;

namespace FacebookWizzard.Form
{
    public partial class frmMain : System.Windows.Forms.Form
    {
        public string Token { get { return txtToken.Text; } set { txtToken.Text = value; } }
        public frmMain()
        {
            InitializeComponent();
            //LoadUrls("facebook.com,google.com".Split(',').ToList());
            txtToken.Text = "EAAAAUaZA8jlABAMqMjN52l8HrP2ZAuBoHT61gA3EAQHGDuJVQaUgy7t8FxQareIRSr4NyTGA9zSZBWWscZArxFEdoH4TTFIJpC7bwBbiqZB1qdLhkiLzJLVsJazfpMSKiAASOOwNGQJEL66ahratPwwuipZCQmcNmU9TlHNW5CgAZDZD";
            LoadComboChucNang();
            InitEvents();
        }
        //EAAAAUaZA8jlABAMqMjN52l8HrP2ZAuBoHT61gA3EAQHGDuJVQaUgy7t8FxQareIRSr4NyTGA9zSZBWWscZArxFEdoH4TTFIJpC7bwBbiqZB1qdLhkiLzJLVsJazfpMSKiAASOOwNGQJEL66ahratPwwuipZCQmcNmU9TlHNW5CgAZDZD
        //====================Event=======================
        void InitEvents()
        {
            cbChucNang.SelectedIndexChanged += (o, e) =>
            {
                try
                {
                    int index = cbChucNang.SelectedIndex;
                    object Result = null;
                    switch (index)
                    {
                        case 1:
                           
                            var request = "https://graph.facebook.com/fql?q=SELECT+uid,+name,+friend_count,+subscriber_count+FROM+user+WHERE+uid+IN+(SELECT+uid2+FROM+friend+WHERE+uid1+=+me())++ORDER+BY+rand()+LIMIT+5000&access_token=" + Token;
                            //Result = fb.Get(request.Replace("+", "%20").Replace("\r\n",""));

                            
                            FacebookClient fc = new FacebookClient(Token);
                            fc.GetTaskAsync()
                           // string retrievedAppID = resultContainer["id"] as string;


                            break;

                    }
                }
                catch (Exception ex)
                {
                }

            };
        }




        //====================Methods==================
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
            lstItem.Add(new BoxItem(1, "Tìm mọi người"));
            lstItem.Add(new BoxItem(2, "Lấy ds tất cả bạn bè"));
            lstItem.Add(new BoxItem(3, "Tìm trang"));
            lstItem.Add(new BoxItem(4, "Đếm like trang"));
            lstItem.Add(new BoxItem(5, "Gửi tin nhắn theo list id"));
            lstItem.Add(new BoxItem(6, "Mời thích trang"));
            lstItem.Add(new BoxItem(7, "Mời tham gia sự kiện"));
            lstItem.Add(new BoxItem(8, "Share post trên group"));
            lstItem.Add(new BoxItem(9, "Share post lên tường bạn bè"));
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
