/*
Leia 3 valores de ponto flutuante e efetue o cálculo das raízes da equação de Bhaskara. Se não for possível calcular as raízes, mostre a mensagem correspondente “Impossivel calcular”, caso haja uma divisão por 0 ou raiz de numero negativo.
Entrada

Leia três valores de ponto flutuante (double) A, B e C.
Saída

Se não houver possibilidade de calcular as raízes, apresente a mensagem "Impossivel calcular". Caso contrário, imprima o resultado das raízes com 5 dígitos após o ponto, com uma mensagem correspondente conforme exemplo abaixo. Imprima sempre o final de linha após cada mensagem.
*/

/*
using System; 

class minhaClasse {

    static void Main(string[] args) { 

            double a, b, c, delta, r1, r2;
            string[] valor = Console.ReadLine().Split();

            a = Convert.ToDouble(valor[0]);
        //declare as demais variaveis

            delta = (Math.Pow(b, 2) - (4 * a * c));
            r1 = (-b + Math.Sqrt(delta)) / (2 * a);
            r2 = //declare a variavel corretamente

            if ( )
            {
              //complete a condicional
            }
            else
            {
                Console.WriteLine("Impossivel calcular");
            }

    }

}
*/


/*
using System;

namespace dseafios_csharp_dio
{
    class Program {

    static void Main(string[] args) { 

            double a, b, c, delta, r1, r2;
            string[] valor = Console.ReadLine().Split();

            a = Convert.ToDouble(valor[0]);
            b = Convert.ToDouble(valor[1]);
            c = Convert.ToDouble(valor[2]);
            //declare as demais variaveis

            delta = (Math.Pow(b, 2) - (4 * a * c));
            r1 = (-b + Math.Sqrt(delta)) / (2 * a);
            r2 = (-c + Math.Sqrt(delta)) / (2 * b);

            if (r1 > 0 || r2 > 0)
            {
                Console.WriteLine("r1 = {0}", r1.ToString("0.00000"));
                Console.WriteLine("r2 = {0}", r2.ToString("0.00000"));
            }
            else
            {
                Console.WriteLine("Impossivel calcular");
            }

    }

}
}

*/