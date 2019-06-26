using Facebook;
using FacebookWizzard.Us;
using FacebookWizzard.Viewer;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FacebookWizzard
{
    public partial class Form1 : Form
    {
        string appId = "1742557869348205";
        string secKey = "a84d09bbfdbbeefe68bf5b8dfb0d8a15";
        string Token = @"EAAAAUaZA8jlABAD8QNtxkc9DvkZA66PU8a3Ku4N9HNevZAOryeyIswE2pky6EZApj6kSSpaTAZC2fBnjZA4rXFLXeZCTBZAbjqYhXwtu5HqYCscOK60h4t7BzMCUwnfN0S9XfRi8WX4gTOWVk8yiAQD2ZAz6GgfAgaqtAFx8NsbgAXwZDZD";

        public Form1()
        {
            InitializeComponent();
            ReturnJSON();
            InitEvents();
        }

        //============Events===========

        void InitEvents()
        {
            bool post = true;
            btnChange.Click += (o, e) =>
            {
                if (post)
                {
                    OnInitControl("Post");
                }
                else
                    OnInitControl("Feed");
                post = !post;
            };
            //grView.CellDoubleClick += (o, e) =>
            //  {
            //      var row = grView.SelectedRows;
            //      MessageBox.Show(row.ToString(), "CellDoubleClick Event");
            //  };
            grView.CellContentDoubleClick += (o, e) =>
            {
                var link = @"https://www.facebook.com/1235717999927120/posts/452238238275104";

                usView frm = new usView(link,Token);
                frm.ShowDialog();
                //var row = grView.Rows[e.RowIndex] as DataRowView;
                //MessageBox.Show(row.ToString(), "CellDoubleClick Event");
            };
        }



        //===================Methods=============v
        void ReturnJSON()
        {
            try
            {
                //https://graph.facebook.com/'.$data_id.'/likes?access_token=".$token."&method=POST
                //https://graph.facebook.com/1235717999927120_452237634941831_452238408275087/likes?access_token=EAAAAUaZA8jlABAD8QNtxkc9DvkZA66PU8a3Ku4N9HNevZAOryeyIswE2pky6EZApj6kSSpaTAZC2fBnjZA4rXFLXeZCTBZAbjqYhXwtu5HqYCscOK60h4t7BzMCUwnfN0S9XfRi8WX4gTOWVk8yiAQD2ZAz6GgfAgaqtAFx8NsbgAXwZDZD&method=POST
                var src = File.ReadAllText(@"F:\JSON_GetPost.txt");
                var str = JsonConvert.DeserializeObject<JSON_Response>(src);
            }
            catch (Exception ex)
            {

            }

        }
        List<Post> InitPost()
        {
            var lst = new List<Post>();
            lst.Add(new Post("1", "Message 1", "Content message 1"));
            lst.Add(new Post("2", "Message 2", "Content message 2"));
            lst.Add(new Post("3", "Message 3", "Content message 3"));
            return lst;
        }
        List<Feed> InitFeed()
        {
            var lst = new List<Feed>();
            lst.Add(new Feed("17", "Message 1", "Action message 1", "34"));
            lst.Add(new Feed("22", "Message 2", "Action message 2", "64"));
            lst.Add(new Feed("34", "Message 3", "Action message 3", "254"));
            return lst;
        }

        void OnInitControl(string type)
        {
            try
            {
                grView.Columns.Clear();
                grView.DataSource = null;

                switch (type)
                {
                    case "Post":
                        var count = typeof(Post).GetProperties().Count();
                        grView.ColumnCount = count;
                        var propPost = typeof(Post).GetProperties();
                        if (propPost != null && propPost.Count() > 0)
                        {
                            int index = 0;
                            foreach (PropertyInfo item in propPost)
                            {
                                grView.Columns[index].ReadOnly = true;
                                grView.Columns[index].Name = item.Name;
                                index++;
                            }
                        }
                        var data = ToDataTable(InitPost());
                        if (data != null && data.Rows.Count > 0)
                        {
                            foreach (DataRow item in data.Rows)
                            {
                                grView.Rows.Add(item.ItemArray);
                            }

                        }

                        break;
                    case "Feed":
                        count = typeof(Feed).GetProperties().Count();
                        grView.ColumnCount = count;
                        var Feedprop = typeof(Feed).GetProperties();
                        if (Feedprop != null && Feedprop.Count() > 0)
                        {
                            int index = 0;
                            foreach (PropertyInfo item in Feedprop)
                            {
                                grView.Columns[index].ReadOnly = true;
                                grView.Columns[index].Name = item.Name;
                                index++;
                            }
                        }
                        data = ToDataTable(InitFeed());
                        if (data != null && data.Rows.Count > 0)
                        {
                            foreach (DataRow item in data.Rows)
                            {
                                grView.Rows.Add(item.ItemArray);
                            }

                        }

                        break;

                }

            }
            catch (Exception ex)
            {

            }

        }
        DataTable ToDataTable<T>(IList<T> data)
        {
            PropertyDescriptorCollection props =
                TypeDescriptor.GetProperties(typeof(T));
            DataTable table = new DataTable();
            for (int i = 0; i < props.Count; i++)
            {
                PropertyDescriptor prop = props[i];
                table.Columns.Add(prop.Name, prop.PropertyType);
            }
            object[] values = new object[props.Count];
            foreach (T item in data)
            {
                for (int i = 0; i < values.Length; i++)
                {
                    values[i] = props[i].GetValue(item);
                }
                table.Rows.Add(values);
            }
            return table;
        }

        void OnInit()
        {
            try
            {
                //var request = @"https://graph.facebook.com/me/home?fields=id&access_token=EAAAAUaZA8jlABANpy844YVE8mIeZCZCGCAxg5MQDaW6mvSZBay5V13kONsHrqxIbhOd6u3VVZBOErcEoQZCHkuWuko8je5KGf5GTGjqOGE2Ukpzqyqk2OjKJlmJ5Y9FcyLBFVuWuX6ZAs4XZBDOSjItCh6JVPeNbdxMw6IhHjZB25AQZDZD&limit=10";
                var fb = new FacebookClient();
                //dynamic re = fb.Get("oauth/access_token", new
                //{
                //    client_id = appId,
                //    client_secret = secKey,
                //    grant_type = "client_credentials"
                //});
                //  fb.AccessToken = result.access_token;

                // var fb = new FacebookClient();
                var fbAccessToken = @"EAAAAUaZA8jlABANpy844YVE8mIeZCZCGCAxg5MQDaW6mvSZBay5V13kONsHrqxIbhOd6u3VVZBOErcEoQZCHkuWuko8je5KGf5GTGjqOGE2Ukpzqyqk2OjKJlmJ5Y9FcyLBFVuWuX6ZAs4XZBDOSjItCh6JVPeNbdxMw6IhHjZB25AQZDZD";
                var requestSearch = @"https://graph.facebook.com/v3.2/search?type=place&center=40.7304,-73.9921&distance=1000&q=cafe&fields=name,checkins,picture&limit=3&access_token=" + fbAccessToken;

                dynamic result = fb.Get(requestSearch);

                var src = result.data;
            }
            catch (Exception ex)
            {
            }
        }
    }
    public class Post
    {
        public string ID { get; set; }
        public string Message { get; set; }
        public string Content { get; set; }
        public Post(string ID, string mess, string cont)
        {
            this.ID = ID;
            this.Message = mess;
            this.Content = cont;
        }

    }
    public class Feed
    {
        public string ID { get; set; }
        public string Message { get; set; }
        public string Action { get; set; }
        public string Likes { get; set; }
        public Feed(string id, string mess, string act, string like)
        {
            this.ID = id;
            this.Message = mess;
            this.Action = act;
            this.Likes = like;

        }
    }
}
