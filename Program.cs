using Calculadora.Entities;
using System;
using System.Globalization;

namespace Calculadora
{
    class Program
    {
        static void Main(string[] args)
        {


            while (true)
            {
                Console.WriteLine("_______________________________________________________________");
                Console.WriteLine("MENU DE OPÇÕES:");
                Console.WriteLine("_______________________________________________________________");
                Console.WriteLine("1 - Somar ");
                Console.WriteLine("2 - Subtrair ");
                Console.WriteLine("3 - Multiplicar ");
                Console.WriteLine("4 - Dividir ");
                Console.WriteLine("5 - Resto ");
                Console.WriteLine("6 - Potenciação");
                Console.WriteLine("0 - Desligar Calculadora ");

                Console.WriteLine("_______________________________________________________________");


                int escolha = int.Parse(Console.ReadLine());

                Console.WriteLine("_______________________________________________________________");

                if (escolha == 0)
                {
                    Console.WriteLine("CALCULADORA ENCERRADA!!");
                    break;
                }
                Console.Write("Escolha o primeiro número: ");
                double n1 = double.Parse(Console.ReadLine());

                Console.Write("Escolha o segundo número: ");
                double n2 = double.Parse(Console.ReadLine());

                switch (escolha) 
                {
                    
                    case 1:
                        
                        Soma soma = new Soma();
                        soma.Somar(n1, n2);
                        
                        break;

                    case 2:
                        
                        Subtrair subtrair = new Subtrair();
                        subtrair.Subtracao(n1,n2);
                        break;

                    case 3:
                        
                        Multiplicacao multiplicacao = new Multiplicacao();
                        multiplicacao.Multiplicar(n1, n2);
                        break;

                    case 4:
                        
                        Divisao divisao = new Divisao();
                        if(n2 == 0)
                        {
                            Console.WriteLine("Não é possível dividir por zero");
                            break;
                        }
                        else
                        {

                            divisao.Dividir(n1, n2);
                        }
                        break;

                    case 5:

                        Resto resto = new Resto();
                        resto.Restante(n1, n2);
                        break;
                    
                    case 6:

                        Potencia potencia = new Potencia();
                        potencia.Potenciacao(n1, n2);
                        break;


                }

                

            }
        }
    }
}