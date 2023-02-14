namespace GM21057Guia4Ejercicio4Selectiva
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.buttonBorrar = new System.Windows.Forms.Button();
            this.buttonAgregarElementos = new System.Windows.Forms.Button();
            this.textPeso = new System.Windows.Forms.TextBox();
            this.textAltura = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.salir = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.diagnostico = new System.Windows.Forms.TextBox();
            this.valorImc = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.buttonBorrar);
            this.groupBox1.Controls.Add(this.buttonAgregarElementos);
            this.groupBox1.Controls.Add(this.textPeso);
            this.groupBox1.Controls.Add(this.textAltura);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(397, 114);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // buttonBorrar
            // 
            this.buttonBorrar.Location = new System.Drawing.Point(316, 70);
            this.buttonBorrar.Name = "buttonBorrar";
            this.buttonBorrar.Size = new System.Drawing.Size(75, 23);
            this.buttonBorrar.TabIndex = 5;
            this.buttonBorrar.Text = "Borrar";
            this.buttonBorrar.UseVisualStyleBackColor = true;
            this.buttonBorrar.Click += new System.EventHandler(this.buttonBorrar_Click);
            // 
            // buttonAgregarElementos
            // 
            this.buttonAgregarElementos.Location = new System.Drawing.Point(316, 23);
            this.buttonAgregarElementos.Name = "buttonAgregarElementos";
            this.buttonAgregarElementos.Size = new System.Drawing.Size(75, 23);
            this.buttonAgregarElementos.TabIndex = 4;
            this.buttonAgregarElementos.Text = "Agregar";
            this.buttonAgregarElementos.UseVisualStyleBackColor = true;
            this.buttonAgregarElementos.Click += new System.EventHandler(this.buttonAgregarElementos_Click);
            // 
            // textPeso
            // 
            this.textPeso.Location = new System.Drawing.Point(198, 70);
            this.textPeso.Name = "textPeso";
            this.textPeso.Size = new System.Drawing.Size(100, 23);
            this.textPeso.TabIndex = 3;
            // 
            // textAltura
            // 
            this.textAltura.Location = new System.Drawing.Point(198, 23);
            this.textAltura.Name = "textAltura";
            this.textAltura.Size = new System.Drawing.Size(100, 23);
            this.textAltura.TabIndex = 2;
            this.textAltura.TextChanged += new System.EventHandler(this.textAltura_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(124, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Ingrese su peso en Kg:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(152, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ingrese su altura en metros:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.salir);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.diagnostico);
            this.groupBox2.Controls.Add(this.valorImc);
            this.groupBox2.Location = new System.Drawing.Point(12, 132);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(397, 100);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            // 
            // salir
            // 
            this.salir.Location = new System.Drawing.Point(316, 21);
            this.salir.Name = "salir";
            this.salir.Size = new System.Drawing.Size(75, 23);
            this.salir.TabIndex = 6;
            this.salir.Text = "Salir";
            this.salir.UseVisualStyleBackColor = true;
            this.salir.Click += new System.EventHandler(this.salir_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(15, 71);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 15);
            this.label4.TabIndex = 8;
            this.label4.Text = "Diagnostico:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 25);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 15);
            this.label3.TabIndex = 6;
            this.label3.Text = "Valor de imc:";
            // 
            // diagnostico
            // 
            this.diagnostico.Location = new System.Drawing.Point(198, 68);
            this.diagnostico.Name = "diagnostico";
            this.diagnostico.Size = new System.Drawing.Size(180, 23);
            this.diagnostico.TabIndex = 6;
            // 
            // valorImc
            // 
            this.valorImc.Location = new System.Drawing.Point(198, 22);
            this.valorImc.Name = "valorImc";
            this.valorImc.Size = new System.Drawing.Size(100, 23);
            this.valorImc.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(449, 258);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "INDICE DE MASA CORPORAL";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private GroupBox groupBox1;
        private Button buttonBorrar;
        private Button buttonAgregarElementos;
        private TextBox textPeso;
        private TextBox textAltura;
        private Label label2;
        private Label label1;
        private GroupBox groupBox2;
        private Label label3;
        private TextBox diagnostico;
        private TextBox valorImc;
        private Label label4;
        private Button salir;
    }
}