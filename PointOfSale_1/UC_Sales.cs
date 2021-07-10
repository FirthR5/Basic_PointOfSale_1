using Prj_Business;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PointOfSale_1
{
    public partial class UC_Sales : UserControl
    {
       
        public UC_Sales()
        {
            InitializeComponent();
        }
        #region Btns
        private void btnEnter_Click(object sender, EventArgs e)
        {
            Find();
        }

        private void btnDone_Click(object sender, EventArgs e)
        {
        }

        private void btnNumber(object sender, EventArgs e)
        {

        }
        #endregion
        #region listview_
        private void lsv_data()
        {
            try
            {
                RN_Sales obj = new RN_Sales();
                DataTable data = new DataTable();
                data = obj.RN_Sales_Stock();
                LoadProducts(data);

            }
            catch (Exception ex)
            {

                throw;
            }
        }

        private void ListViewSett()
        {
            var lis = lsv_Prod;

            lsv_Prod.Items.Clear();
            lis.Columns.Clear();

            lis.View = View.Details;
            lis.GridLines = false;
            lis.FullRowSelect = true;
            lis.Scrollable = true;
            lis.HideSelection = false;

            lis.Columns.Add("ID", 50);
            lis.Columns.Add("Name", 100);
            lis.Columns.Add("Price", 100);
            lis.Columns.Add("Brand", 100);
            lis.Columns.Add("Category", 100);
        }

        private void LoadProducts(DataTable data_)
        {
            lsv_Prod.Items.Clear();

            for (int i = 0; i < data_.Rows.Count; i++)
            {
                DataRow dr = data_.Rows[i];
                ListViewItem list = new ListViewItem(dr["Product_Id"].ToString());
                list.SubItems.Add(dr["Product_Name"].ToString());
                list.SubItems.Add(dr["Price"].ToString());
                list.SubItems.Add(dr["Brand_Name"].ToString());
                list.SubItems.Add(dr["Cat_Name"].ToString());
                lsv_Prod.Items.Add(list);
            }
            CustomTable();
        }

        private void CustomTable()
        {
            foreach (ListViewItem item in lsv_Prod.Items)
            {
                item.BackColor = (item.Index % 2 == 0) ? Color.White : Color.WhiteSmoke;
                item.Font = new System.Drawing.Font("Oxygen", 11);
            }
        }
        #endregion
        private void Find()
        {
            RN_Sales obj = new RN_Sales();
            try
            {

                if (txtBarra.Text.Length > 0)
                {
                    int value = Convert.ToInt32(txtBarra.Text);
                    LoadProducts(obj.RN_SearchProductByID(value));
                }
                else
                    lsv_data();

            }
            catch (Exception ex)
            {
                string msm = ex.Message;
            }


        }
        private void UC_Sales_Load(object sender, EventArgs e)
        {
            ListViewSett();
            lsv_data();
        }
    }
}
