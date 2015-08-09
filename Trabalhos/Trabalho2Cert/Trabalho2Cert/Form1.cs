using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Trabalho2Cert
{
    public partial class Form1 : Form
    {
        List<Carro> carro = new List<Carro>();
        bool quantidadeCadastrada = false;
        int quantidadeCarros = 0;
        int idCadastro = 1;
        bool todosCarrosLotados = false;
        int carrosLotados = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void buttonCadastrarQuant_Click(object sender, EventArgs e)
        {
            if (quantidadeCadastrada == false)
            {
                try
                {
                    quantidadeCarros = int.Parse(textQuantidade.Text);
                    carro.Add(new Carro());
                    quantidadeCadastrada = true;
                    int[] vagas = new int[quantidadeCarros + 1];
                }

                catch (Exception)
                {
                    MessageBox.Show("Quantidade de carros já cadastrada.", "Quantidade de carros já cadastrada");
                }
            }


            else
                MessageBox.Show("Quantidade de carros já cadastrada.", "Quantidade de carros já cadastrada");

            textQuantidade.Clear();
        }

        private void buttonCadastrarCar_Click(object sender, EventArgs e)
        {
            try
            {
                if (quantidadeCadastrada && idCadastro <= quantidadeCarros)
                {
                    carro.Add(new Carro());
                    carro[idCadastro].Id = idCadastro;
                    carro[idCadastro].Modelo = textModelo.Text;
                    carro[idCadastro].Marca = textMarca.Text;
                    carro[idCadastro].Placa = textPlaca.Text;
                    carro[idCadastro].CapacidadePassageiros = int.Parse(textCapacidade.Text);
                    carro[idCadastro].Passageiros = 0;
                    carro[idCadastro].Vagas = carro[idCadastro].CapacidadePassageiros;

                    idCadastro++;
                }

                else
                    MessageBox.Show("Por favor cadastre a quantidade de carros ou preencha todos os campos. Caso todos os carro já foram cadastrados, não é possível cadastrar mais um."
                        , "Não foi possível cadastrar o carro");
            }
            catch (Exception)
            {
                MessageBox.Show("Por favor cadastre a quantidade de carros ou preencha todos os campos. Caso todos os carro já foram cadastrados, não é possível cadastrar mais um."
                    , "Não foi possível cadastrar o carro");
            }

            finally
            {
                textModelo.Clear();
                textMarca.Clear();
                textPlaca.Clear();
                textCapacidade.Clear();
            }
        }

        private void buttonPedir_Click(object sender, EventArgs e)
        {
            try
            {
                int id = int.Parse(textPedido.Text);

                if (id <= quantidadeCarros && id >= 1)
                {
                    if (todosCarrosLotados == false)
                    {
                        if (carro[id].Lotado != true)
                        {
                            carro[id].Vagas--;
                            carro[id].Passageiros = carro[id].CapacidadePassageiros - carro[id].Vagas;

                            if (carro[id].Passageiros == carro[id].CapacidadePassageiros)
                            {
                                carro[id].Lotado = true;
                                MessageBox.Show("Não há vagas restantes", "Não há vagas restantes");

                                carrosLotados = 0;

                                for (int i = 1; i <= quantidadeCarros; i++)
                                {
                                    if (carro[i].Lotado == true)
                                        carrosLotados++;
                                }

                                if (carrosLotados == quantidadeCarros)
                                    todosCarrosLotados = true;
                            }

                            else
                            {
                                MessageBox.Show("Há " + (carro[id].CapacidadePassageiros - carro[id].Passageiros) + " vaga(s) restante(s)",
                                    "Há " + (carro[id].CapacidadePassageiros - carro[id].Passageiros) + " vaga(s) restante(s)");
                            }
                        }

                        else
                        {
                            MessageBox.Show("Carro lotado", "Carro lotado");
                        }

                    }

                    else
                    {
                        carrosLotados = 0;

                        for (int i = 1; i <= quantidadeCarros; i++)
                        {
                            if (carro[i].Lotado == true)
                                carrosLotados++;
                        }

                        if (carrosLotados == quantidadeCarros)
                            todosCarrosLotados = true;

                        if (todosCarrosLotados || id == -1 || carro[id].Lotado)
                        {
                            textResposta.Clear();

                            for (int i = 1; i <= quantidadeCarros; i++)
                            {
                                textResposta.Text += "Carro " + carro[i].Id + ": " + carro[i].Modelo + " - " + carro[i].Marca + " (" + carro[i].Placa + ")";
                                textResposta.Text += "\r\nPassageiros: " + carro[i].Passageiros;
                                if (carro[i].Lotado != true)
                                    textResposta.Text += "\r\nVagas restante: " + (carro[i].CapacidadePassageiros - carro[i].Passageiros + "\r\n\r\n");

                                else
                                    textResposta.Text += "\r\nCarro Lotado\r\n\r\n";
                            }
                        }
                    }

                }

                else if (todosCarrosLotados || id == -1 || carro[id].Vagas == 0)
                {
                    textResposta.Clear();

                    for (int i = 1; i <= quantidadeCarros; i++)
                    {
                        textResposta.Text += "Carro " + carro[i].Id + ": " + carro[i].Modelo + " - " + carro[i].Marca + " (" + carro[i].Placa + ")";
                        textResposta.Text += "\r\nPassageiros: " + carro[i].Passageiros;
                        if (carro[i].Lotado != true)
                            textResposta.Text += "\r\nVagas restante: " + (carro[i].CapacidadePassageiros - carro[i].Passageiros + "\r\n\r\n");

                        else
                            textResposta.Text += "\r\nCarro Lotado\r\n\r\n";
                    }
                }
            }

            catch (Exception)
            {
                MessageBox.Show("Carro Inválido.", "Erro ao tentar fazer pedido de vaga");
            }

            finally
            {
                textPedido.Clear();
            }
        }

        private void buttonLimpar_Click(object sender, EventArgs e)
        {
            textQuantidade.Clear();
            textModelo.Clear();
            textMarca.Clear();
            textPlaca.Clear();
            textCapacidade.Clear();
            textPedido.Clear();
            textResposta.Clear();
        }

        private void buttonReset_Click(object sender, EventArgs e)
        {
            textQuantidade.Clear();
            textModelo.Clear();
            textMarca.Clear();
            textPlaca.Clear();
            textCapacidade.Clear();
            textPedido.Clear();
            textResposta.Clear();

            quantidadeCadastrada = false;
            quantidadeCarros = 0;
            idCadastro = 1;
            todosCarrosLotados = false;
            carrosLotados = 0;

            carro.Clear();
        }

    }
}
