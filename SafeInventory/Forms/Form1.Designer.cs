namespace SafeInventory
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.btn_products = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_products
            // 
            this.btn_products.Location = new System.Drawing.Point(117, 151);
            this.btn_products.Name = "btn_products";
            this.btn_products.Size = new System.Drawing.Size(278, 43);
            this.btn_products.TabIndex = 0;
            this.btn_products.Text = "Productos";
            this.btn_products.UseVisualStyleBackColor = true;
            this.btn_products.Click += new System.EventHandler(this.btn_products_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(117, 221);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(278, 43);
            this.button2.TabIndex = 1;
            this.button2.Text = "Categorias";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(117, 290);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(278, 43);
            this.button3.TabIndex = 2;
            this.button3.Text = "Proveedores";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(526, 445);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btn_products);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_products;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
    }
}

