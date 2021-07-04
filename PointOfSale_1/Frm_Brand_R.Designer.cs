
namespace PointOfSale_1
{
    partial class Frm_Brand_R
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lsv_Brand = new System.Windows.Forms.ListView();
            this.btnSign = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.txtBrand = new System.Windows.Forms.TextBox();
            this.stock = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(150, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Brand Registry";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(75, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Name";
            // 
            // lsv_Brand
            // 
            this.lsv_Brand.HideSelection = false;
            this.lsv_Brand.Location = new System.Drawing.Point(27, 146);
            this.lsv_Brand.Name = "lsv_Brand";
            this.lsv_Brand.Size = new System.Drawing.Size(344, 247);
            this.lsv_Brand.TabIndex = 2;
            this.lsv_Brand.UseCompatibleStateImageBehavior = false;
            // 
            // btnSign
            // 
            this.btnSign.Location = new System.Drawing.Point(78, 94);
            this.btnSign.Name = "btnSign";
            this.btnSign.Size = new System.Drawing.Size(75, 23);
            this.btnSign.TabIndex = 3;
            this.btnSign.Text = "Sign";
            this.btnSign.UseVisualStyleBackColor = true;
            this.btnSign.Click += new System.EventHandler(this.btnSign_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(225, 94);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 3;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // txtBrand
            // 
            this.txtBrand.Location = new System.Drawing.Point(168, 61);
            this.txtBrand.Name = "txtBrand";
            this.txtBrand.Size = new System.Drawing.Size(100, 20);
            this.txtBrand.TabIndex = 20;
            // 
            // stock
            // 
            this.stock.AutoSize = true;
            this.stock.Location = new System.Drawing.Point(50, 396);
            this.stock.Name = "stock";
            this.stock.Size = new System.Drawing.Size(13, 13);
            this.stock.TabIndex = 22;
            this.stock.Text = "0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 396);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 13);
            this.label3.TabIndex = 21;
            this.label3.Text = "Stock: ";
            // 
            // Frm_Brand_R
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(394, 419);
            this.Controls.Add(this.stock);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtBrand);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnSign);
            this.Controls.Add(this.lsv_Brand);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Frm_Brand_R";
            this.Text = "Brand_R";
            this.Load += new System.EventHandler(this.Brand_R_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListView lsv_Brand;
        private System.Windows.Forms.Button btnSign;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.TextBox txtBrand;
        private System.Windows.Forms.Label stock;
        private System.Windows.Forms.Label label3;
    }
}