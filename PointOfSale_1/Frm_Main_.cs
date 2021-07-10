using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PointOfSale_1
{
    public partial class Frm_Main_ : Form
    {
        public Frm_Main_()
        {
            InitializeComponent();
        }

       

        private void btnHome_Click(object sender, EventArgs e)
        {

        }

        private void btnBrand_Click(object sender, EventArgs e)
        {
            OpenChildUC(new UC_Brand());

        }

        private void btnCategory_Click(object sender, EventArgs e)
        {
            OpenChildUC(new UC_Products());
        }


        private void btnProducts_Click(object sender, EventArgs e)
        {
            OpenChildUC(new UC_ProductCategory());

        }

        private void btnSales_Click(object sender, EventArgs e)
        {
            OpenChildUC(new UC_Sales());
        }



        private void btnReport_Click(object sender, EventArgs e)
        {
             OpenChildUC(new UC_Report());
        }
        //public void OpenChildForm(Form childForm)
        //{
        //    if(currentChildForm != null)
        //    {
        //        currentChildForm.Close();

        //    }
        //    currentChildForm = childForm;
        //    childForm.TopLevel = false;
        //    childForm.FormBorderStyle = FormBorderStyle.None;
        //    childForm.Dock = DockStyle.Fill;

        //    pnlMain.Controls.Add(childForm);
        //    pnlMain.Tag = childForm;

        //    childForm.BringToFront();
        //    childForm.Show();
        //}
        private void OpenChildUC(UserControl childUC)
        {
            if (currentChildren_UserControl != null)
            {
                currentChildren_UserControl.Hide();
                
            }
            
            currentChildren_UserControl = childUC;

            childUC.Hide();

            childUC.BorderStyle = BorderStyle.None;

            childUC.Dock = DockStyle.Fill;

            //Add Child to a pnlMain
            pnlMain.Controls.Add(childUC);
            pnlMain.Tag = childUC;
            
            childUC.BringToFront();
            childUC.Show();

        }
        private UserControl currentChildren_UserControl;

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);
        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);

        }
        //private Form currentChildForm;
    }
}
