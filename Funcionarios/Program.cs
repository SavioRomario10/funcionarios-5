using System;
using Funcionarios.Entities;

namespace Funcionarios
{
    class Program
    {
        public void Main(string[] args)
        {
            List<Employe> list = new List<Employe>();

            Console.Write("Numero de funcionarios: ");
            int n = int.Parse(Console.ReadLine());

            for(int i=1; i<=n; i++)
            {
                Console.WriteLine($"Funcionario #{i} data:");
                Console.Write("Tercerizado?");
                char ch = char.Parse(Console.ReadLine());
                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("Horas: ");
                int hours = int.Parse(Console.ReadLine());
                Console.Write("Valor por horas: ");
                double value = double.Parse(Console.ReadLine());

                if(ch == 'y')
                {
                    Console.Write("Preço adicional: ");
                    double change = double.Parse(Console.ReadLine());

                    list.Add(new OutEmploye(name, hours, value, change));
                }
                else{
                    list.Add(new Employe(name, hours, value));
                }

                Console.WriteLine();
            }
            
            Console.WriteLine("Pagamento");
            foreach(Employe emp in list)
            {
                Console.WriteLine(emp.Name + " - $" + emp.Payment());
            }

            Console.ReadKey();
        }
    }
}