namespace GestioneMagazzino
{
    partial class Form1
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.cbx_select_store = new System.Windows.Forms.ComboBox();
            this.button5 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lbl_store_info = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(64, 231);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(1036, 319);
            this.dataGridView1.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(799, 590);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(302, 51);
            this.button1.TabIndex = 4;
            this.button1.Text = "Add New Store";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Add_new_store_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(65, 590);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(312, 51);
            this.button2.TabIndex = 23;
            this.button2.Text = "Add Product on Stock";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.Add_product_on_store_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(423, 46);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(329, 51);
            this.button3.TabIndex = 34;
            this.button3.Text = "Store Info";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.btn_show_store_info_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(799, 46);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(302, 50);
            this.button4.TabIndex = 35;
            this.button4.Text = "Product List by Store";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.btn_list_products_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(61, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 20);
            this.label2.TabIndex = 37;
            this.label2.Text = "Select Store";
            // 
            // cbx_select_store
            // 
            this.cbx_select_store.FormattingEnabled = true;
            this.cbx_select_store.Location = new System.Drawing.Point(65, 58);
            this.cbx_select_store.Name = "cbx_select_store";
            this.cbx_select_store.Size = new System.Drawing.Size(299, 28);
            this.cbx_select_store.TabIndex = 36;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(423, 590);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(329, 51);
            this.button5.TabIndex = 38;
            this.button5.Text = "Update Store";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.Update_Stores_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lbl_store_info);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(65, 125);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1035, 74);
            this.groupBox1.TabIndex = 39;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Selected Store Infos";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 20);
            this.label1.TabIndex = 0;
            // 
            // lbl_store_info
            // 
            this.lbl_store_info.AutoSize = true;
            this.lbl_store_info.Location = new System.Drawing.Point(27, 32);
            this.lbl_store_info.Name = "lbl_store_info";
            this.lbl_store_info.Size = new System.Drawing.Size(13, 20);
            this.lbl_store_info.TabIndex = 1;
            this.lbl_store_info.Text = " ";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1190, 731);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbx_select_store);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.Text = "Store Manager";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbx_select_store;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl_store_info;
    }
}

