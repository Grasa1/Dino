using System.Diagnostics.CodeAnalysis;
using System.Linq;

namespace Dino
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Dino> dinok = FileManager.ReadFile("dinok.csv");
            foreach (Dino item in dinok)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("------------------------------------------------");


            //1 Dinok szama
            int lista = 0;
            foreach(Dino item in dinok)
            {
                lista++;
            }
            Console.WriteLine($"A dinok száma: {lista}");
            Console.WriteLine("------------------------------------------------");


            //2 Legidősebb dino
            Dino legidosebb = dinok[0]; 
            foreach (Dino item in dinok)
            {
                if(legidosebb.age < item.age)
                {
                    legidosebb = item;
                }
            }
            Console.WriteLine($" A lgidősebb dino a {legidosebb}");
            Console.WriteLine("------------------------------------------------");

            for (int i = 0; i < dinok.Count- 1; i++)
            {
                for (int j = 0; j < dinok.Count - 1 - i; j++)
                {
                    if (dinok[j].age > dinok[j + 1].age)
                    {
                        Dino temp = dinok[j];
                        dinok[j] = dinok[j + 1];
                        dinok[j + 1] = temp;
                    }
                }
            }
        }
        

    }

    
}
