using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dino
{   
    public class Dino
    {
        public string Name { get; set; }   
        public string type { get; set; }
        public string color { get; set; }
        public int age { get; set; }
        public double weight { get; set; }
        public bool adopted { get; set; }


        public Dino(string[] data) 
        {
            this.Name = data[0];
            this.type = data[1];
            this.color = data[2];
            this.age = int.Parse(data[3]);
            this.weight = double.Parse(data[4].Replace('.', ','));
            this.adopted = bool.Parse(data[5]);
        }

        public Dino(string name, string type, string color, int age, double weight, bool adopted)
        {
            this.Name = name;
            this.type = type;
            this.color = color;
            this.age = age;
            this.weight = weight;
            this.adopted = adopted;
        }

        public override string ToString()
        {
            return $"A Dino neve: {Name} | tipusa: {type} | szine: {color} | kora: {age} | sulya: {weight} | adoptált: {adopted} ";
        }

        public bool IsAdopted()
        {
            if(adopted)
            {
                Console.WriteLine($"Ez a dino már adoptálva van");
                return true;
            }
            else
            {
                Console.WriteLine($"Örökbe fogadtad");
                return false;
            }
        }
        public double Eating(double plusweight)
        {
            return weight += plusweight;
        }
        public int ageup(int pluszage)
        {
            return age += pluszage;
        }   
        public string ReName(string newname)
        {
            if(adopted == true)
            {
                return Name = newname;
            }
            else
            {
                Console.WriteLine("A Dínót nem tudod átnevezni mert nem adoptáltad");
                return Name;
            }
        }
    }
}
