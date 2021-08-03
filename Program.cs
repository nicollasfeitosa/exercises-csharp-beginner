using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Exercicios
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("EXERCICIOS EM C# \n");
            Console.WriteLine("Digite o numero do exercicio que deseja visualizar: \n");
            Console.WriteLine("01 - Dado o tamanho da base e da altura de um retangulo, calcular a sua área e o seu périmetro.");
            Console.WriteLine("02 - Dado o tamanho do lado de um quadrado, calcular a área e o périmetro do mesmo.");
            Console.WriteLine("03 - Dado o tamanho do raio de uma circuferência, calcular a área e o perímetro da mesma.");
            Console.WriteLine("04 - Dado os três lados de um triângulo determinar o perímetro do mesmo.");
            Console.WriteLine("05 - Ler um numero inteiro e exibir o seu sucessor.");
            Console.WriteLine("06 - Ler dois numeros inteiros e exibir o quociente e o resto da divisão inteira entre eles.");
            Console.WriteLine("07 - Solicitar a idade de uma pessoa em dias e informar na tela a idade em anos, meses e dias.");
            Console.WriteLine("08 - Leia um valor de temperatura em Fahrenheit e converta para Celsius");
            Console.WriteLine("09 - Faça um algoritimo que calcule e apresente o valor do volume de uma lata de óleo, dado seu raio e sua altura");
            Console.WriteLine("10 - Visualiza uma tabuada de 1 a 10 do numero que o usuario digitar \n");

            int exerciseNumber = int.Parse(Console.ReadLine());

            switch (exerciseNumber)
            {
                case 1:
                    exercise01();
                    break;

                case 2:
                    exercise02();
                    break;

                case 3:
                    exercise03();
                    break;

                case 4:
                    exercise04();
                    break;

                case 5:
                    exercise05();
                    break;

                case 6:
                    exercise06();
                    break;

                case 7:
                    exercise07();
                    break;

                case 8:
                    exercise08();
                    break;

                case 9:
                    exercise09();
                    break;

                case 10:
                    exercise10();
                    break;

                case 11:
                    exercise11();
                break;

                case 12:
                    exercise12();
                break;

                default:
                    Console.WriteLine("Opção invalida!");
                    break;
            }

            Console.WriteLine("\nExecução finalizada! Digite qualquer tecla para sair. \n");
            Console.ReadLine();
        }

        static void exercise01()
        {
            Console.WriteLine("01 - Dado o tamanho da base e da altura de um retangulo, calcular a sua área e o seu périmetro. \n");

            Console.WriteLine("Digite a largura:");
            int largura = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite a altura:");
            int altura = int.Parse(Console.ReadLine());

            var area = calcularArea(largura, altura);
            var perimetro = calcularPerimetro(largura, altura);

            Console.WriteLine("A Area do seu retangulo é: " + area);
            Console.WriteLine("O Perimetro do seu retangulo é: " + perimetro);
        }

        static void exercise02()
        {
            Console.WriteLine("02 - Dado o tamanho do lado de um quadrado, calcular a área e o périmetro do mesmo. \n");

            Console.WriteLine("Digite o tamanho de um dos lados de seu quadrado:");
            int tamanho = int.Parse(Console.ReadLine());

            var area = calcularArea(tamanho, tamanho);
            var perimetro = calcularPerimetro(tamanho, tamanho);

            Console.WriteLine("A Area do seu quadrado é: " + area);
            Console.WriteLine("O Perimetro do seu quadrado é: " + perimetro);
        }

        static void exercise03()
        {
            Console.WriteLine("03 - Dado o tamanho do raio de uma circuferência, calcular a área e o perímetro da mesma. \n");

            Console.WriteLine("Digite o tamanho do raio de sua circuferência:");
            double raio = double.Parse(Console.ReadLine());
            const double pi = 3.14;

            var area = calcularAreaCirculo(raio, pi);
            var perimetro = calcularPerimetroCirculo(raio, pi);

            Console.WriteLine("A Area do seu circulo é: " + area);
            Console.WriteLine("O Perimetro do seu circulo é: " + perimetro);
        }

        static void exercise04()
        {
            Console.WriteLine("04 - Dado os três lados de um triângulo determinar o perímetro do mesmo. \n");

            Console.WriteLine("Digite o lado do triangulo:");
            int lado1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o lado 2 do triangulo:");
            int lado2 = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o lado 3 do triangulo:");
            int lado3 = int.Parse(Console.ReadLine());

            Console.WriteLine("O perímetro do seu triangulo é: " + (lado1 + lado2 + lado3));
        }

        static void exercise05()
        {
            Console.WriteLine("05 - Ler um numero inteiro e exibir o seu sucessor. \n");

            Console.WriteLine("Digite um numero inteiro:");
            int numero = int.Parse(Console.ReadLine());

            Console.WriteLine("Seu successor é: " + (++numero));
            Console.WriteLine("Seu antecessor é: " + (--numero));
        }

        static void exercise06()
        {
            Console.WriteLine("06 - Ler dois numeros inteiros e exibir o quociente e o resto da divisão inteira entre eles. \n");

            Console.WriteLine("Digite um numero inteiro:");
            int numero1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite um outro numero inteiro:");
            int numero2 = int.Parse(Console.ReadLine());

            Console.WriteLine("O quociente entre " + numero1 + " e " + numero2 + " é igual a: " + (numero1 / numero2));
            Console.WriteLine("O resto da divisão entre " + numero1 + " e " + numero2 + " é igual a: " + (numero1 % numero2));
        }

        static void exercise07()
        {
            Console.WriteLine("07 - Solicitar a idade de uma pessoa em dias e informar na tela a idade em anos, meses e dias. \n");

            Console.WriteLine("Digite sua idade em dias:");
            int idadeEmDias = int.Parse(Console.ReadLine());

            Console.WriteLine("Sua idade em dias é: " + idadeEmDias);
            Console.WriteLine("Sua idade em meses é: " + (idadeEmDias / 30));
            Console.WriteLine("Sua idade em anos é: " + ((idadeEmDias / 30) / 12));

        }

        static void exercise08()
        {
            Console.WriteLine("08 - Leia um valor de temperatura em Fahrenheit e converta para Celsius");

            Console.WriteLine("Digite um valor de temperatura em Fahrenheit: ");
            double fahrenheit = double.Parse(Console.ReadLine());

            var celsius = (fahrenheit - 32) * 5 / 9;

            Console.WriteLine("Valor em Celsius: "+ celsius);
        }

        static void exercise09()
        {
            Console.WriteLine("09 - Faça um algoritimo que calcule e apresente o valor do volume de uma lata de óleo, dado seu raio e sua altura");

            Console.WriteLine("Digite o valor do Raio: ");
            double raio = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite o valor da altura: ");
            double altura = double.Parse(Console.ReadLine());

            const double pi = 3.14159;

            var volume = pi * raio * raio * altura;
            Console.WriteLine("O volume de sua lata é de: " + volume);
        }

        static void exercise10()
        {
            Console.WriteLine("Exercicio Tabuada. \n");

            Console.WriteLine("10 - Digite o numero da tabuada que você deseja visualizar:");
            int numero = int.Parse(Console.ReadLine());

            for (int count = 1; count <= 10; count++)
            {
                Console.Write(count + " X " + numero + " = " + (count * numero) + "\n");
            }
            Console.WriteLine("\n");
        }

        static void exercise11()
        {
            Console.WriteLine("Exercicio média \n");
            Console.WriteLine("11 - Elabore um algoritmo que calcule a idade média de X alunos:");

            Console.WriteLine("Digite quantos alunos você deseja inserir:");
            double limiter = double.Parse(Console.ReadLine());

            List<double> list = new List<double>();
            for (int i = 1; i <= limiter; i++)
            {
                Console.WriteLine("Digite a idade do aluno " + i + ":");
                list.Add(double.Parse(Console.ReadLine()));
            }

            Console.WriteLine("\nA média de idade dos alunos é: " + list.Average());
            Console.WriteLine("\n");
        }

        static void exercise12()
        {
            Console.WriteLine("Exercicio consumo médio \n");

            Console.WriteLine("12 - Elabore um algoritmo que calcule o consumo médio de um veículo por quilometragem com um litro de gasolina.:");

            Console.WriteLine("Quilometragem inicial:");
            double start = double.Parse(Console.ReadLine());

            Console.WriteLine("Quilometragem final:");
            double end = double.Parse(Console.ReadLine());

            double totalDistance = (end - start);

            Console.WriteLine("Digite o total de combustível gasto:");
            double totalFuel = double.Parse(Console.ReadLine());

            double avgFuel = totalDistance / totalFuel;

            Console.WriteLine("\nA média de consumo em sua viagem de " + totalDistance + "KM é: " + avgFuel);
            Console.WriteLine("\n");
        }

        static double calcularAreaCirculo(double raio, double pi)
        {
            return pi * (raio * raio);
        }

        static double calcularPerimetroCirculo(double raio, double pi)
        {
            return (2 * pi) * raio;
        }

        static int calcularArea(int largura, int altura)
        {
            return largura * altura;
        }

        static int calcularPerimetro(int largura, int altura)
        {
            return (largura + altura) * 2;
        }

    }
}
