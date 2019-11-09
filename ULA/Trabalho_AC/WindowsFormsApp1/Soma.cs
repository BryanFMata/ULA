using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    class Soma
    {
        public static string Somar(string valor1, string valor2)
        {
            string retorno = "";
            int vem_1 = 0, vai_1 = 0;
            char[] valor_1_32bits = valor1.ToCharArray();
            char[] valor_2_32bits = valor2.ToCharArray();
            char[] resultado = new char[32];
            for(int i = resultado.Length; i>0; i--)
            {
                if(valor_1_32bits[i-1] == '0' && valor_2_32bits[i-1] == '0' && vem_1 == 0)
                {
                    resultado[i-1] = '0';
                    vai_1 = 0;
                    vem_1 = vai_1;
                }
                else if (valor_1_32bits[i-1] == '0' && valor_2_32bits[i-1] == '0' && vem_1 == 1)
                {
                    resultado[i-1] = '1';
                    vai_1 = 0;
                    vem_1 = vai_1;
                }
                else if (valor_1_32bits[i-1] == '0' && valor_2_32bits[i-1] == '1' && vem_1 == 0)
                {
                    resultado[i-1] = '1';
                    vai_1 = 0;
                    vem_1 = vai_1;
                }
                else if (valor_1_32bits[i-1] == '0' && valor_2_32bits[i-1] == '1' && vem_1 == 1)
                {
                    resultado[i-1] = '0';
                    vai_1 = 1;
                    vem_1 = vai_1;
                }
                else if (valor_1_32bits[i-1] == '1' && valor_2_32bits[i-1] == '0' && vem_1 == 0)
                {
                    resultado[i-1] = '1';
                    vai_1 = 0;
                    vem_1 = vai_1;
                }
                else if (valor_1_32bits[i-1] == '1' && valor_2_32bits[i-1] == '0' && vem_1 == 1)
                {
                    resultado[i-1] = '0';
                    vai_1 = 1;
                    vem_1 = vai_1;
                }
                else if (valor_1_32bits[i-1] == '1' && valor_2_32bits[i-1] == '1' && vem_1 == 0)
                {
                    resultado[i-1] = '0';
                    vai_1 = 1;
                    vem_1 = vai_1;
                }
                else if (valor_1_32bits[i-1] == '1' && valor_2_32bits[i-1] == '1' && vem_1 == 1)
                {
                    resultado[i-1] = '1';
                    vai_1 = 1;
                    vem_1 = vai_1;
                }
            }
            retorno = new string(resultado);
            return retorno;            
        }
    }
}
