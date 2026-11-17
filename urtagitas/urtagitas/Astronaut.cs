using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace urtagitas
{
    internal class Astronaut 
    {
        private string name;
        public int Health;
        private int energy;
        public int Oxygen;
        public Spacesuit Suit;

        public string Name { get => name; set => name = value; }
        public int Energy { get => energy;
            private set
            {
                energy = value;
            }
        }
          
        

        public Astronaut() 
        {

        }
        public Astronaut(string name, int health, int energy, int oxygen, Spacesuit suit)
        {
            Name = name;
            Health = health;
            Energy = energy;
            Oxygen = oxygen;
            Suit = suit;
        }

        public void ShowStatus()
        {
            Console.Write($"Űrhajós: {Name}, egészség: {Health}, energiaszint: {Energy}, oxigén: {Oxygen},");
            
            if (Suit != null) {
                Suit.ShowStatus();
            }
        }
        public void Rest()
        {
            if (Energy < 20)
            {
                Energy += 40;
                Console.WriteLine("Sűrgős pihenés szükséges");
            }
            else if (Energy < 60)
            {
                Energy += 30;
                Console.WriteLine("Az űrhajós pihen");
            }
            else
            {
                Console.WriteLine("Nincs szükség pihenésre");
            }

        }
        public void Work()
        {
            if (Energy >= 20 && Oxygen >= 20)
            {
                Energy -= 20;
                Oxygen -= 10;
                Console.WriteLine("Az űrhajós dolgozik");
            }
            else
            {
                Console.WriteLine("Az űrhajós nem tud dolgozni");
            }
        }

        public void diagnostics()
        {

            if ((Health < 30 && Energy < 30) || (Oxygen < 20 && Energy < 30))
            {
                Console.WriteLine("VÉSZHELYZETI REGENERÁLÓDÁS SZÜKSÉGES!");
                Rest();
            }
            else if (Health < 30 && Oxygen < 50)
            {
                Console.WriteLine("ORVOSI ELLÁTÁS SZÜKSÉGES!");
            }
            else if (Energy < 30)
            {
                Console.WriteLine("Az űrhajós kimerült.");
                Rest();
            }
            else if (Oxygen < 30)
            {
                Console.WriteLine("FIGYELEM: Alacsony oxigénszint!");
            }
            else
            {
                Console.WriteLine("Az űrhajós készen áll.");
            }
        }

    }
}
