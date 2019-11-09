using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    class ConversaoDecimal
    {
        public string SinalResposta;
        public string ExpoenteResposta;
        public string MantissaResposta;

        //Atritutos do primeiro numero!
        public int _casasAndou;
        public double numero;
        public double numeroReal;
        public string Sinal;
        public string Expoente;
        public string Mantissa;
        public string numeroHexadecimal;
        public bool[] numeroVetorBoleano = new bool[24];
        //Atritutos do segundo numero!
        public int _casasAndou2;
        public double numero2;
        public double numero2Real;
        public string Sinal2;
        public string Expoente2;
        public string Mantissa2;
        public string numeroHexadecimal2;
        public bool[] numero2VetorBoleano = new bool[24];

        //Atributo pra maior numero de casa!
        public int maior;

        /// <summary>
        /// Construto para pegar os numeros
        /// </summary>
        /// <param name="a">numero um</param>
        /// <param name="b">numero dois</param>
        public ConversaoDecimal(double a, double b)
        {
            numeroReal = a;
            numero = Math.Abs(a);
            _casasAndou = 0;
            numero2Real = b;
            numero2 = Math.Abs(b);
            _casasAndou2 = 0;
            maior = 0;
            Sinal = "";
            Expoente = "";
            Mantissa = "";
            Sinal2 = "";
            Expoente2 = "";
            Mantissa2 = "";
        }

        public void TransformarEmIEEE()
        {
            int numeroExpoente;

            TransformarNumeroComCasas();
            IgualarCasas();

            Sinal = ConversaoSinal(numeroReal);
            Sinal2 = ConversaoSinal(numero2Real);

            numeroExpoente = _casasAndou + 127;
            Expoente = ConversaoExpoente(numeroExpoente);
            Expoente2 = ConversaoExpoente(numeroExpoente);
            numeroExpoente = maior + 127;
            ExpoenteResposta = ConversaoExpoente(numeroExpoente);

            Mantissa = ConversaoMantissa(numero);
            string PassarBoleano = Mantissa;
            Mantissa2 = ConversaoMantissa(numero2);
            string PassarBoleano2 = Mantissa2;
            TransformarEmBoleanoMantissa(PassarBoleano,PassarBoleano2);

            numeroHexadecimal = TranformarEmHexadecimal(Sinal, Expoente, Mantissa);
            numeroHexadecimal2 = TranformarEmHexadecimal(Sinal2, Expoente2, Mantissa2);
        }
        public void TransformarEmIEEESemIgualarCasas()
        {
            int numeroExpoente;

            TransformarNumeroComCasas();


            Sinal = ConversaoSinal(numeroReal);
            Sinal2 = ConversaoSinal(numero2Real);

            numeroExpoente = _casasAndou + 127;
            Expoente = ConversaoExpoente(numeroExpoente);
            numeroExpoente = _casasAndou2 + 127;
            Expoente2 = ConversaoExpoente(numeroExpoente);
            numeroExpoente = maior + 127;
            ExpoenteResposta = ConversaoExpoente(numeroExpoente);

            Mantissa = ConversaoMantissa(numero);
            string PassarBoleano = Mantissa;
            Mantissa2 = ConversaoMantissa(numero2);
            string PassarBoleano2 = Mantissa2;
            TransformarEmBoleanoMantissa(PassarBoleano, PassarBoleano2);

            numeroHexadecimal = TranformarEmHexadecimal(Sinal, Expoente, Mantissa);
            numeroHexadecimal2 = TranformarEmHexadecimal(Sinal2, Expoente2, Mantissa2);
        }

        private void TransformarNumeroComCasas()
        {
            if (numero >= 2)
            {
                while (numero >= 2)
                {
                    numero = numero / 2;
                    _casasAndou++;
                }

            }
            else if (numero < 1)
            {
                while (numero < 1)
                {
                    numero = numero * 2;
                    _casasAndou--;
                }
            }
            if (numero2 >= 2)
            {
                while (numero2 >= 2)
                {
                    numero2 = numero2 / 2;
                    _casasAndou2++;
                }
            }
            else if (numero2 < 1)
            {
                while (numero2 < 1)
                {
                    numero2 = numero2 * 2;
                    _casasAndou2--;
                }
            }

        }
        private void IgualarCasas()
        {
            if (_casasAndou > _casasAndou2)
            {
                maior = _casasAndou;
                while (_casasAndou != _casasAndou2)
                {
                    numero2 = numero2 / 10;
                    _casasAndou2++;
                }


            }
            else if (_casasAndou < _casasAndou2)
            {
                maior = _casasAndou2;
                while (_casasAndou != _casasAndou2)
                {
                    numero = numero / 10;
                    _casasAndou++;
                }


            }
            else
            {
                maior = _casasAndou + 1;
            }


        }

        private string ConversaoExpoente(int a)
        {
            string _numeroConvertidoBinario = "";
            int x = a;
            int binario;
            if (x == 0)
            {
                _numeroConvertidoBinario = "0";
            }
            else if (x == 1)
            {
                _numeroConvertidoBinario = "1";
            }
            else
            {
                while (x > 1)
                {
                    if (x < 5)
                    {
                        binario = x % 2;

                        if (binario == 0)
                        {
                            if (x == 4)
                            {
                                x = x / 4;
                                _numeroConvertidoBinario = x + "0" + "0" + _numeroConvertidoBinario;
                            }
                            if (x == 2)
                            {
                                x = x / 2;
                                _numeroConvertidoBinario = x + "0" + _numeroConvertidoBinario;
                            }

                        }
                        if (binario == 1)
                        {
                            x = x / 2;
                            _numeroConvertidoBinario = x + "1" + _numeroConvertidoBinario;
                        }
                    }
                    else
                    {
                        binario = x % 2;
                        x = x / 2;
                        _numeroConvertidoBinario = binario + _numeroConvertidoBinario;

                    }
                }
            }
            if (_numeroConvertidoBinario.Length == 7)
            {
                _numeroConvertidoBinario = "0" + _numeroConvertidoBinario;
            }
            return _numeroConvertidoBinario;
        }
        private string ConversaoMantissa(double a)
        {
            string _numeroConvertidoBinario = "";
            double x2 = a;
            int contador = 0;
            do
            {
                if (x2 >= 1)
                {
                    _numeroConvertidoBinario = _numeroConvertidoBinario + "1";
                    contador++;
                    x2 = x2 - 1;
                    x2 = 2 * x2;
                }
                else
                {
                    x2 = 2 * x2;
                    _numeroConvertidoBinario = _numeroConvertidoBinario + "0";
                    contador++;
                }
            } while (contador == 1 || contador == 2 || contador == 3 || contador == 4 || contador == 5 || contador == 6 || contador == 7 ||
                contador == 8 || contador == 9 || contador == 10 || contador == 11 || contador == 12 || contador == 13 || contador == 14 ||
                contador == 15 || contador == 16 || contador == 17 || contador == 18 || contador == 19 || contador == 20 || contador == 21 ||
                contador == 22 || contador == 23);

            StringBuilder _tirarOPrimeiroDaString = new StringBuilder(_numeroConvertidoBinario);

            _tirarOPrimeiroDaString.Remove(0, 1);

            _numeroConvertidoBinario = _tirarOPrimeiroDaString.ToString();

            return _numeroConvertidoBinario;
        }
        private string ConversaoSinal(double a)
        {
            string _numeroConvertidoBinario = "";
            if (a >= 0)
            {
                _numeroConvertidoBinario = "0";
            }
            else
            {
                _numeroConvertidoBinario = "1";
            }
            return _numeroConvertidoBinario;
        }
        private string TranformarEmHexadecimal(string a, string b, string c)
        {
            string _numeroConvertidoHexadecimal = a + b + c;
            string _numeroConvertidoIEEE754EmHexadecimal = "0x";
            for (int i = 0; i < 32; i = i + 4)
            {
                if (_numeroConvertidoHexadecimal[i] == '0' && _numeroConvertidoHexadecimal[i + 1] == '0' &&
                    _numeroConvertidoHexadecimal[i + 2] == '0' && _numeroConvertidoHexadecimal[i + 3] == '0')
                {
                    _numeroConvertidoIEEE754EmHexadecimal = _numeroConvertidoIEEE754EmHexadecimal + "0";
                }
                else if (_numeroConvertidoHexadecimal[i] == '0' && _numeroConvertidoHexadecimal[i + 1] == '0' &&
                    _numeroConvertidoHexadecimal[i + 2] == '0' && _numeroConvertidoHexadecimal[i + 3] == '1')
                {
                    _numeroConvertidoIEEE754EmHexadecimal = _numeroConvertidoIEEE754EmHexadecimal + "1";
                }
                else if (_numeroConvertidoHexadecimal[i] == '0' && _numeroConvertidoHexadecimal[i + 1] == '0' &&
                    _numeroConvertidoHexadecimal[i + 2] == '1' && _numeroConvertidoHexadecimal[i + 3] == '0')
                {
                    _numeroConvertidoIEEE754EmHexadecimal = _numeroConvertidoIEEE754EmHexadecimal + "2";
                }
                else if (_numeroConvertidoHexadecimal[i] == '0' && _numeroConvertidoHexadecimal[i + 1] == '0' &&
                    _numeroConvertidoHexadecimal[i + 2] == '1' && _numeroConvertidoHexadecimal[i + 3] == '1')
                {
                    _numeroConvertidoIEEE754EmHexadecimal = _numeroConvertidoIEEE754EmHexadecimal + "3";
                }
                else if (_numeroConvertidoHexadecimal[i] == '0' && _numeroConvertidoHexadecimal[i + 1] == '1' &&
                    _numeroConvertidoHexadecimal[i + 2] == '0' && _numeroConvertidoHexadecimal[i + 3] == '0')
                {
                    _numeroConvertidoIEEE754EmHexadecimal = _numeroConvertidoIEEE754EmHexadecimal + "4";
                }
                else if (_numeroConvertidoHexadecimal[i] == '0' && _numeroConvertidoHexadecimal[i + 1] == '1' &&
                    _numeroConvertidoHexadecimal[i + 2] == '0' && _numeroConvertidoHexadecimal[i + 3] == '0')
                {
                    _numeroConvertidoIEEE754EmHexadecimal = _numeroConvertidoIEEE754EmHexadecimal + "5";
                }
                else if (_numeroConvertidoHexadecimal[i] == '0' && _numeroConvertidoHexadecimal[i + 1] == '1' &&
                    _numeroConvertidoHexadecimal[i + 2] == '1' && _numeroConvertidoHexadecimal[i + 3] == '0')
                {
                    _numeroConvertidoIEEE754EmHexadecimal = _numeroConvertidoIEEE754EmHexadecimal + "6";
                }
                else if (_numeroConvertidoHexadecimal[i] == '0' && _numeroConvertidoHexadecimal[i + 1] == '1' &&
                    _numeroConvertidoHexadecimal[i + 2] == '1' && _numeroConvertidoHexadecimal[i + 3] == '1')
                {
                    _numeroConvertidoIEEE754EmHexadecimal = _numeroConvertidoIEEE754EmHexadecimal + "7";
                }
                else if (_numeroConvertidoHexadecimal[i] == '1' && _numeroConvertidoHexadecimal[i + 1] == '0' &&
                    _numeroConvertidoHexadecimal[i + 2] == '0' && _numeroConvertidoHexadecimal[i + 3] == '0')
                {
                    _numeroConvertidoIEEE754EmHexadecimal = _numeroConvertidoIEEE754EmHexadecimal + "8";
                }
                else if (_numeroConvertidoHexadecimal[i] == '1' && _numeroConvertidoHexadecimal[i + 1] == '0' &&
                    _numeroConvertidoHexadecimal[i + 2] == '0' && _numeroConvertidoHexadecimal[i + 3] == '1')
                {
                    _numeroConvertidoIEEE754EmHexadecimal = _numeroConvertidoIEEE754EmHexadecimal + "9";
                }
                else if (_numeroConvertidoHexadecimal[i] == '1' && _numeroConvertidoHexadecimal[i + 1] == '0' &&
                    _numeroConvertidoHexadecimal[i + 2] == '1' && _numeroConvertidoHexadecimal[i + 3] == '0')
                {
                    _numeroConvertidoIEEE754EmHexadecimal = _numeroConvertidoIEEE754EmHexadecimal + "A";
                }
                else if (_numeroConvertidoHexadecimal[i] == '1' && _numeroConvertidoHexadecimal[i + 1] == '0' &&
                    _numeroConvertidoHexadecimal[i + 2] == '1' && _numeroConvertidoHexadecimal[i + 3] == '1')
                {
                    _numeroConvertidoIEEE754EmHexadecimal = _numeroConvertidoIEEE754EmHexadecimal + "B";
                }
                else if (_numeroConvertidoHexadecimal[i] == '1' && _numeroConvertidoHexadecimal[i + 1] == '1' &&
                    _numeroConvertidoHexadecimal[i + 2] == '0' && _numeroConvertidoHexadecimal[i + 3] == '0')
                {
                    _numeroConvertidoIEEE754EmHexadecimal = _numeroConvertidoIEEE754EmHexadecimal + "C";
                }
                else if (_numeroConvertidoHexadecimal[i] == '1' && _numeroConvertidoHexadecimal[i + 1] == '1' &&
                    _numeroConvertidoHexadecimal[i + 2] == '0' && _numeroConvertidoHexadecimal[i + 3] == '1')
                {
                    _numeroConvertidoIEEE754EmHexadecimal = _numeroConvertidoIEEE754EmHexadecimal + "D";
                }
                else if (_numeroConvertidoHexadecimal[i] == '1' && _numeroConvertidoHexadecimal[i + 1] == '1' &&
                    _numeroConvertidoHexadecimal[i + 2] == '1' && _numeroConvertidoHexadecimal[i + 3] == '0')
                {
                    _numeroConvertidoIEEE754EmHexadecimal = _numeroConvertidoIEEE754EmHexadecimal + "E";
                }
                else
                {
                    _numeroConvertidoIEEE754EmHexadecimal = _numeroConvertidoIEEE754EmHexadecimal + "F";
                }
            }
            return _numeroConvertidoIEEE754EmHexadecimal;
        }
        private void TransformarEmBoleanoMantissa(string a,string b)
        {
            for (int i = 0; i < 23; i++)
            {
                if (a[i] == '1')
                {
                    numeroVetorBoleano[i] = true;
                }
                else
                {
                    numeroVetorBoleano[i] = false;
                }
            }
            for (int i = 0; i < 23; i++)
            {
                if (b[i] == '1')
                {
                    numero2VetorBoleano[i] = true;
                }
                else
                {
                    numero2VetorBoleano[i] = false;
                }
            }
        }
    }
}
