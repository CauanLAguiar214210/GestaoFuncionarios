using ConsoleApp14.Entities;
using System;
using System.Globalization;

namespace ConsoleApp14
{
    internal class Funcionario
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public Enum WorkerLevel { get; set; }
        public double Salario { get; set; }
        public Departamento Departamento { get; set; }
        
        public Funcionario(int id, string name, double salary, Departamento departamento){
            Id = id;
            Nome = name.ToUpper();
            Salario = salary;
            Departamento = departamento;
        }

        public void AumentarSalario(double percentagem) 
        {
            Salario += Salario * percentagem / 100;
        }

        public override string ToString()
        {
            return "[" + Id + " | " + Nome + " | " + Departamento.Nome + " | " + Salario.ToString("F2", CultureInfo.InvariantCulture) + "]";
        }
                
    }
}
