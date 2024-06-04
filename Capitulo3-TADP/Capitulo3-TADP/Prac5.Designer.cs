namespace Capitulo3_TADP
{
    partial class Prac5
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
            this.txtEdad = new System.Windows.Forms.TextBox();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnAgregarEdad = new System.Windows.Forms.Button();
            this.lstEdades = new System.Windows.Forms.ListBox();
            this.lblResultado = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtEdad
            // 
            this.txtEdad.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtEdad.Font = new System.Drawing.Font("Arial Rounded MT Bold", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEdad.Location = new System.Drawing.Point(57, 178);
            this.txtEdad.Name = "txtEdad";
            this.txtEdad.Size = new System.Drawing.Size(185, 27);
            this.txtEdad.TabIndex = 18;
            this.txtEdad.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnCalcular
            // 
            this.btnCalcular.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnCalcular.Location = new System.Drawing.Point(364, 197);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(121, 50);
            this.btnCalcular.TabIndex = 17;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(40, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(360, 92);
            this.label1.TabIndex = 16;
            this.label1.Text = "Hacer un programa que calcule el\r\npromedio de edad de un grupo de\r\npersonas y dig" +
    "a cuál es la de edad más\r\ngrande y cuál es la más joven.";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(63, 138);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 23);
            this.label2.TabIndex = 22;
            this.label2.Text = "Edad:";
            // 
            // btnAgregarEdad
            // 
            this.btnAgregarEdad.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnAgregarEdad.Location = new System.Drawing.Point(364, 98);
            this.btnAgregarEdad.Name = "btnAgregarEdad";
            this.btnAgregarEdad.Size = new System.Drawing.Size(121, 50);
            this.btnAgregarEdad.TabIndex = 27;
            this.btnAgregarEdad.Text = "Agregar Edad";
            this.btnAgregarEdad.UseVisualStyleBackColor = true;
            this.btnAgregarEdad.Click += new System.EventHandler(this.btnAgregarEdad_Click);
            // 
            // lstEdades
            // 
            this.lstEdades.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lstEdades.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstEdades.FormattingEnabled = true;
            this.lstEdades.ItemHeight = 23;
            this.lstEdades.Location = new System.Drawing.Point(544, 22);
            this.lstEdades.Name = "lstEdades";
            this.lstEdades.Size = new System.Drawing.Size(219, 345);
            this.lstEdades.TabIndex = 28;
            // 
            // lblResultado
            // 
            this.lblResultado.AutoSize = true;
            this.lblResultado.Location = new System.Drawing.Point(41, 277);
            this.lblResultado.Name = "lblResultado";
            this.lblResultado.Size = new System.Drawing.Size(10, 16);
            this.lblResultado.TabIndex = 29;
            this.lblResultado.Text = " ";
            // 
            // Prac5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblResultado);
            this.Controls.Add(this.lstEdades);
            this.Controls.Add(this.btnAgregarEdad);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtEdad);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.label1);
            this.Name = "Prac5";
            this.Text = "Prac5";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtEdad;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnAgregarEdad;
        private System.Windows.Forms.ListBox lstEdades;
        private System.Windows.Forms.Label lblResultado;
    }
}