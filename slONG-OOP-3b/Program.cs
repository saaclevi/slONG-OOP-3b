using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace slONG_OOP_3b
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Animal pet = new Animal();

            Console.WriteLine("Digite os campos: ");
            Console.WriteLine("ID: ");
            pet.id = Convert.ToInt32( Console.ReadLine());
            Console.WriteLine("Tipo: ");
            pet.tipo = Console.ReadLine();
            Console.WriteLine("Raça: ");
            pet.raca = Console.ReadLine();
            Console.WriteLine("Cor: ");
            pet.cor = Console.ReadLine();
            Console.WriteLine("Idade: ");
            pet.idade = Convert.ToInt32(Console.ReadLine());
            do
            {
                Console.WriteLine("Ferimentos (S/N): ");
                pet.ferimentos = Console.ReadLine();
                Console.WriteLine(string.Compare(pet.ferimentos, "s");
            } while (pet.ferimentos =! "S   ");


            Console.WriteLine("")
        }
    }
}
 