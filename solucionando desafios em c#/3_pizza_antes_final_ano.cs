/*

Desafio

Como um bom desenvolvedor, você precisa fazer um programa que leia dois inteiros: R e V (devem ser lidos tantos valores para V quantos necessários, até que seja digitado um valor maior do que R para ele). Conte quantos números inteiros devem ser somados em sequência (considerando o R nesta soma) para que a soma ultrapasse a V o mínimo possível. Escreva o valor final da contagem.

A entrada pode conter, por exemplo, os valores 21 21 15 30. Neste caso, é então assumido o valor 21 para R enquanto os valores 21 e 15 devem ser desconsiderados pois são menores ou iguais a R. Como o valor 30 está dentro da especificação (maior do que R) ele será válido e então deve-se processar os cálculos para apresentar na saída o valor 2, pois é a quantidade de valores somados para se produzir um valor maior do que 30 (21 + 22).
Entrada

A entrada contém somente valores inteiros, um por linha, podendo ser positivos ou negativos. O primeiro valor da entrada será o valor de R. A próxima linha da entrada irá conter V. Se V não atender a especificação do problema, ele deverá ser lido novamente, tantas vezes quantas forem necessárias.
Saída

Imprima uma linha com um número inteiro que representa a quantidade de números inteiros que devem ser somadas, de acordo com a especificação acima.

*/

using System;

public class pizzaria
{
  public static void Main()
  {
    string[] line = Console.ReadLine().Split(" ");
    int totalDePessoas = int.Parse(line[0]);
    int totalDeDatas = int.Parse(line[1]);
    
    string dataConsiderada = "";
    
    for (int i = 0; i < totalDeDatas; i++)
    {
      int totalDePessoasQuePodemComparecer = 0;
      
      string[] entradaDataConfirmacao = Console.ReadLine().Split(" ");
      dataConsiderada = entradaDataConfirmacao[0];
      
      for (int j = 1; j < totalDePessoas + 1; j++)
      {
        totalDePessoasQuePodemComparecer += int.Parse(entradaDataConfirmacao[j]);
      }
      
      if (totalDePessoasQuePodemComparecer == totalDePessoas)
      {
        Console.WriteLine(dataConsiderada);
        break;
      } 
      else if ( i + 1 >= totalDeDatas)
      {
        Console.WriteLine("Pizza antes de FdA");
      }
    }
  }
}