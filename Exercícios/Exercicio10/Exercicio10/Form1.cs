using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exercicio10
{
    public partial class Form1 : Form
    {

        List<string> carro = new List<string>();

        public Form1()
        {
            InitializeComponent();
        }

        private void buttonCadastrar_Click(object sender, EventArgs e)
        {
            Carro car = new Carro();

            try
            {
                car.SetModelo(textModelo.Text);
                car.SetPlaca(textPlaca.Text);
                car.SetMarca(textMarca.Text);
                car.SetAno(int.Parse(textAno.Text));
                car.SetKilometragem(double.Parse(textKm.Text));
                car.SetCapacidade(double.Parse(textCapacidade.Text));
                car.SetPotencia(double.Parse(textPotencia.Text));

                carro.Add(car.GetModelo());
                carro.Add(car.GetPlaca());
                carro.Add(car.GetMarca());
                carro.Add(car.GetAno().ToString());
                carro.Add(car.GetKilometragem().ToString());
                carro.Add(car.GetCapacidade().ToString());
                carro.Add(car.GetPotencia().ToString());

                //carro[0 + (7 *(n - 1))] = Modelo do Carro n 
                //carro[1 + (7 *(n - 1))] = Placa do Carro n 
                //carro[2 + (7 *(n - 1))] = Marca do Carro n 
                //carro[3 + (7 *(n - 1))] = Ano do Carro n 
                //carro[4 + (7 *(n - 1))] = Kilometragem do Carro n 
                //carro[5 + (7 *(n - 1))] = Capacidade do tanque do Carro n 
                //carro[6 + (7 *(n - 1))] = Potêcia do Carro n
            }

            catch (Exception)
            {
                MessageBox.Show("Há campos inválidos.", "Erro no cadastro");
            }

            finally
            {
                textModelo.Clear();
                textPlaca.Clear();
                textMarca.Clear();
                textAno.Clear();
                textKm.Clear();
                textCapacidade.Clear();
                textPotencia.Clear();
            }
        }

        private void buttonBuscar_Click(object sender, EventArgs e)
        {
            bool continuarBusca = true;
            int n = 1;

            while ((1 + (7 * (n - 1))) < carro.Count && continuarBusca == true)
                {
                    if (carro[1 + (7 * (n - 1))] == textBuscar.Text)
                    {
                        continuarBusca = false;
                        MessageBox.Show("Há um carro cadastrado com a placa " + textBuscar.Text + "." + "\r\nModelo:"
                            + carro[0 + (7 * (n - 1))] + "\r\nPlaca:" + carro[1 + (7 * (n - 1))] + "\r\nMarca:" + carro[2 + (7 * (n - 1))] 
                            + "\r\nAno:" + carro[3 + (7 * (n - 1))] + "\r\nKilometragem:" + carro[4 + (7 * (n - 1))] + "\r\nCapacidade do tanque:" 
                            + carro[5 + (7 * (n - 1))] + "\r\nPotência:" + carro[6 + (7 * (n - 1))], "Busca Concluída");
                    }

                    else
                    {
                        n += 7;
                    }
                }

            if (continuarBusca)
            {
                MessageBox.Show("Não há nenhum carro cadastrado com a placa " + textBuscar.Text + ".", "Busca Inválida");
            }
             
            textBuscar.Clear();
        }
    }

}

