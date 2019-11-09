using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        string retorno1, retorno2, resultado_soma;
        bool S;
        bool[] vetorA = new bool[24];
        bool[] vetorB = new bool[24];
        bool[] vetorS = new bool[24];
        bool[] F = new bool[3];
        string resultado = "";


        ALU_Total AT = new ALU_Total();

        ConversaoDecimal[] conversao;
        ConversaoDecimal[] conversao2;
        int contContas;
        double numeroA, numeroB;


        public Form1()
        {
            conversao = new ConversaoDecimal[1000];
            conversao2 = new ConversaoDecimal[1000];
            contContas = 0;
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            button4.Enabled = false;
            button5.Enabled = false;
        }

        private void btnEntrada_Click(object sender, EventArgs e)
        {
            contContas++;
            int array = textBox1.Text.Length;
            int array2 = textBox2.Text.Length;
            double num1, num2;

            if (array != 0 && array2 != 0)
            {

                num1 = Convert.ToDouble(textBox1.Text);
                num2 = Convert.ToDouble(textBox2.Text);
                numeroA = num1;
                numeroB = num2;
                conversao[contContas] = new ConversaoDecimal(num1,num2);
                conversao[contContas].TransformarEmIEEESemIgualarCasas();
                btnListar_Click(null, null);
                button4.Enabled = true;
                button5.Enabled = true;
                listBox14.Items.Clear();
                //NOSSO CÓDIGO
                string valorBinario2 = Decimal_Binario.DecimalParaBinario(num1.ToString());
                retorno2 = Decimal_Binario.Converter_32bits(valorBinario2);
                lst_num2binario.Items.Clear();
                lst_num2binario.Items.Add(retorno2);
                string valorBinario1 = Decimal_Binario.DecimalParaBinario(num2.ToString());
                retorno1 = Decimal_Binario.Converter_32bits(valorBinario1);
                lst_num1binario.Items.Clear();
                lst_num1binario.Items.Add(retorno1);
                
            }
            else
            {

                MessageBox.Show("Digite algum numero!");
            }            
        }

        private void btnListar2_Click(object sender, EventArgs e)
        {
            listBox0.Items.Clear();
            listBox14.Items.Clear();
            listBox14.Items.Add(conversao[contContas].MantissaResposta);
            
                for (int j = 0; j < vetorA.Length; j++)
                {
                    listBox0.Items.Add(vetorB[j]);
                }
            

        }

        private void btnListar_Click(object sender, EventArgs e)
        {
            string num1 = textBox1.Text;
            string num2 = textBox2.Text;
            textBox1.Clear();
            textBox1.Focus();
            textBox2.Clear();
            textBox2.Focus();
            listBox0.Items.Clear();           
                            
            // listBox0.Items.Add("| Decimal: " + conversao[i]._numeroDecimal + " | Binario: " + conversao[i]._numeroConvertidoBinario + " | Hexadecimal: " + conversao[i]._numeroConvertidoHexadecimal + " |");
                listBox1.Items.Clear();
                listBox1.Items.Add(conversao[contContas].Mantissa);

                listBox2.Items.Clear();
                listBox2.Items.Add(conversao[contContas].Expoente);

                listBox3.Items.Clear();
                listBox3.Items.Add(conversao[contContas].Sinal);

                listBox4.Items.Clear();
                listBox4.Items.Add(conversao[contContas].numeroHexadecimal);

                listBox7.Items.Clear();
                listBox7.Items.Add(conversao[contContas].Mantissa2);

                listBox6.Items.Clear();
                listBox6.Items.Add(conversao[contContas].Expoente2);

                listBox5.Items.Clear();
                listBox5.Items.Add(conversao[contContas].Sinal2);

                listBox8.Items.Clear();
                listBox8.Items.Add(conversao[contContas].numeroHexadecimal2);

                listBox9.Items.Clear();
                listBox9.Items.Add(num2);

                listBox10.Items.Clear();
                listBox10.Items.Add(num1);

                listBox13.Items.Clear();
                listBox13.Items.Add(conversao[contContas].ExpoenteResposta);
            

        }

        private void lbCarros_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listBox3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {


        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void listBox7_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            /*F[2] = true; F[1] = false; F[0] = true;
            for (int i = 0; i < vetorA.Length; i++)
            {
                vetorA[i] = conversao[contContas].numeroVetorBoleano[i];
            }
            for (int i = 0; i < vetorA.Length; i++)
            {
                vetorB[i] = conversao[contContas].numero2VetorBoleano[i];
            }

            S = AT.Ativa(vetorA, vetorB, F, vetorS);
            for (int i = 0; i < vetorS.Length; i++)
            {
                if (vetorS[i] == true)
                {
                    resultado = resultado + "1";
                }
                else
                {
                    resultado = resultado + "0";
                }
            }
            conversao[contContas].MantissaResposta = resultado;
            btnListar2_Click(null, null);*/
            resultado_soma = Soma.Somar(retorno1, retorno2);
            lst_resultadosoma.Items.Clear();
            lst_resultadosoma.Items.Add(resultado_soma);
            lst_resutadosomadecimal.Items.Clear();
            double print_resultado = numeroA + numeroB;
            if(print_resultado >= 0)
            {
                lst_resultadosinal.Items.Clear();
                lst_resultadosinal.Items.Add(0);
            }
            else
            {
                lst_resultadosinal.Items.Clear();
                lst_resultadosinal.Items.Add(1);
            }
            lst_resutadosomadecimal.Items.Add(print_resultado);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            /*F[2] = true; F[1] = true; F[0] = false;

            for (int i = 0; i < vetorA.Length; i++)
            {
              vetorA[i] = conversao[contContas].numeroVetorBoleano[i];
            }
            for (int i = 0; i < vetorA.Length; i++)
            {
               vetorB[i] = conversao[contContas].numero2VetorBoleano[i];
            }

            S = AT.Ativa(vetorA, vetorB, F, vetorS);
            for (int i = 0; i < vetorS.Length; i++)
            {
                if (vetorS[i] == true)
                {
                    resultado = resultado + "1";
                }
                else
                {
                    resultado = resultado + "0";
                }
            }
            conversao[contContas].MantissaResposta = resultado;
            btnListar2_Click(null, null);*/
            MessageBox.Show("Opção não implementada", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {

        }

        private void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '.')
            {
                e.KeyChar = ',';
            }
            else if (!char.IsNumber(e.KeyChar) && !(e.KeyChar == (char)Keys.Back) && !(e.KeyChar == ',') && !(e.KeyChar == '-'))
            {
                e.Handled = true;
            }
        }

        private void listBox13_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listBox10_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listBox9_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listBox5_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listBox8_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Deseja fechar o programa?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2) == DialogResult.No)
            {
                e.Cancel = true;
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void lblResposta_Click(object sender, EventArgs e)
        {
            
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '.')
            {
                e.KeyChar = ',';
            }
            else if (!char.IsNumber(e.KeyChar) && !(e.KeyChar == (char)Keys.Back) && !(e.KeyChar == ',') && !(e.KeyChar == '-'))
            {
                e.Handled = true;
            }
        }
    }
}
