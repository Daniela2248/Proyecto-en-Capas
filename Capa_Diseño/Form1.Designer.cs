namespace Capa_Diseño
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
            this.Btnsuma = new System.Windows.Forms.Button();
            this.Btnresta = new System.Windows.Forms.Button();
            this.Btnmult = new System.Windows.Forms.Button();
            this.Btndiv = new System.Windows.Forms.Button();
            this.Txtd1 = new System.Windows.Forms.TextBox();
            this.Txtd2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.TxtTotal = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // Btnsuma
            // 
            this.Btnsuma.Location = new System.Drawing.Point(207, 39);
            this.Btnsuma.Name = "Btnsuma";
            this.Btnsuma.Size = new System.Drawing.Size(71, 23);
            this.Btnsuma.TabIndex = 0;
            this.Btnsuma.Text = "+";
            this.Btnsuma.UseVisualStyleBackColor = true;
            this.Btnsuma.Click += new System.EventHandler(this.Btnsuma_Click);
            // 
            // Btnresta
            // 
            this.Btnresta.Location = new System.Drawing.Point(207, 79);
            this.Btnresta.Name = "Btnresta";
            this.Btnresta.Size = new System.Drawing.Size(75, 23);
            this.Btnresta.TabIndex = 1;
            this.Btnresta.Text = "-";
            this.Btnresta.UseVisualStyleBackColor = true;
            this.Btnresta.Click += new System.EventHandler(this.Btnresta_Click);
            // 
            // Btnmult
            // 
            this.Btnmult.Location = new System.Drawing.Point(207, 117);
            this.Btnmult.Name = "Btnmult";
            this.Btnmult.Size = new System.Drawing.Size(75, 23);
            this.Btnmult.TabIndex = 2;
            this.Btnmult.Text = "X";
            this.Btnmult.UseVisualStyleBackColor = true;
            this.Btnmult.Click += new System.EventHandler(this.Btnmult_Click);
            // 
            // Btndiv
            // 
            this.Btndiv.Location = new System.Drawing.Point(207, 159);
            this.Btndiv.Name = "Btndiv";
            this.Btndiv.Size = new System.Drawing.Size(75, 23);
            this.Btndiv.TabIndex = 3;
            this.Btndiv.Text = "/";
            this.Btndiv.UseVisualStyleBackColor = true;
            this.Btndiv.Click += new System.EventHandler(this.Btndiv_Click);
            // 
            // Txtd1
            // 
            this.Txtd1.Location = new System.Drawing.Point(63, 42);
            this.Txtd1.Name = "Txtd1";
            this.Txtd1.Size = new System.Drawing.Size(100, 20);
            this.Txtd1.TabIndex = 4;
            // 
            // Txtd2
            // 
            this.Txtd2.Location = new System.Drawing.Point(63, 88);
            this.Txtd2.Name = "Txtd2";
            this.Txtd2.Size = new System.Drawing.Size(100, 20);
            this.Txtd2.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(88, 142);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Total";
            // 
            // TxtTotal
            // 
            this.TxtTotal.Location = new System.Drawing.Point(51, 173);
            this.TxtTotal.Name = "TxtTotal";
            this.TxtTotal.Size = new System.Drawing.Size(100, 20);
            this.TxtTotal.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(310, 216);
            this.Controls.Add(this.TxtTotal);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Txtd2);
            this.Controls.Add(this.Txtd1);
            this.Controls.Add(this.Btndiv);
            this.Controls.Add(this.Btnmult);
            this.Controls.Add(this.Btnresta);
            this.Controls.Add(this.Btnsuma);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Btnsuma;
        private System.Windows.Forms.Button Btnresta;
        private System.Windows.Forms.Button Btnmult;
        private System.Windows.Forms.Button Btndiv;
        private System.Windows.Forms.TextBox Txtd1;
        private System.Windows.Forms.TextBox Txtd2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TxtTotal;
    }
}

