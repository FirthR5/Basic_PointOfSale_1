using Prj_Business;
using Prj_Ent;
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
    public partial class UC_Products : UserControl
    {
        public UC_Products()
        {
            InitializeComponent();
        }

        private void btnSign_Click(object sender, EventArgs e)
        {
            EN_Prod prod = new EN_Prod();
            RN_Products obj = new RN_Products();

            prod.Category_Id = Convert.ToInt32(cboCategory.SelectedValue);
            prod.Brand_Id = Convert.ToInt32(cboBrand.SelectedValue);
            prod.Product_Name = txtName.Text;
            prod.Quantity = Convert.ToInt32(txtQuantity.Text);
            prod.Price = Convert.ToDouble(txtPrice.Text);

            obj.RegisterProducts(prod);

            LsvDat();
        }

        private void btnDel_Click(object sender, EventArgs e)
        {

        }



        #region Product_Table
        private void LsvDat()
        {
            RN_Products obj = new RN_Products();
            DataTable data_ = new DataTable();
            try
            {
                data_ = obj.showProducts();
                LvLoad(data_);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void LvLoad(DataTable data_)
        {
            lsv_Prod.Items.Clear();
            for (int i = 0; i < data_.Rows.Count; i++)
            {
                DataRow dr = data_.Rows[i];
                ListViewItem list = new ListViewItem(dr["Product_Id"].ToString());
                list.SubItems.Add(dr["Product_Name"].ToString());
                list.SubItems.Add(dr["Cat_Name"].ToString());
                list.SubItems.Add(dr["Brand_Name"].ToString());
                list.SubItems.Add(dr["Quantity"].ToString());
                list.SubItems.Add(dr["Price"].ToString());
                lsv_Prod.Items.Add(list);
            }
        }
        private void ListViewSett()
        {
            var lis = lsv_Prod;

            lsv_Prod.Items.Clear();
            lis.Columns.Clear();
            lis.View = View.Details;
            lis.GridLines = true;
            lis.FullRowSelect = true;
            lis.Scrollable = true;
            lis.HideSelection = false;

            lis.Columns.Add("Product_Id", 50);
            lis.Columns.Add("Product_Name", 100);
            lis.Columns.Add("Cat_Name", 100);
            lis.Columns.Add("Brand_Name", 100);
            lis.Columns.Add("Quantity", 50);
            lis.Columns.Add("Price", 100);

        }
        #endregion
        #region CBOs
        private void LoadCategories()
        {
            try
            {
                RN_Category obj = new RN_Category();
                DataTable da = new DataTable();
                da = obj.RN_ShowCategories();
                if (da.Rows.Count > 0)
                {
                    cboCategory.DataSource = da;
                    cboCategory.DisplayMember = "Cat_Name";
                    cboCategory.ValueMember = "Id_Cat";
                    cboCategory.SelectedIndex = -1;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Something went wrong: " + ex.Message);
            }
        }

        private void LoadBrands()
        {
            try
            {
                RN_Brand obj = new RN_Brand();
                DataTable da = new DataTable();
                da = obj.ShowBrands();
                if (da.Rows.Count > 0)
                {
                    cboBrand.DataSource = da;
                    cboBrand.DisplayMember = "Brand_Name";
                    cboBrand.ValueMember = "Id_Br";
                    cboBrand.SelectedIndex = -1;
                }
            }
            catch (Exception ex) { MessageBox.Show("Something went wrong: " + ex.Message); }
        }
        #endregion

        private void UC_Products_Load(object sender, EventArgs e)
        {
            LoadBrands();
            LoadCategories();
            ListViewSett();
            LsvDat();
        }
    }
}
