namespace dino2
{
    using System.Collections.Generic;
    using System.Diagnostics.CodeAnalysis;
    using System.Linq;


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
            foreach (Dino item in dinok)
            {
                lista++;
            }
            Console.WriteLine($"A dinok száma: {lista}");
            Console.WriteLine("------------------------------------------------");


            //2 Legidősebb dino
            Dino legidosebb = dinok[0];
            foreach (Dino item in dinok)
            {
                if (legidosebb.age < item.age)
                {
                    legidosebb = item;
                }
            }
            Console.WriteLine($" A lgidősebb dino a {legidosebb}");
            Console.WriteLine("------------------------------------------------");

            for (int i = 0; i < dinok.Count - 1; i++)
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
            Console.WriteLine("kor szerint");
            foreach (Dino item in dinok)
            {
                Console.WriteLine(item.ToString());
            }
            for (int i = 0; i < dinok.Count - 1; i++)
            {
                for (int j = 0; j < dinok.Count - 1 - i; j++)
                {
                    if (string.Compare(dinok[j].Name, dinok[j + 1].Name))
                    {
                        Dino temp = dinok[j];
                        dinok[j] = dinok[j + 1];
                        dinok[j + 1] = temp;
                    }

                }
            }
            Console.WriteLine("Név szerint");
            foreach (Dino item in dinok)
            {
                Console.WriteLine(item.ToString());
            }
            Dino nehezebb = dinok[0];
            foreach (Dino item in dinok)
            {
                if (legidosebb.weight < item.weight)
                {
                    nehezebb = item;
                }
            }
            Console.WriteLine($" A legnehezebb dino a {nehezebb.Name}");
            Console.WriteLine("------------------------------------------------");
            List<Dino> Tdinos = new List<Dino>();
            foreach (Dino item in dinok)
            {
                if (item.type.StartsWith("T") && !Tdinos.Contains(item))
                {
                    Tdinos.Add(item);
                }
            }
            Console.WriteLine("T vel kezd");
            foreach (Dino item in Tdinos)
            {
                Console.WriteLine(item.ToString());
            }

            //DInok átlagsúlya
            double atlag = 0;
            foreach (Dino item in dinok)
            {

                atlag += item.weight;

            }
            Console.WriteLine($"A dinok átlag súlya: {atlag / lista}");

            // piros színű dinok kiírása
            foreach (Dino item in dinok)
            {
                if (item.color == "piros")
                {
                    Console.WriteLine($"A piros színű dino neve: {item.Name}");
                }
            }
            //legkönyebb dino kiírása
            Dino legkonnyebb = dinok[0];
            foreach (Dino item in dinok)
            {
                if (legkonnyebb.weight > item.weight)
                {
                    legkonnyebb = item;
                }
            }

            Console.WriteLine($"A legkönnyebb dino a {legkonnyebb.Name}");
            // 4 és 6 éves dinok kiírása
            foreach (Dino item in dinok)
            {
                if (item.age == 4 || item.age == 6)
                {
                    Console.WriteLine($"A 4 és 6 éves dino neve: {item.Name}");
                }
            }
            // 1000 nél könnyebb dinok kiírása
            foreach (Dino item in dinok)
            {
                if (item.weight < 1000)
                {
                    Console.WriteLine($"A 1000-nél könnyebb dino neve: {item.Name}");
                }
            }
            //dinok száma amik nem adoptáltak
            int nemadoptalt = 0;
            foreach (Dino item in dinok)
            {
                if (!item.adopted)
                {
                    nemadoptalt++;
                }
            }
            Console.WriteLine($"A nem adoptált dinok száma: {nemadoptalt}");
            //összes dinok átlag életkora
            double atlageletkor = 0;
            foreach (Dino item in dinok)
            {
                atlageletkor += item.age;
            }
            Console.WriteLine($"A dinok átlag életkora: {atlageletkor / lista}");
            //legfiatalabb 3 dino kiirása
            List<Dino> legfiatalabb = new List<Dino>();
            for (int i = 0; i < 3; i++)
            {
                legfiatalabb.Add(dinok[i]);
            }
            Console.WriteLine("A legfiatalabb 3 dino:");






        }
    }
}

