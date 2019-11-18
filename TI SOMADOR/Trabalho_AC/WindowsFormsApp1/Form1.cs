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
        string valorBinario1, valorBinario1_32, mantissa1, expoente1, parte_fracionaria1, sinal1, Hexa_1, mantissa_A_igualada;
        string valorBinario2_32, valorBinario2, mantissa2, parte_fracionaria2, expoente2, sinal2, Hexa_2, mantissa_B_igualada;
        bool S;
        bool[] vetorA = new bool[24];
        bool[] vetorB = new bool[24];
        bool[] vetorS = new bool[24];
        bool[] F = new bool[3];
        bool[] resultados_mantissas;
        string mantissa_soma = "";
        string resultado = "", resultado_hexa;
        string IEEE_final, sinal_final = "0";
        double multiplicador;
        double multiplicando;

        private void btn_multiplicar_Click(object sender, EventArgs e)
        {
            string mantissa_multiplicando = "";
            bool erro = false;
            if (num1 %1 != 0 && num2 %1 != 0)
            {
                MessageBox.Show("Para multiplicar um dos dois fatores precisa ser inteiro", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                erro = true;
            }
            else if(num1 %1 != 0)
            {
                multiplicando = num1;
                multiplicador = num2;
                mantissa_multiplicando = mantissa1;               
            }
            else if(num2 %1 != 0)
            {
                multiplicando = num2;
                multiplicador = num1;
                mantissa_multiplicando = mantissa2;
            }
            else
            {
                if (num1 < num2)
                {
                    multiplicador = num1;
                    multiplicando = num2;
                    mantissa_multiplicando = mantissa2;
                }
                else if(num2 < num1)
                {
                    multiplicador = num2;
                    multiplicando = num1;
                    mantissa_multiplicando = mantissa1;
                }
                else
                {
                    multiplicador = num1;
                    multiplicando = num2;
                    mantissa_multiplicando = mantissa2;
                }
            }

            if(erro == false)
            {
                Somador32Bit somador32 = new Somador32Bit();
                double num1_csinal = double.Parse(txt_num1.Text);
                double num2_csinal = double.Parse(txt_num2.Text);
                double resultado_decimal = num1 * num2;
                string sinal_final = "";
                if(num1_csinal < 0 && num2_csinal < 0)
                {
                    sinal_final = "0";
                }
                else if(num1_csinal < 0 || num2_csinal < 0)
                {
                    sinal_final = "1";
                }
                else
                {
                    sinal_final = "0";
                }
                string expoenteFinal = Decimal_Binario.DecimalParaBinario((numeroA * numeroB).ToString());
                expoenteFinal = Conversões.Expoente(expoenteFinal);
                bool overflow = false;                
                string mantissa_multiplicando_1 = Conversões.Colocar1(mantissa_multiplicando);
                bool[] multiplicando_vet_bool = Conversões.Vetor_Booleano(mantissa_multiplicando_1);
                bool[] zero_bool = Conversões.Numero_zero();
                bool[] resultado = multiplicando_vet_bool;
                for (int i=0; i<multiplicador; i++)
                {
                    resultado = somador32.Somador(resultado, zero_bool, ref overflow);
                }
                string resultado_binario = Conversões.Bool_Binario_string(resultado);
                resultado_binario = Conversões.Retirar_1(resultado_binario);
                //string mantissa_resultado = Conversões.Mantissa(resultado_binario);
                string mantissa_resultado = resultado_binario;
                IEEE_final = sinal_final + expoenteFinal + mantissa_resultado;
                resultado_hexa = Conversões.BinarioParaHexa(IEEE_final);
                lst_resultadosinal.Items.Clear();
                lst_resultadoexpoente.Items.Clear();
                lst_resultadoMantissa.Items.Clear();
                lst_resultadoHexa.Items.Clear();
                lst_resutadosomadecimal.Items.Clear();
                lst_resultadosinal.Items.Add(sinal_final);
                lst_resultadoexpoente.Items.Add(expoenteFinal);
                lst_resultadoMantissa.Items.Add(mantissa_resultado);
                lst_resutadosomadecimal.Items.Add(resultado_decimal);
                lst_resultadoHexa.Items.Add(resultado_hexa);
            }
            else
            {
                MessageBox.Show("Operação não executada", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        int expoente_simplificado_1, num_A_negativo;
        int expoente_simplificado_2, num_B_negativo;
        double num1, num2, resultado_decimal;


        private void btn_soma_Click(object sender, EventArgs e)
        {
            //SEPARAR DECIMAL E FRACIONARIO QUANDO CONVERTER PARA BINARIO

            Somador32Bit somador32 = new Somador32Bit();            
            bool overflow = false;
            string expoenteFinal = Decimal_Binario.DecimalParaBinario((numeroA + numeroB).ToString());
            vetorA = Conversões.Vetor_Booleano(valorBinario1_32);
            vetorB = Conversões.Vetor_Booleano(valorBinario2_32);
            expoente_simplificado_1 = Decimal_Binario.BinarioParaDecimal(expoente1) - 127;
            expoente_simplificado_2 = Decimal_Binario.BinarioParaDecimal(expoente2) - 127;
            int andar;           
            if (expoente_simplificado_1 < expoente_simplificado_2)
            {
                expoenteFinal = Conversões.Expoente(expoenteFinal);
                andar = (expoente_simplificado_2 - expoente_simplificado_1) + 1;
                mantissa_A_igualada = Conversões.Andar(mantissa1, andar);
                mantissa_B_igualada = Conversões.Colocar1(mantissa2);
            }
            else if (expoente_simplificado_1 > expoente_simplificado_2)
            {
                expoenteFinal = Conversões.Expoente(expoenteFinal);
                andar = Math.Abs(expoente_simplificado_1 - expoente_simplificado_2) + 1;
                mantissa_B_igualada = Conversões.Andar(mantissa2, andar);
                mantissa_A_igualada = Conversões.Colocar1(mantissa1);
            }
            else if (expoente_simplificado_1 == expoente_simplificado_2)
            {
                expoenteFinal = Conversões.Expoente(expoenteFinal);
                andar = Math.Abs(expoente_simplificado_2 - expoente_simplificado_1);
                mantissa_B_igualada = Conversões.Andar(mantissa2, andar);
                mantissa_A_igualada = Conversões.Colocar1(mantissa1);
            }
            resultado_decimal = num1 + num2;
            vetorA = Conversões.Vetor_Booleano(mantissa_A_igualada);
            vetorB = Conversões.Vetor_Booleano(mantissa_B_igualada);
            resultados_mantissas = somador32.Somador(vetorA, vetorB, ref overflow);
            mantissa_soma = Conversões.Bool_Binario_string(resultados_mantissas);
            mantissa_soma = Conversões.Retirar_1(mantissa_soma);
            mantissa_soma = Conversões.Arr_bin(mantissa_soma);
            IEEE_final = sinal_final + expoenteFinal + mantissa_soma;
            resultado_hexa = Conversões.BinarioParaHexa(IEEE_final);
            lst_resultadosinal.Items.Clear();
            lst_resultadoexpoente.Items.Clear();
            lst_resultadoMantissa.Items.Clear();
            lst_resultadoHexa.Items.Clear();
            lst_resutadosomadecimal.Items.Clear();
            lst_resultadosinal.Items.Add(sinal_final);
            lst_resultadoexpoente.Items.Add(expoenteFinal);
            lst_resultadoMantissa.Items.Add(mantissa_soma);
            lst_resutadosomadecimal.Items.Add(resultado_decimal);
            lst_resultadoHexa.Items.Add(resultado_hexa);
        }

       
        int numeroA, numeroB;
        bool[] A = new bool[32];
        bool[] B = new bool[32];

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            button4.Enabled = false;
            btn_soma.Enabled = false;
        }


        private void btnEntrada_Click(object sender, EventArgs e)
        {            
            int array = txt_num2.Text.Length;
            int array2 = txt_num1.Text.Length;            

            if (array != 0 && array2 != 0)
            {               
                num2 = Convert.ToDouble(txt_num2.Text);
                num1 = Convert.ToDouble(txt_num1.Text);
                if (num1 > 0) sinal1 = "0";
                else {
                    sinal1 = "1";
                    num1 = num1 * -1;

                }
                if (num2 > 0) sinal2 = "0";
                else {
                    sinal2 = "1";
                    num2 = num2 * -1;
                } 
                numeroA = Convert.ToInt32(Math.Floor(num1));
                numeroB = Convert.ToInt32(Math.Floor(num2));          
                button4.Enabled = true;
                btn_soma.Enabled = true;                
                //NOSSO CÓDIGO
                string valorBinario2_inteiro = Decimal_Binario.DecimalParaBinario(numeroB.ToString());                
                string valorBinario1_inteiro = Decimal_Binario.DecimalParaBinario(numeroA.ToString());                
                if (num1 % 1 == 0 && num2 % 1 == 0)
                {
                    mantissa1 = Conversões.Mantissa(valorBinario1_inteiro);
                    mantissa2 = Conversões.Mantissa(valorBinario2_inteiro);
                    expoente1 = Conversões.Expoente(valorBinario1_inteiro);
                    expoente2 = Conversões.Expoente(valorBinario2_inteiro);
                    valorBinario1_32 = sinal1 + expoente1 + mantissa1;
                    valorBinario2_32 = sinal2 + expoente2 + mantissa2;
                    Hexa_1 = Conversões.BinarioParaHexa(valorBinario1_32);
                    Hexa_2 = Conversões.BinarioParaHexa(valorBinario2_32);
                    lst_sinal1.Items.Clear();
                    lst_sinal2.Items.Clear();
                    lst_expoente1.Items.Clear();
                    lst_expoente2.Items.Clear();                                        
                    lst_mantissa1.Items.Clear();                    
                    lst_mantissa2.Items.Clear();
                    lst_hexa1.Items.Clear();
                    lst_hexa2.Items.Clear();
                    lst_num2binario.Items.Clear();
                    lst_num1binario.Items.Clear();
                    lst_num1.Items.Clear();
                    lst_num2.Items.Clear();
                    lst_sinal1.Items.Add(sinal1);
                    lst_sinal2.Items.Add(sinal2);
                    lst_expoente1.Items.Add(expoente1);
                    lst_expoente2.Items.Add(expoente2);
                    lst_mantissa1.Items.Add(mantissa1);
                    lst_mantissa2.Items.Add(mantissa2);
                    lst_hexa1.Items.Add(Hexa_1);
                    lst_hexa2.Items.Add(Hexa_2);
                    lst_num2binario.Items.Add(valorBinario2_inteiro);
                    lst_num1binario.Items.Add(valorBinario1_inteiro);
                    lst_num1.Items.Add(num1);
                    lst_num2.Items.Add(num2);
                    valorBinario1 = valorBinario1_inteiro;
                    valorBinario2 = valorBinario2_inteiro;
                }
                else
                {
                    if(num1 % 1 != 0 && num2 % 1 != 0)
                    {
                        parte_fracionaria1 = Decimal_Binario.Fracionario_binario(num1);
                        valorBinario1 = valorBinario1_inteiro + parte_fracionaria1;
                        parte_fracionaria2 = Decimal_Binario.Fracionario_binario(num2);
                        valorBinario2 = valorBinario2_inteiro + parte_fracionaria2;                        
                    }
                    else if(num1 % 1 != 0)
                    {
                        parte_fracionaria1 = Decimal_Binario.Fracionario_binario(num1);
                        valorBinario1 = valorBinario1_inteiro + parte_fracionaria1;
                        valorBinario2 = valorBinario2_inteiro;
                    }
                    else if(num2 % 1 != 0)
                    {
                        parte_fracionaria2 = Decimal_Binario.Fracionario_binario(num2);
                        valorBinario2 = valorBinario2_inteiro + parte_fracionaria2;
                        valorBinario1 = valorBinario1_inteiro;
                    }
                    mantissa1 = Conversões.Mantissa(valorBinario1);
                    mantissa2 = Conversões.Mantissa(valorBinario2);
                    expoente1 = Conversões.Expoente(valorBinario1_inteiro);
                    expoente2 = Conversões.Expoente(valorBinario2_inteiro);
                    lst_num1.Items.Clear();
                    lst_num2.Items.Clear();
                    lst_sinal1.Items.Clear();
                    lst_sinal2.Items.Clear();
                    lst_expoente1.Items.Clear();
                    lst_expoente2.Items.Clear();
                    lst_mantissa1.Items.Clear();
                    lst_mantissa2.Items.Clear();
                    lst_num2binario.Items.Clear();
                    lst_num1binario.Items.Clear();
                    lst_hexa1.Items.Clear();
                    lst_hexa2.Items.Clear();
                    lst_num1.Items.Add(num1);
                    lst_num2.Items.Add(num2);
                    lst_sinal1.Items.Add(sinal1);
                    lst_sinal2.Items.Add(sinal2);
                    lst_expoente1.Items.Add(expoente1);
                    lst_expoente2.Items.Add(expoente2);
                    lst_mantissa1.Items.Add(mantissa1);
                    lst_mantissa2.Items.Add(mantissa2);
                    lst_num2binario.Items.Clear();
                    lst_num2binario.Items.Add(valorBinario2_inteiro + "," + parte_fracionaria2);
                    lst_num1binario.Items.Clear();
                    lst_num1binario.Items.Add(valorBinario1_inteiro + "," + parte_fracionaria1);
                    valorBinario1_32 = sinal1 + expoente1 + mantissa1;
                    valorBinario2_32 = sinal2 + expoente2 + mantissa2;
                    Hexa_1 = Conversões.BinarioParaHexa(valorBinario1_32);
                    Hexa_2 = Conversões.BinarioParaHexa(valorBinario2_32);
                    lst_hexa1.Items.Add(Hexa_1);
                    lst_hexa2.Items.Add(Hexa_2);
                }      
            }
            else
            {

                MessageBox.Show("Digite algum numero!");
            }            
        }       

        private void button4_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Opção não implementada", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

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
