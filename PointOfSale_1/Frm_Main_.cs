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
    public partial class Frm_Main_ : Form
    {
        public Frm_Main_()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Frm_Brand_R B = new Frm_Brand_R();
            B.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Frm_ProductCategory C = new Frm_ProductCategory();
            C.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Frm_Sales S = new Frm_Sales();
            
            S.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Frm_Products P = new Frm_Products();
            P.Show();
        }
    }
}
