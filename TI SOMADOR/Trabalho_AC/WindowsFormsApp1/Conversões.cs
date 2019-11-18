using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    class Conversões
    {
        public static bool[] Vetor_Booleano(string binario)
        {
            bool[] retorno;
            char[] aux = binario.ToCharArray();
            Console.WriteLine(binario);
            retorno = new bool[binario.Length];
            for (int i = 0; i < binario.Length; i++)
            {
                if (aux[i] == '1')
                {
                    retorno[i] = true;
                }
                else
                {
                    retorno[i] = false;
                }
            }
            return retorno;
        }
        public static string Expoente(string valor_soma)
        {
            string retorno = "";
            int cont = 0;
            string pre_exp = "";
            char[] expoente = valor_soma.ToCharArray();
            for (int i = 1; i < expoente.Length; i++)
            {
                cont++;
            }
            pre_exp = (127 + cont).ToString();
            retorno = Decimal_Binario.DecimalParaBinario(pre_exp);
            return retorno;
        }
        public static string Mantissa(string Valor_Soma)
        {
            string retorno = "";
            int cont = 0;
            char[] mantissa = new char[24];
            char[] pre_mantissa = Valor_Soma.ToCharArray();
            for (int i = 1; i < pre_mantissa.Length; i++)
            {
                mantissa[i-1] = pre_mantissa[i];
                cont++;
            }
            for (int a = cont; a < mantissa.Length; a++)
            {
                mantissa[a] = '0';
            }
            retorno = new string(mantissa);
            return retorno;
        }
        public static string BinarioParaHexa(string binario)
        {
            string[] tabela = { "0000", "0001", "0010", "0011", "0100", "0101", "0110", "0111", "1000", "1001", "1010", "1011", "1100", "1101", "1110", "1111" };
            string[] valor = { "0", "1", "2", "3", "4", "5", "6", "7", "8", "9", "A", "B", "C", "D", "E", "F" };
            string[] resultado = new string[8];
            string[] aux = new string[8];
            string sinal;
            int a = 0;

            // separar sinal
            if (binario[0] == '0') { sinal = "0"; }
            else { sinal = "1"; }

            // remover sinal do IEEE754 e acrescentar zero a esquerda para a conversão
            binario = "0" + binario.Substring(1, 31);

            // separar string do binario em grupos de 4 bits
            for (int i = 7; i >= 0; i--)
            {
                aux[i] = binario.Substring((28 - a), 4);
                a = a + 4;
            }

            // comparar grupos de 4 bits com a tabela
            for (int i = 0; i < aux.Length; i++)
            {
                for (int j = 0; j < tabela.Length; j++)
                {
                    if (aux[i] == tabela[j])
                    {
                        resultado[i] = valor[j];
                    }
                }
            }

            return sinal + "x" + string.Join("", resultado);
        }
        public static string Andar(string binario, int deslocar)
        {
            if (deslocar >= 0)
            {
                binario = "1" + binario;

                string binarioAlinhado = binario.PadLeft(24 + deslocar, '0');

                return binarioAlinhado.Substring(0, 24);
            }
            else
            {
                deslocar = (deslocar * -1);

                string binarioAlinhado = binario.PadRight(25 + deslocar, '0');

                return binarioAlinhado.Substring(1, 25);
            }
        }
        public static string Colocar1(string binario)
        {
            binario = "1" + binario;

            binario = binario.PadRight(24, '0');

            return binario.Substring(0, 24);
        }

        public static string Bool_Binario_string(bool[] binario)
        {
            char[] binarioChar = new char[binario.Length];

            for (int i = 0; i < binario.Length; i++)
            {
                if (binario[i] == true)
                {
                    binarioChar[i] = '1';
                }
                else
                {
                    binarioChar[i] = '0';
                }
            }
            return new string(binarioChar);
        }

        public static string Retirar_1(string binario)
        {
            binario = binario.Remove(0, 1);

            binario = binario.PadRight(23, '0');

            return binario.Substring(0, 23);
        }

        public static string Arr_bin(string binario)
        {

            if ((binario[binario.Length - 1] == '1') && (binario[binario.Length - 2] == '1'))
            {
                bool[] Binario = Conversões.Vetor_Booleano(binario);
                bool[] arredondar = new bool[24];
                bool overflow = false;

                arredondar[22] = true;
                Somador32Bit somador = new Somador32Bit();
                bool[] resultado = somador.Somador(Binario, arredondar, ref overflow);
                return Conversões.Bool_Binario_string(resultado).Substring(0, 23);
            }

            return binario.Substring(0, 23);
        }

        public static string Converter_24bits(string valor)
        {
            char[] valor24 = new char[24];
            char[] valor_antes = valor.ToCharArray();
            int valor24t = valor24.Length;
            int tamanho = valor_antes.Length;
            string retorno;
            for (int i = 0; i < valor24.Length; i++)
            {
                valor24[i] = '0';
            }
            for (int i = valor_antes.Length; i > 0; i--)
            {
                valor24[valor24t - 1] = valor[i - 1];
                valor24t--;
                tamanho--;
            }
            retorno = new string(valor24);
            return retorno;
        }
        public static bool[] Numero_zero()
        {
            bool[] retorno = new bool[24];
            for(int i = 0; i<retorno.Length; i++)
            {
                retorno[i] = false;
            }
            return retorno;
        }
    }
}
