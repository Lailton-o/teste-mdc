using System;

public class Program
{
    public static void Main()
    {
        /***** ESTE MÉTODO NÃO DEVE SER ALTERADO.

        Leia atentamente as instruções e escreva um programa para calcular o MDC de dois números positivos A e B.
        A saída do console deverá apresentar os números esperados.
        Boas práticas também serão avaliadas. :)

        O algoritmo para calcular o MDC de dois números positivos A e B consiste em:
        - Identificar o menor número entre A e B, supondo que B < A.
        - Se B é igual a zero, então o MDC é igual a A.
        - Caso contrário o MDC entre A e B será o mesmo que o MDC de B e (A % B), onde (A % B) representa o resto de A quando dividido por B. Para calcular o MDC de B e (A % B) podemos aplicar o mesmo método.

        *****/

        // Entrada: Cada uma das linhas contém uma string representando os números A e B separados por um espaço:
        Console.WriteLine(Process("10"));
        Console.WriteLine(Process("0 1"));
        Console.WriteLine(Process("1 1000"));
        Console.WriteLine(Process("3 9"));
        Console.WriteLine(Process("123 456"));
        Console.WriteLine(Process("340 728"));
        Console.WriteLine(Process("12 18"));
        Console.WriteLine(Process("200 456"));
        Console.WriteLine(Process("66 121"));
        Console.WriteLine(Process("231 825"));
        Console.WriteLine(Process("90 180"));

        Console.ReadLine();

        /***** Saída:
        Para cada linha que contém os dois números inteiros A e B, imprima o MDC de A e B. Saída esperada:
        1
        1
        3
        3
        4
        6
        8
        11
        33
        90
        *****/
    }

    private static string Process(string input)
    {
        if (string.IsNullOrEmpty(input))
            return "Dados obrigatórios!";

        var dados = input.Split(' ');

        if (dados.Length < 2)
            return "Precisa informar pelo menos 2 números!";

        int primeiro, segundo = 0;

        if (!int.TryParse(dados [0], out primeiro))
            return "Primeiro número inválido!";
        if (!int.TryParse(dados [1], out segundo))
            return "Segundo número inválido!";

        if (segundo == 0)
            return primeiro.ToString();

        return CalcularMDC(primeiro, segundo).ToString();
    }


    private static int CalcularMDC(int param1, int param2)
    {
        int resto;

        while (param2 != 0)
        {
            resto = param1 % param2;
            param1 = param2;
            param2 = resto;
        }

        return param1;
    }
}