namespace SafeInventory.Forms
{
    partial class GridProducts
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
            this.dv_product = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_idProduct = new System.Windows.Forms.TextBox();
            this.txt_name = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_idCategory = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_price = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_stock = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btn_create = new System.Windows.Forms.Button();
            this.btn_update = new System.Windows.Forms.Button();
            this.btn_delete = new System.Windows.Forms.Button();
            this.cb_filter = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.lbl_category = new System.Windows.Forms.Label();
            this.cb_category = new System.Windows.Forms.ComboBox();
            this.btn_filter = new System.Windows.Forms.Button();
            this.lbl_from = new System.Windows.Forms.Label();
            this.txt_from = new System.Windows.Forms.TextBox();
            this.txt_to = new System.Windows.Forms.TextBox();
            this.lbl_to = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dv_product)).BeginInit();
            this.SuspendLayout();
            // 
            // dv_product
            // 
            this.dv_product.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dv_product.Location = new System.Drawing.Point(12, 28);
            this.dv_product.Name = "dv_product";
            this.dv_product.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dv_product.Size = new System.Drawing.Size(573, 390);
            this.dv_product.TabIndex = 0;
            this.dv_product.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dv_product_CellClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(604, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "IDProducto";
            // 
            // txt_idProduct
            // 
            this.txt_idProduct.Location = new System.Drawing.Point(607, 46);
            this.txt_idProduct.Name = "txt_idProduct";
            this.txt_idProduct.Size = new System.Drawing.Size(100, 20);
            this.txt_idProduct.TabIndex = 2;
            // 
            // txt_name
            // 
            this.txt_name.Location = new System.Drawing.Point(746, 46);
            this.txt_name.Name = "txt_name";
            this.txt_name.Size = new System.Drawing.Size(100, 20);
            this.txt_name.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(743, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Nombre";
            // 
            // txt_idCategory
            // 
            this.txt_idCategory.Location = new System.Drawing.Point(607, 107);
            this.txt_idCategory.Name = "txt_idCategory";
            this.txt_idCategory.Size = new System.Drawing.Size(100, 20);
            this.txt_idCategory.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(604, 90);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Categoria";
            // 
            // txt_price
            // 
            this.txt_price.Location = new System.Drawing.Point(746, 107);
            this.txt_price.Name = "txt_price";
            this.txt_price.Size = new System.Drawing.Size(100, 20);
            this.txt_price.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(743, 90);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Precio";
            // 
            // txt_stock
            // 
            this.txt_stock.Location = new System.Drawing.Point(607, 165);
            this.txt_stock.Name = "txt_stock";
            this.txt_stock.Size = new System.Drawing.Size(100, 20);
            this.txt_stock.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(604, 148);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Stock";
            // 
            // btn_create
            // 
            this.btn_create.Location = new System.Drawing.Point(607, 243);
            this.btn_create.Name = "btn_create";
            this.btn_create.Size = new System.Drawing.Size(239, 39);
            this.btn_create.TabIndex = 11;
            this.btn_create.Text = "Crear Producto";
            this.btn_create.UseVisualStyleBackColor = true;
            this.btn_create.Click += new System.EventHandler(this.btn_create_Click);
            // 
            // btn_update
            // 
            this.btn_update.Location = new System.Drawing.Point(607, 307);
            this.btn_update.Name = "btn_update";
            this.btn_update.Size = new System.Drawing.Size(239, 39);
            this.btn_update.TabIndex = 12;
            this.btn_update.Text = "Editar Producto";
            this.btn_update.UseVisualStyleBackColor = true;
            this.btn_update.Click += new System.EventHandler(this.btn_update_Click);
            // 
            // btn_delete
            // 
            this.btn_delete.Location = new System.Drawing.Point(607, 368);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(239, 39);
            this.btn_delete.TabIndex = 13;
            this.btn_delete.Text = "Borrar Producto";
            this.btn_delete.UseVisualStyleBackColor = true;
            this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click);
            // 
            // cb_filter
            // 
            this.cb_filter.FormattingEnabled = true;
            this.cb_filter.Items.AddRange(new object[] {
            "Nombre",
            "Categoria",
            "Precio",
            "Stock"});
            this.cb_filter.Location = new System.Drawing.Point(12, 450);
            this.cb_filter.Name = "cb_filter";
            this.cb_filter.Size = new System.Drawing.Size(121, 21);
            this.cb_filter.TabIndex = 14;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 434);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 13);
            this.label6.TabIndex = 15;
            this.label6.Text = "Filtrar por:";
            // 
            // lbl_category
            // 
            this.lbl_category.AutoSize = true;
            this.lbl_category.Location = new System.Drawing.Point(150, 434);
            this.lbl_category.Name = "lbl_category";
            this.lbl_category.Size = new System.Drawing.Size(57, 13);
            this.lbl_category.TabIndex = 16;
            this.lbl_category.Text = "Categorias";
            // 
            // cb_category
            // 
            this.cb_category.FormattingEnabled = true;
            this.cb_category.Location = new System.Drawing.Point(153, 449);
            this.cb_category.Name = "cb_category";
            this.cb_category.Size = new System.Drawing.Size(121, 21);
            this.cb_category.TabIndex = 17;
            // 
            // btn_filter
            // 
            this.btn_filter.Location = new System.Drawing.Point(478, 434);
            this.btn_filter.Name = "btn_filter";
            this.btn_filter.Size = new System.Drawing.Size(107, 36);
            this.btn_filter.TabIndex = 18;
            this.btn_filter.Text = "Filtrar";
            this.btn_filter.UseVisualStyleBackColor = true;
            // 
            // lbl_from
            // 
            this.lbl_from.AutoSize = true;
            this.lbl_from.Location = new System.Drawing.Point(150, 433);
            this.lbl_from.Name = "lbl_from";
            this.lbl_from.Size = new System.Drawing.Size(41, 13);
            this.lbl_from.TabIndex = 19;
            this.lbl_from.Text = "Desde:";
            // 
            // txt_from
            // 
            this.txt_from.Location = new System.Drawing.Point(153, 449);
            this.txt_from.Name = "txt_from";
            this.txt_from.Size = new System.Drawing.Size(121, 20);
            this.txt_from.TabIndex = 20;
            // 
            // txt_to
            // 
            this.txt_to.Location = new System.Drawing.Point(298, 449);
            this.txt_to.Name = "txt_to";
            this.txt_to.Size = new System.Drawing.Size(121, 20);
            this.txt_to.TabIndex = 22;
            // 
            // lbl_to
            // 
            this.lbl_to.AutoSize = true;
            this.lbl_to.Location = new System.Drawing.Point(295, 433);
            this.lbl_to.Name = "lbl_to";
            this.lbl_to.Size = new System.Drawing.Size(38, 13);
            this.lbl_to.TabIndex = 21;
            this.lbl_to.Text = "Hasta:";
            // 
            // GridProducts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(858, 499);
            this.Controls.Add(this.txt_to);
            this.Controls.Add(this.lbl_to);
            this.Controls.Add(this.txt_from);
            this.Controls.Add(this.lbl_from);
            this.Controls.Add(this.btn_filter);
            this.Controls.Add(this.cb_category);
            this.Controls.Add(this.lbl_category);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cb_filter);
            this.Controls.Add(this.btn_delete);
            this.Controls.Add(this.btn_update);
            this.Controls.Add(this.btn_create);
            this.Controls.Add(this.txt_stock);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txt_price);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txt_idCategory);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_name);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_idProduct);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dv_product);
            this.Name = "GridProducts";
            this.Text = "GridProducts";
            this.Load += new System.EventHandler(this.GridProducts_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dv_product)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dv_product;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_idProduct;
        private System.Windows.Forms.TextBox txt_name;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_idCategory;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_price;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_stock;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btn_create;
        private System.Windows.Forms.Button btn_update;
        private System.Windows.Forms.Button btn_delete;
        private System.Windows.Forms.ComboBox cb_filter;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lbl_category;
        private System.Windows.Forms.ComboBox cb_category;
        private System.Windows.Forms.Button btn_filter;
        private System.Windows.Forms.Label lbl_from;
        private System.Windows.Forms.TextBox txt_from;
        private System.Windows.Forms.TextBox txt_to;
        private System.Windows.Forms.Label lbl_to;
    }
}