using System;
using System.Linq;

namespace ConversorDeBinario
{
    class Conversor
    {
        public static string InversorDeString (string str)
        {
            //pegar o numero inteiro e contar os caracteres
            int tamanho = str.Length;
            //cria char com o numero de caracteres da string tamanho
            char[] caracteres = new char[tamanho];
            //coloca caracter por caracter dentro do array
            for (int i = 0; i < tamanho; i++)
            {
                caracteres[i] = str[tamanho - 1 - i];
            }
            //retorna a string invertida
            return new string(caracteres);
        }

        public static int BinarioParaDecimal(string valorBinario)
        {
            int expoente = 0;
            int numero;
            int soma = 0;
            //recebe o numero invertido
            string numeroInvertido = InversorDeString(valorBinario);
            //pega numero por numero transforma em int para fazer o calculo da "transformação" em decimal
            for(int i = 0; i < numeroInvertido.Length; i++)
            {
                numero = Convert.ToInt32(numeroInvertido.Substring(i, 1));
                soma += numero * (int)Math.Pow(2, expoente);
                expoente++;
            }
            return soma;

        }
        public static string DecimalParaBinario(string numero)
        {
            string valor = "";
            //pega o numero e transforma em inteiro
            int dividendo = Convert.ToInt32(numero);
            //se for 0 ou 1 já retorna 0 ou 1 e fds 
            if (dividendo == 0 || dividendo == 1)
            {
                return Convert.ToString(dividendo);
            }
            else
            {
                //aqui pega o numero e faz o calculo para "transformar" em binario
                while(dividendo > 0)
                {
                    valor += Convert.ToString(dividendo % 2);
                    dividendo = dividendo / 2;
                }
                //Pega o numero em forma binaria,inverte e retorna o valor certo
                return InversorDeString(valor);
            }
        }

    }
}
