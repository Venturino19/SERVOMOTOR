namespace SERVOMOTOR
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
            this.btConectar = new System.Windows.Forms.Button();
            this.btDesconectar = new System.Windows.Forms.Button();
            this.tbLimTemp = new System.Windows.Forms.TextBox();
            this.lbTemp = new System.Windows.Forms.Label();
            this.lbConexion = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btConectar
            // 
            this.btConectar.Location = new System.Drawing.Point(155, 299);
            this.btConectar.Name = "btConectar";
            this.btConectar.Size = new System.Drawing.Size(138, 43);
            this.btConectar.TabIndex = 0;
            this.btConectar.Text = "CONECTAR";
            this.btConectar.UseVisualStyleBackColor = true;
            this.btConectar.Click += new System.EventHandler(this.btConectar_Click);
            // 
            // btDesconectar
            // 
            this.btDesconectar.Location = new System.Drawing.Point(480, 299);
            this.btDesconectar.Name = "btDesconectar";
            this.btDesconectar.Size = new System.Drawing.Size(138, 43);
            this.btDesconectar.TabIndex = 1;
            this.btDesconectar.Text = "DESCONECTAR";
            this.btDesconectar.UseVisualStyleBackColor = true;
            this.btDesconectar.Click += new System.EventHandler(this.btDesconectar_Click);
            // 
            // tbLimTemp
            // 
            this.tbLimTemp.Location = new System.Drawing.Point(320, 59);
            this.tbLimTemp.Name = "tbLimTemp";
            this.tbLimTemp.Size = new System.Drawing.Size(153, 20);
            this.tbLimTemp.TabIndex = 2;
            // 
            // lbTemp
            // 
            this.lbTemp.AutoSize = true;
            this.lbTemp.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTemp.Location = new System.Drawing.Point(329, 126);
            this.lbTemp.Name = "lbTemp";
            this.lbTemp.Size = new System.Drawing.Size(125, 73);
            this.lbTemp.TabIndex = 3;
            this.lbTemp.Text = "0.0";
            // 
            // lbConexion
            // 
            this.lbConexion.AutoSize = true;
            this.lbConexion.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbConexion.ForeColor = System.Drawing.Color.Red;
            this.lbConexion.Location = new System.Drawing.Point(339, 240);
            this.lbConexion.Name = "lbConexion";
            this.lbConexion.Size = new System.Drawing.Size(108, 13);
            this.lbConexion.TabIndex = 4;
            this.lbConexion.Text = "DESCONECTADO";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lbConexion);
            this.Controls.Add(this.lbTemp);
            this.Controls.Add(this.tbLimTemp);
            this.Controls.Add(this.btDesconectar);
            this.Controls.Add(this.btConectar);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btConectar;
        private System.Windows.Forms.Button btDesconectar;
        private System.Windows.Forms.TextBox tbLimTemp;
        private System.Windows.Forms.Label lbTemp;
        private System.Windows.Forms.Label lbConexion;
    }
}

