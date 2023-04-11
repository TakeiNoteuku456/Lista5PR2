using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista5PR2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int Ex;

            Console.WriteLine("========Menu========");
            Console.WriteLine("Exercício 1");
            Console.WriteLine("Exercício 2");
            Console.WriteLine("Exercício 3");
            Console.WriteLine("Exercício 4");
            Console.WriteLine("Exercício 5");
            Console.WriteLine("Exercício 6");

            Ex = int.Parse(Console.ReadLine());

            switch (Ex)
            {
            case 1:
                    Console.Write("Digite um número inteiro: ");
                    int num = int.Parse(Console.ReadLine());

                    for (int i = 1; i <= num; i++)
                    {
                        Console.Write(i + " ");
                    }
                    break;
            case 2:
                    int num;
                    Console.Write("Digite um número inteiro: ");
                    num = int.Parse(Console.ReadLine());
                    Console.WriteLine("Números pares de 1 a {0}:", num);
                    for (int i = 1; i <= num; i++)
                    {
                        if (i % 2 == 0)
                        {
                            Console.Write(i + " ");
                        }
                    }
                    break;
            case 3:
                    Console.Write("Digite um número inteiro menor que 1000: ");
                    int numero = int.Parse(Console.ReadLine());

                    if (numero >= 1000)
                    {
                        Console.WriteLine("Número inválido! Deve ser menor que 1000.");
                        return;
                    }

                    Console.WriteLine("Números pares de 1000 até {0}:", numero);
                    for (int i = 1000; i <= numero; i++)
                    {
                        if (i % 2 == 0)
                        {
                            Console.Write(i + " ");
                        }
                    }
                    Console.WriteLine();
                    break;
            case 4:
                    int soma = 0;
                    while (soma < 200)
                    {
                        Console.Write("Digite um número inteiro: ");
                        int numero = int.Parse(Console.ReadLine());

                        if (numero > 0)
                        {
                            Console.WriteLine(numero);
                            soma += numero;
                        }
                    }
                    break;
            case 5:
                    int n1 = int.Parse(Console.ReadLine());

                    Console.WriteLine($"Divisores de {n1}:");
                    for (int i = 1; i <= n1; i++)
                    {
                        if (n1 % i == 0)
                        {
                            Console.WriteLine(i);
                        }
                    }
                    break;
            case 6:
                    int n, maior, menor;

                    Console.WriteLine("Digite 10 números:");
                    n = int.Parse(Console.ReadLine());
                    maior = n;
                    menor = n;

                    for (int i = 1; i < 10; i++)
                    {
                        n = int.Parse(Console.ReadLine());
                        if (n > maior)
                        {
                            maior = n;
                        }
                        if (n < menor)
                        {
                            menor = n;
                        }
                    }

                    Console.WriteLine($"O maior número digitado foi: {maior}");
                    Console.WriteLine($"O menor número digitado foi: {menor}");
                    break;
            case 7:
                    int N1, somaPares = 0, somaImpares = 0;

                    do
                    {
                        Console.Write("Digite um número (0 para sair): ");
                        N1 = int.Parse(Console.ReadLine());

                        if (N1 != 0)
                        {
                            if (N1 % 2 == 0)
                            {
                                somaPares += N1;
                            }
                            else
                            {
                                somaImpares += N1;
                            }
                        }
                    } while (N1 != 0);

                    Console.WriteLine("Soma dos números pares: " + somaPares);
                    Console.WriteLine("Soma dos números ímpares: " + somaImpares);

                    Console.ReadKey();
                    break;

            }
        }
    }
}
