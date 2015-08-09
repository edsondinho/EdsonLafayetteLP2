namespace Trabalho2Cert
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
            this.labelModelo = new System.Windows.Forms.Label();
            this.labelMarca = new System.Windows.Forms.Label();
            this.labelPlaca = new System.Windows.Forms.Label();
            this.labelCapacidade = new System.Windows.Forms.Label();
            this.textModelo = new System.Windows.Forms.TextBox();
            this.textMarca = new System.Windows.Forms.TextBox();
            this.textPlaca = new System.Windows.Forms.TextBox();
            this.textCapacidade = new System.Windows.Forms.TextBox();
            this.buttonCadastrarCar = new System.Windows.Forms.Button();
            this.textPedido = new System.Windows.Forms.TextBox();
            this.labelPedido = new System.Windows.Forms.Label();
            this.buttonPedir = new System.Windows.Forms.Button();
            this.textResposta = new System.Windows.Forms.TextBox();
            this.buttonLimpar = new System.Windows.Forms.Button();
            this.buttonReset = new System.Windows.Forms.Button();
            this.buttonCadastrarQuant = new System.Windows.Forms.Button();
            this.textQuantidade = new System.Windows.Forms.TextBox();
            this.labelQuantidade = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelModelo
            // 
            this.labelModelo.AutoSize = true;
            this.labelModelo.Location = new System.Drawing.Point(12, 67);
            this.labelModelo.Name = "labelModelo";
            this.labelModelo.Size = new System.Drawing.Size(45, 13);
            this.labelModelo.TabIndex = 0;
            this.labelModelo.Text = "Modelo:";
            // 
            // labelMarca
            // 
            this.labelMarca.AutoSize = true;
            this.labelMarca.Location = new System.Drawing.Point(12, 92);
            this.labelMarca.Name = "labelMarca";
            this.labelMarca.Size = new System.Drawing.Size(40, 13);
            this.labelMarca.TabIndex = 1;
            this.labelMarca.Text = "Marca:";
            // 
            // labelPlaca
            // 
            this.labelPlaca.AutoSize = true;
            this.labelPlaca.Location = new System.Drawing.Point(12, 117);
            this.labelPlaca.Name = "labelPlaca";
            this.labelPlaca.Size = new System.Drawing.Size(37, 13);
            this.labelPlaca.TabIndex = 2;
            this.labelPlaca.Text = "Placa:";
            // 
            // labelCapacidade
            // 
            this.labelCapacidade.AutoSize = true;
            this.labelCapacidade.Location = new System.Drawing.Point(12, 142);
            this.labelCapacidade.Name = "labelCapacidade";
            this.labelCapacidade.Size = new System.Drawing.Size(141, 13);
            this.labelCapacidade.TabIndex = 3;
            this.labelCapacidade.Text = "Capacidade de passageiros:";
            // 
            // textModelo
            // 
            this.textModelo.Location = new System.Drawing.Point(184, 64);
            this.textModelo.Name = "textModelo";
            this.textModelo.Size = new System.Drawing.Size(100, 20);
            this.textModelo.TabIndex = 4;
            // 
            // textMarca
            // 
            this.textMarca.Location = new System.Drawing.Point(184, 90);
            this.textMarca.Name = "textMarca";
            this.textMarca.Size = new System.Drawing.Size(100, 20);
            this.textMarca.TabIndex = 5;
            // 
            // textPlaca
            // 
            this.textPlaca.Location = new System.Drawing.Point(184, 116);
            this.textPlaca.Name = "textPlaca";
            this.textPlaca.Size = new System.Drawing.Size(100, 20);
            this.textPlaca.TabIndex = 6;
            // 
            // textCapacidade
            // 
            this.textCapacidade.Location = new System.Drawing.Point(184, 142);
            this.textCapacidade.Name = "textCapacidade";
            this.textCapacidade.Size = new System.Drawing.Size(100, 20);
            this.textCapacidade.TabIndex = 7;
            // 
            // buttonCadastrarCar
            // 
            this.buttonCadastrarCar.Location = new System.Drawing.Point(15, 168);
            this.buttonCadastrarCar.Name = "buttonCadastrarCar";
            this.buttonCadastrarCar.Size = new System.Drawing.Size(269, 23);
            this.buttonCadastrarCar.TabIndex = 8;
            this.buttonCadastrarCar.Text = "Cadastrar Carro";
            this.buttonCadastrarCar.UseVisualStyleBackColor = true;
            this.buttonCadastrarCar.Click += new System.EventHandler(this.buttonCadastrarCar_Click);
            // 
            // textPedido
            // 
            this.textPedido.Location = new System.Drawing.Point(184, 197);
            this.textPedido.Name = "textPedido";
            this.textPedido.Size = new System.Drawing.Size(100, 20);
            this.textPedido.TabIndex = 9;
            // 
            // labelPedido
            // 
            this.labelPedido.AutoSize = true;
            this.labelPedido.Location = new System.Drawing.Point(12, 200);
            this.labelPedido.Name = "labelPedido";
            this.labelPedido.Size = new System.Drawing.Size(85, 13);
            this.labelPedido.TabIndex = 10;
            this.labelPedido.Text = "Pedido de vaga:";
            // 
            // buttonPedir
            // 
            this.buttonPedir.Location = new System.Drawing.Point(15, 223);
            this.buttonPedir.Name = "buttonPedir";
            this.buttonPedir.Size = new System.Drawing.Size(269, 23);
            this.buttonPedir.TabIndex = 11;
            this.buttonPedir.Text = "Pedir Vaga";
            this.buttonPedir.UseVisualStyleBackColor = true;
            this.buttonPedir.Click += new System.EventHandler(this.buttonPedir_Click);
            // 
            // textResposta
            // 
            this.textResposta.Location = new System.Drawing.Point(15, 252);
            this.textResposta.Multiline = true;
            this.textResposta.Name = "textResposta";
            this.textResposta.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textResposta.Size = new System.Drawing.Size(269, 89);
            this.textResposta.TabIndex = 12;
            // 
            // buttonLimpar
            // 
            this.buttonLimpar.Location = new System.Drawing.Point(15, 347);
            this.buttonLimpar.Name = "buttonLimpar";
            this.buttonLimpar.Size = new System.Drawing.Size(115, 23);
            this.buttonLimpar.TabIndex = 13;
            this.buttonLimpar.Text = "Limpar";
            this.buttonLimpar.UseVisualStyleBackColor = true;
            this.buttonLimpar.Click += new System.EventHandler(this.buttonLimpar_Click);
            // 
            // buttonReset
            // 
            this.buttonReset.Location = new System.Drawing.Point(169, 347);
            this.buttonReset.Name = "buttonReset";
            this.buttonReset.Size = new System.Drawing.Size(115, 23);
            this.buttonReset.TabIndex = 14;
            this.buttonReset.Text = "Reset";
            this.buttonReset.UseVisualStyleBackColor = true;
            this.buttonReset.Click += new System.EventHandler(this.buttonReset_Click);
            // 
            // buttonCadastrarQuant
            // 
            this.buttonCadastrarQuant.Location = new System.Drawing.Point(15, 35);
            this.buttonCadastrarQuant.Name = "buttonCadastrarQuant";
            this.buttonCadastrarQuant.Size = new System.Drawing.Size(269, 23);
            this.buttonCadastrarQuant.TabIndex = 15;
            this.buttonCadastrarQuant.Text = "Cadastrar Quantidade de Carros";
            this.buttonCadastrarQuant.UseVisualStyleBackColor = true;
            this.buttonCadastrarQuant.Click += new System.EventHandler(this.buttonCadastrarQuant_Click);
            // 
            // textQuantidade
            // 
            this.textQuantidade.Location = new System.Drawing.Point(184, 9);
            this.textQuantidade.Name = "textQuantidade";
            this.textQuantidade.Size = new System.Drawing.Size(100, 20);
            this.textQuantidade.TabIndex = 17;
            // 
            // labelQuantidade
            // 
            this.labelQuantidade.AutoSize = true;
            this.labelQuantidade.Location = new System.Drawing.Point(12, 9);
            this.labelQuantidade.Name = "labelQuantidade";
            this.labelQuantidade.Size = new System.Drawing.Size(112, 13);
            this.labelQuantidade.TabIndex = 16;
            this.labelQuantidade.Text = "Quantidade de carros:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(298, 378);
            this.Controls.Add(this.textQuantidade);
            this.Controls.Add(this.labelQuantidade);
            this.Controls.Add(this.buttonCadastrarQuant);
            this.Controls.Add(this.buttonReset);
            this.Controls.Add(this.buttonLimpar);
            this.Controls.Add(this.textResposta);
            this.Controls.Add(this.buttonPedir);
            this.Controls.Add(this.labelPedido);
            this.Controls.Add(this.textPedido);
            this.Controls.Add(this.buttonCadastrarCar);
            this.Controls.Add(this.textCapacidade);
            this.Controls.Add(this.textPlaca);
            this.Controls.Add(this.textMarca);
            this.Controls.Add(this.textModelo);
            this.Controls.Add(this.labelCapacidade);
            this.Controls.Add(this.labelPlaca);
            this.Controls.Add(this.labelMarca);
            this.Controls.Add(this.labelModelo);
            this.Name = "Form1";
            this.Text = "Trabalho 2ª Certificação";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelModelo;
        private System.Windows.Forms.Label labelMarca;
        private System.Windows.Forms.Label labelPlaca;
        private System.Windows.Forms.Label labelCapacidade;
        private System.Windows.Forms.TextBox textModelo;
        private System.Windows.Forms.TextBox textMarca;
        private System.Windows.Forms.TextBox textPlaca;
        private System.Windows.Forms.TextBox textCapacidade;
        private System.Windows.Forms.Button buttonCadastrarCar;
        private System.Windows.Forms.TextBox textPedido;
        private System.Windows.Forms.Label labelPedido;
        private System.Windows.Forms.Button buttonPedir;
        private System.Windows.Forms.TextBox textResposta;
        private System.Windows.Forms.Button buttonLimpar;
        private System.Windows.Forms.Button buttonReset;
        private System.Windows.Forms.Button buttonCadastrarQuant;
        private System.Windows.Forms.TextBox textQuantidade;
        private System.Windows.Forms.Label labelQuantidade;
    }
}

