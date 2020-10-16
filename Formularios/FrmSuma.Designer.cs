namespace ProgramacionOrientadaaObjetos.Formularios
{
    partial class FrmSuma
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
            this.TxtN1 = new System.Windows.Forms.TextBox();
            this.TxtN2 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.TxtN3 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.BtnCalc = new System.Windows.Forms.Button();
            this.BtnLimo = new System.Windows.Forms.Button();
            this.BtnSalir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.label1.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(346, 56);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ingrese los datos";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 97);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(116, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Ingrese un numero:";
            // 
            // TxtN1
            // 
            this.TxtN1.Location = new System.Drawing.Point(134, 97);
            this.TxtN1.Name = "TxtN1";
            this.TxtN1.Size = new System.Drawing.Size(100, 25);
            this.TxtN1.TabIndex = 2;
            // 
            // TxtN2
            // 
            this.TxtN2.Location = new System.Drawing.Point(134, 133);
            this.TxtN2.Name = "TxtN2";
            this.TxtN2.Size = new System.Drawing.Size(100, 25);
            this.TxtN2.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 133);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(116, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "Ingrese un numero:";
            // 
            // TxtN3
            // 
            this.TxtN3.Location = new System.Drawing.Point(134, 164);
            this.TxtN3.Name = "TxtN3";
            this.TxtN3.Size = new System.Drawing.Size(100, 25);
            this.TxtN3.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 164);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(116, 20);
            this.label4.TabIndex = 5;
            this.label4.Text = "Ingrese un numero:";
            // 
            // BtnCalc
            // 
            this.BtnCalc.Location = new System.Drawing.Point(94, 228);
            this.BtnCalc.Name = "BtnCalc";
            this.BtnCalc.Size = new System.Drawing.Size(84, 32);
            this.BtnCalc.TabIndex = 7;
            this.BtnCalc.Text = "Calcular";
            this.BtnCalc.UseVisualStyleBackColor = true;
            this.BtnCalc.Click += new System.EventHandler(this.BtnCalc_Click);
            // 
            // BtnLimo
            // 
            this.BtnLimo.Location = new System.Drawing.Point(184, 229);
            this.BtnLimo.Name = "BtnLimo";
            this.BtnLimo.Size = new System.Drawing.Size(84, 32);
            this.BtnLimo.TabIndex = 10;
            this.BtnLimo.Text = "Lmipiar";
            this.BtnLimo.UseVisualStyleBackColor = true;
            this.BtnLimo.Click += new System.EventHandler(this.BtnLimo_Click);
            // 
            // BtnSalir
            // 
            this.BtnSalir.Location = new System.Drawing.Point(274, 228);
            this.BtnSalir.Name = "BtnSalir";
            this.BtnSalir.Size = new System.Drawing.Size(84, 32);
            this.BtnSalir.TabIndex = 11;
            this.BtnSalir.Text = "Salir";
            this.BtnSalir.UseVisualStyleBackColor = true;
            this.BtnSalir.Click += new System.EventHandler(this.BtnSalir_Click);
            // 
            // FrmSuma
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(370, 269);
            this.ControlBox = false;
            this.Controls.Add(this.BtnSalir);
            this.Controls.Add(this.BtnLimo);
            this.Controls.Add(this.BtnCalc);
            this.Controls.Add(this.TxtN3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.TxtN2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.TxtN1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "FrmSuma";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Suma de 3 numeros";
            this.Load += new System.EventHandler(this.FrmSuma_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TxtN1;
        private System.Windows.Forms.TextBox TxtN2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TxtN3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button BtnCalc;
        private System.Windows.Forms.Button BtnLimo;
        private System.Windows.Forms.Button BtnSalir;
    }
}