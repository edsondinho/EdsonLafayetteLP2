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

        int id = 0;
        List<Carro> car = new List<Carro>();

        public Form1()
        {
            InitializeComponent();
        }

        private void buttonCadastrar_Click(object sender, EventArgs e)
        {

            try
            {
                car.Add(new Carro());
                car[id].SetModelo(textModelo.Text);
                car[id].SetPlaca(textPlaca.Text);
                car[id].SetMarca(textMarca.Text);
                car[id].SetAno(int.Parse(textAno.Text));
                car[id].SetKilometragem(double.Parse(textKm.Text));
                car[id].SetCapacidade(double.Parse(textCapacidade.Text));
                car[id].SetPotencia(double.Parse(textPotencia.Text));
                id++;
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
            int n = 0;

            while (n < car.Count && continuarBusca == true)
                {
                    if (car[n].GetPlaca() == textBuscar.Text)
                    {
                        continuarBusca = false;
                        MessageBox.Show("Há um carro cadastrado com a placa " + textBuscar.Text + "." + "\r\nModelo:"
                            + car[n].GetModelo() + "\r\nPlaca:" + car[n].GetPlaca() + "\r\nMarca:" + car[n].GetMarca() 
                            + "\r\nAno:" + car[n].GetAno() + "\r\nKilometragem:" + car[n].GetKilometragem() + "\r\nCapacidade do tanque:" 
                            + car[n].GetCapacidade() + "\r\nPotência:" + car[n].GetPotencia(), "Busca Concluída");
                    }

                    else
                    {
                        n++;
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

