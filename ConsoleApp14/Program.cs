using System;
using System.Globalization;
using System.Collections.Generic;
using ConsoleApp14.Entities;

namespace ConsoleApp14
{
    internal class Program
    {
        
        static void Main(string[] args)
        {

            List<Funcionario> list = new List<Funcionario>();
            char Acao;

            do
            {
                Console.WriteLine("Menu: \n(C)Cadastrar Funcionarios \n(+)Aumentar Salario \n(L)Listar Funcionarios \n(F)Finalizar e Sair");
                Acao = char.Parse(Console.ReadLine().ToUpper());
                Console.WriteLine();

                if (Acao == 'C')
                {
                    Console.WriteLine("Quantos funcionnarios serão cadastrados?");
                    int n = int.Parse(Console.ReadLine());


                    for (int i = 1; i <= n; i++)
                    {
                        Console.WriteLine(i + "°Funcionario: ");
                        Console.Write("Id: ");
                        int id = int.Parse(Console.ReadLine());

                        Console.Write("Nome: ");
                        string nome = Console.ReadLine();

                        Console.Write("Departamento: ");
                        Departamento depart = new Departamento(Console.ReadLine());

                        Console.Write("Salario: ");
                        double salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                                            
                        list.Add(new Funcionario(id, nome, salario, depart));
                        Console.WriteLine();
                    }
                }
                else if (Acao == '+')
                {
                    Console.Write("Insira o Id do funcionario que receberá o acrescimo do salario : ");
                    int searchId = int.Parse(Console.ReadLine());
                    Console.WriteLine();

                    Funcionario emp = list.Find(x => x.Id == searchId);
                    if (emp != null)
                    {
                        Console.Write("Informe a Porcentagem: ");
                        double percentagem = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                        emp.AumentarSalario(percentagem);
                    }
                    else
                    {
                        Console.WriteLine("Id não encontrada!");
                    }
                                        
                    Console.WriteLine("Atualizada Tabela Funcionario:");
                    foreach (Funcionario obj in list)
                    {
                        Console.WriteLine(obj);
                    }
                    Console.WriteLine();
                }

                else if (Acao == 'L')
                {
                    Console.WriteLine("Tabela Funcionario:");
                    foreach (Funcionario obj in list)
                    {
                        Console.WriteLine(obj);
                    }
                    Console.WriteLine();
                }

                } while (Acao != 'F');
        }
       
    }
}
