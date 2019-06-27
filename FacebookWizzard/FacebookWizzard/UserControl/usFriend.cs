using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using FacebookWizzard.JSONResponse;
using DevExpress.Utils;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraGrid.Views.Grid.ViewInfo;

namespace FacebookWizzard.UserControl
{
    public partial class usFriend : DevExpress.XtraEditors.XtraForm
    {
       
        //public List<ListBoxItem> Source { get { return MainGrid.DataSource as List<ListBoxItem>; } set { MainGrid.DataSource = value; MainGrid.RefreshDataSource(); } }
        public usFriend(Response_Friends data)
        {
            InitializeComponent();
            LoadData(data);
            InitEvents();
        }
        void LoadData(Response_Friends data)
        {
            try
            {
                if (data != null)
                {
                    MainGrid.DataSource = data.data;
                    MainGrid.RefreshDataSource();
                }
            }catch(Exception ex)
            {

            }
        }
        void InitEvents()
        {
            gridView.DoubleClick += (o, e) =>
            {
                DXMouseEventArgs ea = e as DXMouseEventArgs;
                GridView view = o as GridView;
                GridHitInfo info = view.CalcHitInfo(ea.Location);
                if (info.InRow || info.InRowCell)
                {
                    try
                    {
                        var row = gridView.GetFocusedRow() as dataResponse_Frineds;
                        if (row != null)
                        {

                        }
                    }
                    catch (Exception ex)
                    {

                    }
                }
            };
        }
    }
}