using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace urtagitas
{
    internal class Spaceship
    {
        private string name = "Unnamed";
        public double Hull;
        public double Shield;
        public int Fuel;
        public List<Astronaut> Astronauts;

        public int CrewCount
        {
            get
            {
                return Astronauts.Count;
            }
        }

      
        public string Name {
            get 
            {
                return name;
            }

            set 
            {
                if (value != "")
                {
                    name = value;
                }
            }
        }

        public string EngineType { get; set; }








        public Spaceship()
        {

        }



        public Spaceship(string name, double hull, double shield, int fuel, List<Astronaut> astronauts)
        {
            Name = name;
            Hull = hull;
            Shield = shield;
            Fuel = fuel;
            Astronauts = astronauts;
        }

        public void AddAstronaut(Astronaut astronaut)
        {
            Astronauts.Add(astronaut);
        }

        public void ShowFullStatus()
        {
            Console.WriteLine($"Űrhajó: {Name}, burkolat: {Hull}, pajzs: {Shield}, üzemanyag: {Fuel}, legénység száma: {Astronauts.Count}");
            foreach (Astronaut a in Astronauts) 
            {
                a.ShowStatus();
            }
        }

        public void ShowStatus()
        {
            Console.WriteLine($"Űrhajó: {Name}, burkolat: {Hull}, pajzs: {Shield}, üzemanyag: {Fuel}");
        }
        public void Travel()
        {
            if (Fuel >= 20)
            {
                Fuel -= 20;
                Console.WriteLine("A hajó utazik");
            }
            else
            {
                Console.WriteLine("Nincs elég üzemanyag az utazáshoz");
            }
        }
        public void Repair()
        {
            if (Hull < 30)
            {
                Hull += 40;
                Console.WriteLine("Kritikus javítás folyamatban");
            }
            else if (Hull < 70)
            {
                Hull += 25;
                Console.WriteLine("Normál javítás folyamatban");
            }
            else
            {
                Console.WriteLine("Nincs szükség javításra");
            } 
        }
        public void TakeDamage()
        {
            Shield -= 30;
            Hull -= 20;
            Console.WriteLine("Találat érte a hajót!");
        }

        public void diagnostics()
        {
            if ((Hull < 20 && Shield < 20) || (Hull < 20 && Fuel < 10))
            {
                Console.WriteLine("EXTRÉM VÉSZHELYZET!");
                Repair();
            }
            else if (Hull < 30 && Shield < 30 && Fuel < 20)
            {
                Console.WriteLine("KRITIKUS VÉSZHELYZET!");
                Repair();
            }
            else if (Hull < 50 && Shield < 50)
            {
                Console.WriteLine("SÚLYOS SÉRÜLÉS!");
                Repair();
            }
            else if (Fuel < 20 || Shield < 30)
            {
                Console.WriteLine("ERŐFORRÁS-FIGYELMEZTETÉS!");
            }
            else
            {
                Console.WriteLine("Minden hajórendszer megfelelően működik.");
            }
        }

        public void Showlogo()
        {
            if (Hull < 20)
            {
                Console.WriteLine($"\t{Name}");
                Console.WriteLine("          .- -  - -.");
                Console.WriteLine("         '          '-.");
                Console.WriteLine("      /    -            ");
                Console.WriteLine("     |        __         ");
                Console.WriteLine("              _/      /");
                Console.WriteLine("       '.           _.''");
                Console.WriteLine("          '--   -   ");
                Console.WriteLine("          /   |  |   _");
                Console.WriteLine("      /_      |  |  /  _\\");
                Console.WriteLine("\nKRITIKUS SÉRÜLÉS");
            }
            else if (Hull < 50)
            {
                Console.WriteLine($"\t{Name}");
                Console.WriteLine("          .  ------.");
                Console.WriteLine("       .-'          '-.");
                Console.WriteLine("      /    -      O     ");
                Console.WriteLine("     |        __         ");
                Console.WriteLine("              \\_ /      /");
                Console.WriteLine("       '._          _.''");
                Console.WriteLine("          '--==  --'");
                Console.WriteLine("       _  /   |||  \\___");
                Console.WriteLine("      /___\\  ||  /___\\");
                Console.WriteLine("\nSérült");
            }
            else if (Hull >= 50)
            {
                Console.WriteLine($"\t{Name}");
                Console.WriteLine("          .--------.");
                Console.WriteLine("       .-'          '-.");
                Console.WriteLine("      /    O      O    \\");
                Console.WriteLine("     |        __        |");
                Console.WriteLine("      \\      \\__/      /");
                Console.WriteLine("       '._          _.''");
                Console.WriteLine("          '--====--'");
                Console.WriteLine("       ___/  ||||  \\___");
                Console.WriteLine("      /___\\  ||||  /___\\");
                Console.WriteLine("\nNormál hajó");
            }
        }



       




    }
}
