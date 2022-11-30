
namespace appMetododeselecciónnuevo
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
            this.btnEjecutar = new System.Windows.Forms.Button();
            this.txttamaño = new System.Windows.Forms.TextBox();
            this.lbltamaño = new System.Windows.Forms.Label();
            this.btnborrar = new System.Windows.Forms.Button();
            this.btncerrar = new System.Windows.Forms.Button();
            this.lblcomparaciones = new System.Windows.Forms.Label();
            this.lblcontador2 = new System.Windows.Forms.Label();
            this.txtvectorordenadoa = new System.Windows.Forms.TextBox();
            this.lblpasadas = new System.Windows.Forms.Label();
            this.lblpa = new System.Windows.Forms.Label();
            this.lblintercambios = new System.Windows.Forms.Label();
            this.lblis = new System.Windows.Forms.Label();
            this.txtmayor = new System.Windows.Forms.TextBox();
            this.lbltiempo = new System.Windows.Forms.Label();
            this.lbltiempoenordenar = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnEjecutar
            // 
            this.btnEjecutar.Location = new System.Drawing.Point(647, 170);
            this.btnEjecutar.Name = "btnEjecutar";
            this.btnEjecutar.Size = new System.Drawing.Size(90, 47);
            this.btnEjecutar.TabIndex = 0;
            this.btnEjecutar.Text = "Ejecutar ";
            this.btnEjecutar.UseVisualStyleBackColor = true;
            this.btnEjecutar.Click += new System.EventHandler(this.btnEjecutar_Click);
            // 
            // txttamaño
            // 
            this.txttamaño.BackColor = System.Drawing.Color.Black;
            this.txttamaño.ForeColor = System.Drawing.Color.White;
            this.txttamaño.Location = new System.Drawing.Point(629, 83);
            this.txttamaño.Multiline = true;
            this.txttamaño.Name = "txttamaño";
            this.txttamaño.Size = new System.Drawing.Size(100, 30);
            this.txttamaño.TabIndex = 7;
            // 
            // lbltamaño
            // 
            this.lbltamaño.AutoSize = true;
            this.lbltamaño.ForeColor = System.Drawing.Color.Cyan;
            this.lbltamaño.Location = new System.Drawing.Point(527, 94);
            this.lbltamaño.Name = "lbltamaño";
            this.lbltamaño.Size = new System.Drawing.Size(96, 13);
            this.lbltamaño.TabIndex = 8;
            this.lbltamaño.Text = "Tamaño del vector";
            // 
            // btnborrar
            // 
            this.btnborrar.Location = new System.Drawing.Point(647, 237);
            this.btnborrar.Name = "btnborrar";
            this.btnborrar.Size = new System.Drawing.Size(90, 25);
            this.btnborrar.TabIndex = 9;
            this.btnborrar.Text = "Borrar";
            this.btnborrar.UseVisualStyleBackColor = true;
            this.btnborrar.Click += new System.EventHandler(this.btnborrar_Click);
            // 
            // btncerrar
            // 
            this.btncerrar.Location = new System.Drawing.Point(729, 446);
            this.btncerrar.Name = "btncerrar";
            this.btncerrar.Size = new System.Drawing.Size(75, 23);
            this.btncerrar.TabIndex = 10;
            this.btncerrar.Text = "Cerrar";
            this.btncerrar.UseVisualStyleBackColor = true;
            this.btncerrar.Click += new System.EventHandler(this.btncerrar_Click);
            // 
            // lblcomparaciones
            // 
            this.lblcomparaciones.AutoSize = true;
            this.lblcomparaciones.Location = new System.Drawing.Point(677, 325);
            this.lblcomparaciones.Name = "lblcomparaciones";
            this.lblcomparaciones.Size = new System.Drawing.Size(13, 13);
            this.lblcomparaciones.TabIndex = 12;
            this.lblcomparaciones.Text = "0";
            // 
            // lblcontador2
            // 
            this.lblcontador2.AutoSize = true;
            this.lblcontador2.ForeColor = System.Drawing.Color.Cyan;
            this.lblcontador2.Location = new System.Drawing.Point(526, 325);
            this.lblcontador2.Name = "lblcontador2";
            this.lblcontador2.Size = new System.Drawing.Size(80, 13);
            this.lblcontador2.TabIndex = 11;
            this.lblcontador2.Text = "Comparaciones";
            // 
            // txtvectorordenadoa
            // 
            this.txtvectorordenadoa.BackColor = System.Drawing.SystemColors.MenuText;
            this.txtvectorordenadoa.ForeColor = System.Drawing.SystemColors.Info;
            this.txtvectorordenadoa.Location = new System.Drawing.Point(12, 22);
            this.txtvectorordenadoa.Multiline = true;
            this.txtvectorordenadoa.Name = "txtvectorordenadoa";
            this.txtvectorordenadoa.Size = new System.Drawing.Size(236, 382);
            this.txtvectorordenadoa.TabIndex = 13;
            // 
            // lblpasadas
            // 
            this.lblpasadas.AutoSize = true;
            this.lblpasadas.ForeColor = System.Drawing.Color.Cyan;
            this.lblpasadas.Location = new System.Drawing.Point(526, 355);
            this.lblpasadas.Name = "lblpasadas";
            this.lblpasadas.Size = new System.Drawing.Size(48, 13);
            this.lblpasadas.TabIndex = 14;
            this.lblpasadas.Text = "Pasadas";
            // 
            // lblpa
            // 
            this.lblpa.AutoSize = true;
            this.lblpa.Location = new System.Drawing.Point(677, 355);
            this.lblpa.Name = "lblpa";
            this.lblpa.Size = new System.Drawing.Size(13, 13);
            this.lblpa.TabIndex = 15;
            this.lblpa.Text = "0";
            // 
            // lblintercambios
            // 
            this.lblintercambios.AutoSize = true;
            this.lblintercambios.ForeColor = System.Drawing.Color.Cyan;
            this.lblintercambios.Location = new System.Drawing.Point(526, 380);
            this.lblintercambios.Name = "lblintercambios";
            this.lblintercambios.Size = new System.Drawing.Size(67, 13);
            this.lblintercambios.TabIndex = 16;
            this.lblintercambios.Text = "Intercambios";
            // 
            // lblis
            // 
            this.lblis.AutoSize = true;
            this.lblis.Location = new System.Drawing.Point(677, 380);
            this.lblis.Name = "lblis";
            this.lblis.Size = new System.Drawing.Size(13, 13);
            this.lblis.TabIndex = 17;
            this.lblis.Text = "0";
            // 
            // txtmayor
            // 
            this.txtmayor.BackColor = System.Drawing.SystemColors.MenuText;
            this.txtmayor.ForeColor = System.Drawing.SystemColors.Info;
            this.txtmayor.Location = new System.Drawing.Point(254, 22);
            this.txtmayor.Multiline = true;
            this.txtmayor.Name = "txtmayor";
            this.txtmayor.Size = new System.Drawing.Size(234, 382);
            this.txtmayor.TabIndex = 18;
            // 
            // lbltiempo
            // 
            this.lbltiempo.AutoSize = true;
            this.lbltiempo.ForeColor = System.Drawing.Color.Cyan;
            this.lbltiempo.Location = new System.Drawing.Point(529, 295);
            this.lbltiempo.Name = "lbltiempo";
            this.lbltiempo.Size = new System.Drawing.Size(45, 13);
            this.lbltiempo.TabIndex = 19;
            this.lbltiempo.Text = "Tiempo ";
            // 
            // lbltiempoenordenar
            // 
            this.lbltiempoenordenar.AutoSize = true;
            this.lbltiempoenordenar.Location = new System.Drawing.Point(677, 295);
            this.lbltiempoenordenar.Name = "lbltiempoenordenar";
            this.lbltiempoenordenar.Size = new System.Drawing.Size(22, 13);
            this.lbltiempoenordenar.TabIndex = 20;
            this.lbltiempoenordenar.Text = "0:0";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gray;
            this.ClientSize = new System.Drawing.Size(815, 487);
            this.Controls.Add(this.lbltiempoenordenar);
            this.Controls.Add(this.lbltiempo);
            this.Controls.Add(this.txtmayor);
            this.Controls.Add(this.lblis);
            this.Controls.Add(this.lblintercambios);
            this.Controls.Add(this.lblpa);
            this.Controls.Add(this.lblpasadas);
            this.Controls.Add(this.txtvectorordenadoa);
            this.Controls.Add(this.lblcomparaciones);
            this.Controls.Add(this.lblcontador2);
            this.Controls.Add(this.btncerrar);
            this.Controls.Add(this.btnborrar);
            this.Controls.Add(this.lbltamaño);
            this.Controls.Add(this.txttamaño);
            this.Controls.Add(this.btnEjecutar);
            this.Name = "Form1";
            this.Text = "Ordenamiento por selección";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnEjecutar;
        private System.Windows.Forms.TextBox txttamaño;
        private System.Windows.Forms.Label lbltamaño;
        private System.Windows.Forms.Button btnborrar;
        private System.Windows.Forms.Button btncerrar;
        private System.Windows.Forms.Label lblcomparaciones;
        private System.Windows.Forms.Label lblcontador2;
        private System.Windows.Forms.TextBox txtvectorordenadoa;
        private System.Windows.Forms.Label lblpasadas;
        private System.Windows.Forms.Label lblpa;
        private System.Windows.Forms.Label lblintercambios;
        private System.Windows.Forms.Label lblis;
        private System.Windows.Forms.TextBox txtmayor;
        private System.Windows.Forms.Label lbltiempo;
        private System.Windows.Forms.Label lbltiempoenordenar;
    }
}

