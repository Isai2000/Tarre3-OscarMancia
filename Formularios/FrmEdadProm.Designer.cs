namespace ProgramacionOrientadaaObjetos.Formularios
{
    partial class FrmEdadProm
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.TxtEdad = new System.Windows.Forms.TextBox();
            this.LstMostrar = new System.Windows.Forms.ListBox();
            this.BtnAgregar = new System.Windows.Forms.Button();
            this.BtnCalc = new System.Windows.Forms.Button();
            this.BtnLmipiar = new System.Windows.Forms.Button();
            this.BtnSalir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.label1.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(350, 52);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ingrese los datos";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Ingrese Edad:";
            // 
            // TxtEdad
            // 
            this.TxtEdad.Location = new System.Drawing.Point(103, 85);
            this.TxtEdad.Name = "TxtEdad";
            this.TxtEdad.Size = new System.Drawing.Size(104, 25);
            this.TxtEdad.TabIndex = 2;
            // 
            // LstMostrar
            // 
            this.LstMostrar.FormattingEnabled = true;
            this.LstMostrar.ItemHeight = 20;
            this.LstMostrar.Location = new System.Drawing.Point(16, 131);
            this.LstMostrar.Name = "LstMostrar";
            this.LstMostrar.Size = new System.Drawing.Size(141, 124);
            this.LstMostrar.TabIndex = 3;
            // 
            // BtnAgregar
            // 
            this.BtnAgregar.Location = new System.Drawing.Point(193, 143);
            this.BtnAgregar.Name = "BtnAgregar";
            this.BtnAgregar.Size = new System.Drawing.Size(75, 35);
            this.BtnAgregar.TabIndex = 4;
            this.BtnAgregar.Text = "Agregar";
            this.BtnAgregar.UseVisualStyleBackColor = true;
            this.BtnAgregar.Click += new System.EventHandler(this.BtnAgregar_Click);
            // 
            // BtnCalc
            // 
            this.BtnCalc.Location = new System.Drawing.Point(193, 184);
            this.BtnCalc.Name = "BtnCalc";
            this.BtnCalc.Size = new System.Drawing.Size(75, 35);
            this.BtnCalc.TabIndex = 5;
            this.BtnCalc.Text = "Calcular";
            this.BtnCalc.UseVisualStyleBackColor = true;
            this.BtnCalc.Click += new System.EventHandler(this.BtnCalc_Click);
            // 
            // BtnLmipiar
            // 
            this.BtnLmipiar.Location = new System.Drawing.Point(274, 143);
            this.BtnLmipiar.Name = "BtnLmipiar";
            this.BtnLmipiar.Size = new System.Drawing.Size(75, 35);
            this.BtnLmipiar.TabIndex = 6;
            this.BtnLmipiar.Text = "Limpiar";
            this.BtnLmipiar.UseVisualStyleBackColor = true;
            this.BtnLmipiar.Click += new System.EventHandler(this.BtnLmipiar_Click);
            // 
            // BtnSalir
            // 
            this.BtnSalir.Location = new System.Drawing.Point(274, 184);
            this.BtnSalir.Name = "BtnSalir";
            this.BtnSalir.Size = new System.Drawing.Size(75, 35);
            this.BtnSalir.TabIndex = 7;
            this.BtnSalir.Text = "Salir";
            this.BtnSalir.UseVisualStyleBackColor = true;
            this.BtnSalir.Click += new System.EventHandler(this.BtnSalir_Click);
            // 
            // FrmEdadProm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(374, 295);
            this.ControlBox = false;
            this.Controls.Add(this.BtnSalir);
            this.Controls.Add(this.BtnLmipiar);
            this.Controls.Add(this.BtnCalc);
            this.Controls.Add(this.BtnAgregar);
            this.Controls.Add(this.LstMostrar);
            this.Controls.Add(this.TxtEdad);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "FrmEdadProm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Calcular Edad Promedio de 10 Personas";
            this.Load += new System.EventHandler(this.FrmEdadProm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TxtEdad;
        private System.Windows.Forms.ListBox LstMostrar;
        private System.Windows.Forms.Button BtnAgregar;
        private System.Windows.Forms.Button BtnCalc;
        private System.Windows.Forms.Button BtnLmipiar;
        private System.Windows.Forms.Button BtnSalir;
    }
}