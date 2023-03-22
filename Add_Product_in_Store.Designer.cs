namespace GestioneMagazzino
{
    partial class Add_Product_in_Store
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
            this.button2 = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.num_quantity = new System.Windows.Forms.NumericUpDown();
            this.label10 = new System.Windows.Forms.Label();
            this.cbx_select_product = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cbx_select_store = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.num_quantity)).BeginInit();
            this.SuspendLayout();
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(884, 88);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(165, 51);
            this.button2.TabIndex = 30;
            this.button2.Text = "Save Stock";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.Save_Stock_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(729, 68);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(68, 20);
            this.label11.TabIndex = 29;
            this.label11.Text = "Quantity";
            // 
            // num_quantity
            // 
            this.num_quantity.Location = new System.Drawing.Point(733, 101);
            this.num_quantity.Name = "num_quantity";
            this.num_quantity.Size = new System.Drawing.Size(97, 26);
            this.num_quantity.TabIndex = 28;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(401, 68);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(72, 20);
            this.label10.TabIndex = 27;
            this.label10.Text = "Products";
            // 
            // cbx_select_product
            // 
            this.cbx_select_product.FormattingEnabled = true;
            this.cbx_select_product.Location = new System.Drawing.Point(393, 101);
            this.cbx_select_product.Name = "cbx_select_product";
            this.cbx_select_product.Size = new System.Drawing.Size(307, 28);
            this.cbx_select_product.TabIndex = 26;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(72, 68);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 20);
            this.label1.TabIndex = 25;
            this.label1.Text = "Stores";
            // 
            // cbx_select_store
            // 
            this.cbx_select_store.FormattingEnabled = true;
            this.cbx_select_store.Location = new System.Drawing.Point(64, 101);
            this.cbx_select_store.Name = "cbx_select_store";
            this.cbx_select_store.Size = new System.Drawing.Size(307, 28);
            this.cbx_select_store.TabIndex = 24;
            // 
            // Add_Product_in_Store
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1154, 227);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.num_quantity);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.cbx_select_product);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbx_select_store);
            this.Name = "Add_Product_in_Store";
            this.Text = "Add Product in Store";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Add_Product_in_Store_FormClosing);
            this.Load += new System.EventHandler(this.Add_Product_in_Store_Load);
            ((System.ComponentModel.ISupportInitialize)(this.num_quantity)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.NumericUpDown num_quantity;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox cbx_select_product;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbx_select_store;
    }
}