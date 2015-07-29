namespace Exercicio10
{
    partial class Form1
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
            this.buttonCadastrar = new System.Windows.Forms.Button();
            this.textModelo = new System.Windows.Forms.TextBox();
            this.textPlaca = new System.Windows.Forms.TextBox();
            this.textMarca = new System.Windows.Forms.TextBox();
            this.textAno = new System.Windows.Forms.TextBox();
            this.textKm = new System.Windows.Forms.TextBox();
            this.textCapacidade = new System.Windows.Forms.TextBox();
            this.textPotencia = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.textBuscar = new System.Windows.Forms.TextBox();
            this.buttonBuscar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonCadastrar
            // 
            this.buttonCadastrar.Location = new System.Drawing.Point(139, 190);
            this.buttonCadastrar.Name = "buttonCadastrar";
            this.buttonCadastrar.Size = new System.Drawing.Size(102, 23);
            this.buttonCadastrar.TabIndex = 0;
            this.buttonCadastrar.Text = "Cadastrar Carro";
            this.buttonCadastrar.UseVisualStyleBackColor = true;
            this.buttonCadastrar.Click += new System.EventHandler(this.buttonCadastrar_Click);
            // 
            // textModelo
            // 
            this.textModelo.Location = new System.Drawing.Point(139, 18);
            this.textModelo.Name = "textModelo";
            this.textModelo.Size = new System.Drawing.Size(102, 20);
            this.textModelo.TabIndex = 1;
            // 
            // textPlaca
            // 
            this.textPlaca.Location = new System.Drawing.Point(139, 42);
            this.textPlaca.Name = "textPlaca";
            this.textPlaca.Size = new System.Drawing.Size(102, 20);
            this.textPlaca.TabIndex = 2;
            // 
            // textMarca
            // 
            this.textMarca.Location = new System.Drawing.Point(139, 66);
            this.textMarca.Name = "textMarca";
            this.textMarca.Size = new System.Drawing.Size(102, 20);
            this.textMarca.TabIndex = 3;
            // 
            // textAno
            // 
            this.textAno.Location = new System.Drawing.Point(139, 90);
            this.textAno.Name = "textAno";
            this.textAno.Size = new System.Drawing.Size(102, 20);
            this.textAno.TabIndex = 4;
            // 
            // textKm
            // 
            this.textKm.Location = new System.Drawing.Point(139, 114);
            this.textKm.Name = "textKm";
            this.textKm.Size = new System.Drawing.Size(102, 20);
            this.textKm.TabIndex = 5;
            // 
            // textCapacidade
            // 
            this.textCapacidade.Location = new System.Drawing.Point(139, 138);
            this.textCapacidade.Name = "textCapacidade";
            this.textCapacidade.Size = new System.Drawing.Size(102, 20);
            this.textCapacidade.TabIndex = 6;
            // 
            // textPotencia
            // 
            this.textPotencia.Location = new System.Drawing.Point(139, 164);
            this.textPotencia.Name = "textPotencia";
            this.textPotencia.Size = new System.Drawing.Size(102, 20);
            this.textPotencia.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(86, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Modelo:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(94, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Placa:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(91, 69);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Marca:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(102, 93);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Ano:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(58, 117);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(73, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "Kilometragem:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(13, 141);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(118, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "Capacidade do tanque:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(79, 167);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(52, 13);
            this.label7.TabIndex = 14;
            this.label7.Text = "Potência:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(94, 227);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(37, 13);
            this.label8.TabIndex = 15;
            this.label8.Text = "Placa:";
            // 
            // textBuscar
            // 
            this.textBuscar.Location = new System.Drawing.Point(139, 224);
            this.textBuscar.Name = "textBuscar";
            this.textBuscar.Size = new System.Drawing.Size(100, 20);
            this.textBuscar.TabIndex = 16;
            // 
            // buttonBuscar
            // 
            this.buttonBuscar.Location = new System.Drawing.Point(139, 250);
            this.buttonBuscar.Name = "buttonBuscar";
            this.buttonBuscar.Size = new System.Drawing.Size(100, 23);
            this.buttonBuscar.TabIndex = 17;
            this.buttonBuscar.Text = "Buscar";
            this.buttonBuscar.UseVisualStyleBackColor = true;
            this.buttonBuscar.Click += new System.EventHandler(this.buttonBuscar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(258, 289);
            this.Controls.Add(this.buttonBuscar);
            this.Controls.Add(this.textBuscar);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textPotencia);
            this.Controls.Add(this.textCapacidade);
            this.Controls.Add(this.textKm);
            this.Controls.Add(this.textAno);
            this.Controls.Add(this.textMarca);
            this.Controls.Add(this.textPlaca);
            this.Controls.Add(this.textModelo);
            this.Controls.Add(this.buttonCadastrar);
            this.Name = "Form1";
            this.Text = "Cadastro de Carros";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonCadastrar;
        private System.Windows.Forms.TextBox textModelo;
        private System.Windows.Forms.TextBox textPlaca;
        private System.Windows.Forms.TextBox textMarca;
        private System.Windows.Forms.TextBox textAno;
        private System.Windows.Forms.TextBox textKm;
        private System.Windows.Forms.TextBox textCapacidade;
        private System.Windows.Forms.TextBox textPotencia;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBuscar;
        private System.Windows.Forms.Button buttonBuscar;
    }
}

