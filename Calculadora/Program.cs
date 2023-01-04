using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora
{
    internal class Program
    {
        //Enum utilizado para criação do menu
        enum Opcao { Somar = 1, Subtrair, Multiplicar, Dividir, Sair };

        //Função para definição do cursor (posição) em tela
        protected void display(int x, int y)
        {
            Console.SetCursorPosition(x, y);
        }

        static void Main(string[] args)
        {
            while(true)
            {
                //Menu
                Console.WriteLine("----- Calculadora -----");
                menu();
                escolha();
                Console.ReadLine();
                Console.Clear();
            }
        }

        //FUNÇÃO MENU
        static void menu()
        {
            Console.WriteLine("Escolha uma das operações abaixo: ");
            Console.WriteLine("1- Somar\n2- Subtrair\n3- Multiplicar\n4- Dividir\n5- Sair");
            Console.WriteLine("");
            Console.Write("Opção: ");
        }

        //FUNÇÃO PARA ESCOLHA
        static void escolha()
        {
            //Atribuindo a classe Program
            Program p = new Program();

            //Variáveis
            float num1, num2, resultado;
            string caracter;
            int qtde;

            int index = int.Parse(Console.ReadLine());
            Opcao Escolha = (Opcao)index;

            //Escolha da opção
            switch (Escolha)
            {
                case Opcao.Somar:
                    Console.WriteLine("Escolha 2 números para realizar a operação de soma: ");
                    num1 = int.Parse(Console.ReadLine());
                    //Posição do Cursor
                    caracter = num1.ToString();
                    qtde = caracter.Length;
                    p.display(qtde, 10);
                    Console.Write("+");
                    num2 = int.Parse(Console.ReadLine());
                    //Cálculo e resultado
                    resultado = num1 + num2;
                    Console.WriteLine("Resultado: " + resultado);
                    Console.WriteLine("");
                    break;
                case Opcao.Subtrair:
                    Console.WriteLine("Escolha 2 números para realizar a operação de subtração: ");
                    num1 = int.Parse(Console.ReadLine());
                    //Posição do Cursor
                    caracter = num1.ToString();
                    qtde = caracter.Length;
                    p.display(qtde, 10);
                    Console.Write("-");
                    num2 = int.Parse(Console.ReadLine());
                    resultado = num1 - num2;
                    Console.WriteLine("Resultado: " + resultado);
                    Console.WriteLine("");
                    break;
                case Opcao.Multiplicar:
                    Console.WriteLine("Escolha 2 números para realizar a operação de multiplicação: ");
                    num1 = int.Parse(Console.ReadLine());
                    //Posição do Cursor
                    caracter = num1.ToString();
                    qtde = caracter.Length;
                    p.display(qtde, 10);
                    Console.Write("*");
                    num2 = int.Parse(Console.ReadLine());
                    resultado = num1 * num2;
                    Console.WriteLine("Resultado: " + resultado);
                    Console.WriteLine("");
                    break;
                case Opcao.Dividir:
                    Console.WriteLine("Escolha 2 números para realizar a operação de divisão: ");
                    num1 = int.Parse(Console.ReadLine());
                    //Posição do Cursor
                    caracter = num1.ToString();
                    qtde = caracter.Length;
                    p.display(qtde, 10);
                    Console.Write("/");
                    num2 = int.Parse(Console.ReadLine());
                    resultado = num1 / num2;
                    Console.WriteLine("Resultado: " + resultado);
                    Console.WriteLine("");
                    break;
                case Opcao.Sair:
                    Environment.Exit(0);
                    break;
                default:
                    Console.WriteLine("Opção não encontrada, tente novamente");
                    break;
            }
        }

    }
}