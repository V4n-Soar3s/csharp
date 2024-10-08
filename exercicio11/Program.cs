﻿//Estrutura faça enquanto (do-while)

/*Fazer um programa para ler a temperatura em Celsius e mostrar o equivalente em Fahrenheit. Perguntar se o usuário deseja repetir (s/n). Caso o usuário digite "s", repetir o programa

Fórmula: F = 9C/5 + 32

*/

using System.Globalization;

double C, F;
char repetir;

do{
    Console.Write("Digite a temperatura em Celsius: ");
    C = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
    F = 9.0 * C / 5.0 + 32.0;
    Console.WriteLine("Equivalente em Fahrenheit: " + F.ToString("F1", CultureInfo.InvariantCulture));
    Console.Write("Deseja repetir (s/n)? ");
    repetir = char.Parse(Console.ReadLine());
} while (repetir == 's');

Console.ReadLine();


