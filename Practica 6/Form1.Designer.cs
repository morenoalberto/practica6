namespace Practica_6
{
    partial class sub
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben eliminar; false en caso contrario, false.</param>
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
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.p1 = new System.Windows.Forms.Label();
            this.p2 = new System.Windows.Forms.Label();
            this.p3 = new System.Windows.Forms.Label();
            this.fac = new System.Windows.Forms.Button();
            this.lim = new System.Windows.Forms.Button();
            this.producto = new System.Windows.Forms.TextBox();
            this.producto2 = new System.Windows.Forms.TextBox();
            this.producto3 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.Iva = new System.Windows.Forms.Label();
            this.total = new System.Windows.Forms.Label();
            this.s = new System.Windows.Forms.TextBox();
            this.i = new System.Windows.Forms.TextBox();
            this.t = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // p1
            // 
            this.p1.AutoSize = true;
            this.p1.Location = new System.Drawing.Point(51, 27);
            this.p1.Name = "p1";
            this.p1.Size = new System.Drawing.Size(59, 13);
            this.p1.TabIndex = 0;
            this.p1.Text = "Producto 1";
            this.p1.Click += new System.EventHandler(this.producto_Click);
            // 
            // p2
            // 
            this.p2.AutoSize = true;
            this.p2.Location = new System.Drawing.Point(51, 67);
            this.p2.Name = "p2";
            this.p2.Size = new System.Drawing.Size(59, 13);
            this.p2.TabIndex = 1;
            this.p2.Text = "Producto 2";
            // 
            // p3
            // 
            this.p3.AutoSize = true;
            this.p3.Location = new System.Drawing.Point(51, 107);
            this.p3.Name = "p3";
            this.p3.Size = new System.Drawing.Size(59, 13);
            this.p3.TabIndex = 2;
            this.p3.Text = "Producto 3";
            // 
            // fac
            // 
            this.fac.Location = new System.Drawing.Point(54, 293);
            this.fac.Name = "fac";
            this.fac.Size = new System.Drawing.Size(69, 25);
            this.fac.TabIndex = 5;
            this.fac.Text = "Facturar";
            this.fac.UseVisualStyleBackColor = true;
            this.fac.Click += new System.EventHandler(this.fac_Click);
            // 
            // lim
            // 
            this.lim.Location = new System.Drawing.Point(191, 295);
            this.lim.Name = "lim";
            this.lim.Size = new System.Drawing.Size(82, 23);
            this.lim.TabIndex = 6;
            this.lim.Text = "Limpiar";
            this.lim.UseVisualStyleBackColor = true;
            this.lim.Click += new System.EventHandler(this.lim_Click);
            // 
            // producto
            // 
            this.producto.Location = new System.Drawing.Point(116, 24);
            this.producto.Name = "producto";
            this.producto.Size = new System.Drawing.Size(206, 20);
            this.producto.TabIndex = 7;
            // 
            // producto2
            // 
            this.producto2.Location = new System.Drawing.Point(118, 64);
            this.producto2.Name = "producto2";
            this.producto2.Size = new System.Drawing.Size(206, 20);
            this.producto2.TabIndex = 8;
            // 
            // producto3
            // 
            this.producto3.Location = new System.Drawing.Point(115, 109);
            this.producto3.Name = "producto3";
            this.producto3.Size = new System.Drawing.Size(206, 20);
            this.producto3.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(67, 167);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Subtotal";
            // 
            // Iva
            // 
            this.Iva.AutoSize = true;
            this.Iva.Location = new System.Drawing.Point(85, 200);
            this.Iva.Name = "Iva";
            this.Iva.Size = new System.Drawing.Size(24, 13);
            this.Iva.TabIndex = 11;
            this.Iva.Text = "IVA";
            // 
            // total
            // 
            this.total.AutoSize = true;
            this.total.Location = new System.Drawing.Point(82, 230);
            this.total.Name = "total";
            this.total.Size = new System.Drawing.Size(31, 13);
            this.total.TabIndex = 12;
            this.total.Text = "Total";
            // 
            // s
            // 
            this.s.Location = new System.Drawing.Point(126, 164);
            this.s.Name = "s";
            this.s.Size = new System.Drawing.Size(156, 20);
            this.s.TabIndex = 13;
            this.s.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // i
            // 
            this.i.Location = new System.Drawing.Point(126, 197);
            this.i.Name = "i";
            this.i.Size = new System.Drawing.Size(156, 20);
            this.i.TabIndex = 14;
            // 
            // t
            // 
            this.t.Location = new System.Drawing.Point(125, 228);
            this.t.Name = "t";
            this.t.Size = new System.Drawing.Size(156, 20);
            this.t.TabIndex = 15;
            // 
            // sub
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(363, 361);
            this.Controls.Add(this.t);
            this.Controls.Add(this.i);
            this.Controls.Add(this.s);
            this.Controls.Add(this.total);
            this.Controls.Add(this.Iva);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.producto3);
            this.Controls.Add(this.producto2);
            this.Controls.Add(this.producto);
            this.Controls.Add(this.lim);
            this.Controls.Add(this.fac);
            this.Controls.Add(this.p3);
            this.Controls.Add(this.p2);
            this.Controls.Add(this.p1);
            this.Name = "sub";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label p1;
        private System.Windows.Forms.Label p2;
        private System.Windows.Forms.Label p3;
        private System.Windows.Forms.Button fac;
        private System.Windows.Forms.Button lim;
        private System.Windows.Forms.TextBox producto;
        private System.Windows.Forms.TextBox producto2;
        private System.Windows.Forms.TextBox producto3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label Iva;
        private System.Windows.Forms.Label total;
        private System.Windows.Forms.TextBox s;
        private System.Windows.Forms.TextBox i;
        private System.Windows.Forms.TextBox t;
    }
}

