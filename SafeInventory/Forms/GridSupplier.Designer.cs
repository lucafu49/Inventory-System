namespace SafeInventory.Forms
{
    partial class GridSupplier
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
            this.gv_suplier = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_idSupplier = new System.Windows.Forms.TextBox();
            this.txt_name = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_phone = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_create = new System.Windows.Forms.Button();
            this.btn_update = new System.Windows.Forms.Button();
            this.btn_delete = new System.Windows.Forms.Button();
            this.cb_search = new System.Windows.Forms.ComboBox();
            this.txt_search = new System.Windows.Forms.TextBox();
            this.btn_search = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.gv_suplier)).BeginInit();
            this.SuspendLayout();
            // 
            // gv_suplier
            // 
            this.gv_suplier.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gv_suplier.Location = new System.Drawing.Point(13, 13);
            this.gv_suplier.Name = "gv_suplier";
            this.gv_suplier.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gv_suplier.Size = new System.Drawing.Size(330, 425);
            this.gv_suplier.TabIndex = 0;
            this.gv_suplier.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gv_suplier_CellClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(389, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "IDProveedor";
            // 
            // txt_idSupplier
            // 
            this.txt_idSupplier.Location = new System.Drawing.Point(392, 30);
            this.txt_idSupplier.Name = "txt_idSupplier";
            this.txt_idSupplier.Size = new System.Drawing.Size(100, 20);
            this.txt_idSupplier.TabIndex = 2;
            // 
            // txt_name
            // 
            this.txt_name.Location = new System.Drawing.Point(553, 30);
            this.txt_name.Name = "txt_name";
            this.txt_name.Size = new System.Drawing.Size(100, 20);
            this.txt_name.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(550, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Nombre";
            // 
            // txt_phone
            // 
            this.txt_phone.Location = new System.Drawing.Point(392, 93);
            this.txt_phone.Name = "txt_phone";
            this.txt_phone.Size = new System.Drawing.Size(100, 20);
            this.txt_phone.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(389, 76);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Telefono";
            // 
            // btn_create
            // 
            this.btn_create.Location = new System.Drawing.Point(392, 152);
            this.btn_create.Name = "btn_create";
            this.btn_create.Size = new System.Drawing.Size(261, 39);
            this.btn_create.TabIndex = 7;
            this.btn_create.Text = "Registrar Proveedor";
            this.btn_create.UseVisualStyleBackColor = true;
            this.btn_create.Click += new System.EventHandler(this.btn_create_Click);
            // 
            // btn_update
            // 
            this.btn_update.Location = new System.Drawing.Point(392, 214);
            this.btn_update.Name = "btn_update";
            this.btn_update.Size = new System.Drawing.Size(261, 39);
            this.btn_update.TabIndex = 8;
            this.btn_update.Text = "Editar proveedor";
            this.btn_update.UseVisualStyleBackColor = true;
            this.btn_update.Click += new System.EventHandler(this.btn_update_Click);
            // 
            // btn_delete
            // 
            this.btn_delete.Location = new System.Drawing.Point(392, 273);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(261, 39);
            this.btn_delete.TabIndex = 9;
            this.btn_delete.Text = "Eliminar proveedor";
            this.btn_delete.UseVisualStyleBackColor = true;
            this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click);
            // 
            // cb_search
            // 
            this.cb_search.FormattingEnabled = true;
            this.cb_search.Items.AddRange(new object[] {
            "Buscar por ID",
            "Buscar por Nombre",
            "Buscar por Telefono"});
            this.cb_search.Location = new System.Drawing.Point(12, 460);
            this.cb_search.Name = "cb_search";
            this.cb_search.Size = new System.Drawing.Size(121, 21);
            this.cb_search.TabIndex = 10;
            this.cb_search.Text = "Buscar por...";
            // 
            // txt_search
            // 
            this.txt_search.Location = new System.Drawing.Point(178, 460);
            this.txt_search.Name = "txt_search";
            this.txt_search.Size = new System.Drawing.Size(165, 20);
            this.txt_search.TabIndex = 11;
            // 
            // btn_search
            // 
            this.btn_search.Location = new System.Drawing.Point(392, 454);
            this.btn_search.Name = "btn_search";
            this.btn_search.Size = new System.Drawing.Size(88, 31);
            this.btn_search.TabIndex = 12;
            this.btn_search.Text = "Buscar";
            this.btn_search.UseVisualStyleBackColor = true;
            // 
            // GridSupplier
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(676, 493);
            this.Controls.Add(this.btn_search);
            this.Controls.Add(this.txt_search);
            this.Controls.Add(this.cb_search);
            this.Controls.Add(this.btn_delete);
            this.Controls.Add(this.btn_update);
            this.Controls.Add(this.btn_create);
            this.Controls.Add(this.txt_phone);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_name);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_idSupplier);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.gv_suplier);
            this.Name = "GridSupplier";
            this.Text = "GridSupplier";
            this.Load += new System.EventHandler(this.GridSupplier_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gv_suplier)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView gv_suplier;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_idSupplier;
        private System.Windows.Forms.TextBox txt_name;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_phone;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_create;
        private System.Windows.Forms.Button btn_update;
        private System.Windows.Forms.Button btn_delete;
        private System.Windows.Forms.ComboBox cb_search;
        private System.Windows.Forms.TextBox txt_search;
        private System.Windows.Forms.Button btn_search;
    }
}