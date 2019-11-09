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

        public static string Converter_32bits(string valor)
        {
            char[] valor32 = new char[32];
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

    }
}
