namespace Florencia_Palazzo_Casting
{
    partial class Casting
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
            this.txtImplicito = new System.Windows.Forms.TextBox();
            this.txtExplicito = new System.Windows.Forms.TextBox();
            this.txtMetodo = new System.Windows.Forms.TextBox();
            this.btnImplicito = new System.Windows.Forms.Button();
            this.btnExplicito = new System.Windows.Forms.Button();
            this.btnMetodo = new System.Windows.Forms.Button();
            this.lblImplicito = new System.Windows.Forms.Label();
            this.lblExplicito = new System.Windows.Forms.Label();
            this.lblMetodo = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtImplicito
            // 
            this.txtImplicito.Location = new System.Drawing.Point(80, 87);
            this.txtImplicito.Name = "txtImplicito";
            this.txtImplicito.Size = new System.Drawing.Size(100, 20);
            this.txtImplicito.TabIndex = 0;
            // 
            // txtExplicito
            // 
            this.txtExplicito.Location = new System.Drawing.Point(261, 87);
            this.txtExplicito.Name = "txtExplicito";
            this.txtExplicito.Size = new System.Drawing.Size(100, 20);
            this.txtExplicito.TabIndex = 1;
            // 
            // txtMetodo
            // 
            this.txtMetodo.Location = new System.Drawing.Point(435, 87);
            this.txtMetodo.Name = "txtMetodo";
            this.txtMetodo.Size = new System.Drawing.Size(100, 20);
            this.txtMetodo.TabIndex = 2;
            // 
            // btnImplicito
            // 
            this.btnImplicito.Location = new System.Drawing.Point(91, 113);
            this.btnImplicito.Name = "btnImplicito";
            this.btnImplicito.Size = new System.Drawing.Size(75, 23);
            this.btnImplicito.TabIndex = 3;
            this.btnImplicito.Text = "Castear";
            this.btnImplicito.UseVisualStyleBackColor = true;
            this.btnImplicito.Click += new System.EventHandler(this.btnImplicito_Click);
            // 
            // btnExplicito
            // 
            this.btnExplicito.Location = new System.Drawing.Point(275, 114);
            this.btnExplicito.Name = "btnExplicito";
            this.btnExplicito.Size = new System.Drawing.Size(75, 23);
            this.btnExplicito.TabIndex = 4;
            this.btnExplicito.Text = "Castear";
            this.btnExplicito.UseVisualStyleBackColor = true;
            this.btnExplicito.Click += new System.EventHandler(this.btnExplicito_Click);
            // 
            // btnMetodo
            // 
            this.btnMetodo.Location = new System.Drawing.Point(449, 113);
            this.btnMetodo.Name = "btnMetodo";
            this.btnMetodo.Size = new System.Drawing.Size(75, 23);
            this.btnMetodo.TabIndex = 5;
            this.btnMetodo.Text = "Castear";
            this.btnMetodo.UseVisualStyleBackColor = true;
            this.btnMetodo.Click += new System.EventHandler(this.btnMetodo_Click);
            // 
            // lblImplicito
            // 
            this.lblImplicito.AutoSize = true;
            this.lblImplicito.Location = new System.Drawing.Point(88, 71);
            this.lblImplicito.Name = "lblImplicito";
            this.lblImplicito.Size = new System.Drawing.Size(81, 13);
            this.lblImplicito.TabIndex = 6;
            this.lblImplicito.Text = "Casteo Implicito";
            // 
            // lblExplicito
            // 
            this.lblExplicito.AutoSize = true;
            this.lblExplicito.Location = new System.Drawing.Point(272, 71);
            this.lblExplicito.Name = "lblExplicito";
            this.lblExplicito.Size = new System.Drawing.Size(82, 13);
            this.lblExplicito.TabIndex = 7;
            this.lblExplicito.Text = "Casteo Explicito";
            // 
            // lblMetodo
            // 
            this.lblMetodo.AutoSize = true;
            this.lblMetodo.Location = new System.Drawing.Point(464, 71);
            this.lblMetodo.Name = "lblMetodo";
            this.lblMetodo.Size = new System.Drawing.Size(43, 13);
            this.lblMetodo.TabIndex = 8;
            this.lblMetodo.Text = "Metodo";
            // 
            // Casting
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(611, 285);
            this.Controls.Add(this.lblMetodo);
            this.Controls.Add(this.lblExplicito);
            this.Controls.Add(this.lblImplicito);
            this.Controls.Add(this.btnMetodo);
            this.Controls.Add(this.btnExplicito);
            this.Controls.Add(this.btnImplicito);
            this.Controls.Add(this.txtMetodo);
            this.Controls.Add(this.txtExplicito);
            this.Controls.Add(this.txtImplicito);
            this.Name = "Casting";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtImplicito;
        private System.Windows.Forms.TextBox txtExplicito;
        private System.Windows.Forms.TextBox txtMetodo;
        private System.Windows.Forms.Button btnImplicito;
        private System.Windows.Forms.Button btnExplicito;
        private System.Windows.Forms.Button btnMetodo;
        private System.Windows.Forms.Label lblImplicito;
        private System.Windows.Forms.Label lblExplicito;
        private System.Windows.Forms.Label lblMetodo;
    }
}

