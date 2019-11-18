using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    class Decimal_Binario
    {

        public static string InverterString(string str)
        {
            int tamanho = str.Length;

            char[] caracteres = new char[tamanho];

            for (int i = 0; i < tamanho; i++)
            {
                caracteres[i] = str[tamanho - 1 - i];
            }

            return new string(caracteres);
        }
        public static string DecimalParaBinario(string numero)
        {
            string valor = "";

            int dividendo = Convert.ToInt32(numero);

            if (dividendo == 0 || dividendo == 1)
            {

                return Convert.ToString(dividendo);

            }

            else
            {

                while (dividendo > 0)
                {

                    valor += Convert.ToString(dividendo % 2);

                    dividendo = dividendo / 2;

                }

                return InverterString(valor);

            }

        }

        public static int BinarioParaDecimal(string valorBinario)
        {

            int expoente = 0;

            int numero;

            int soma = 0;

            string numeroInvertido = InverterString(valorBinario);

            for (int i = 0; i < numeroInvertido.Length; i++)
            {

                //pega dígito por dígito do número digitado

                numero = Convert.ToInt32(numeroInvertido.Substring(i, 1));

                //multiplica o dígito por 2 elevado ao expoente, e armazena o resultado em soma

                soma += numero * (int)Math.Pow(2, expoente);

                // incrementa o expoente

                expoente++;

            }

            return soma;

        }

        public static string Converter_24bits(string valor)
        {
            char[] valor32 = new char[24];
            char[] valor_antes = valor.ToCharArray();
            int valor32t = valor32.Length;
            int tamanho = valor_antes.Length;
            string retorno;
            for(int i = 0; i<valor32.Length; i++)
            {
                valor32[i] = '0';
            }
            for(int i = valor_antes.Length; i>0; i--)
            {
                valor32[valor32t-1] = valor[i-1];
                valor32t--;
                tamanho--;
            }
            retorno = new string(valor32);
            return retorno;
        }

        public static string Fracionario_binario(double resposta)
        {
            int cont = 0;           
            string binario = "";
            double resto = resposta % 1;
            Console.WriteLine(resto);
            bool parar = false;
            while (parar == false && cont < 5)
            {
                resposta = resto * 2;
                resto = resposta % 1;
                if (resto == 0)
                {
                    binario = binario + 1;
                    parar = true;
                }
                else
                {
                    binario = binario + (Convert.ToInt32(Math.Floor(resposta)));
                }
                cont++;
            }
            return binario;
        }
    }
}
