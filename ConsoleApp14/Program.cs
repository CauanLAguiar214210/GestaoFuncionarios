
using System;
using System.Globalization;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;

namespace ConsoleApp14
{
    internal class Program
    {
        static void Main(string[] args)
        {

            List<Employee> list = new List<Employee>();
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
                        string name = Console.ReadLine();
                        Console.Write("Salario: ");
                        double salary = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                        list.Add(new Employee(id, name, salary));
                        Console.WriteLine();
                    }
                }
                else if (Acao == '+')
                {
                    Console.Write("Insira o Id do funcionario que receberá o acrescimo do salario : ");
                    int searchId = int.Parse(Console.ReadLine());
                    Console.WriteLine();

                    Employee emp = list.Find(x => x.Id == searchId);
                    if (emp != null)
                    {
                        Console.Write("Enter the percentage: ");
                        double percentage = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                        emp.IncreaseSalary(percentage);
                    }
                    else
                    {
                        Console.WriteLine("This id does not exist!");
                    }
                                        
                    Console.WriteLine("Atualizada Tabela Funcionario:");
                    foreach (Employee obj in list)
                    {
                        Console.WriteLine(obj);
                    }
                    Console.WriteLine();
                }

                else if (Acao == 'L')
                {
                    Console.WriteLine("Tabela Funcionario:");
                    foreach (Employee obj in list)
                    {
                        Console.WriteLine(obj);
                    }
                    Console.WriteLine();
                }

                } while (Acao != 'F');
        }
       
    }
}
