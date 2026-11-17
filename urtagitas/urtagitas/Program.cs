namespace urtagitas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Spaceship urlyuktagito = new Spaceship();
            urlyuktagito.Name = "Űrlyuktágító69";
            urlyuktagito.Hull = 100;
            urlyuktagito.Shield = 80;
            urlyuktagito.Fuel = 90;

            Console.WriteLine($"név: {urlyuktagito.Name}, burkolat: {urlyuktagito.Hull}, pajzs: {urlyuktagito.Shield}, üzemanyag: {urlyuktagito.Fuel}");

            urlyuktagito.Hull = 75;
            urlyuktagito.Fuel = 60;

            urlyuktagito.ShowStatus();
            Console.WriteLine();

            urlyuktagito.Fuel = 90;
            urlyuktagito.Travel();
            urlyuktagito.ShowStatus();
            urlyuktagito.Travel();
            urlyuktagito.ShowStatus();
            Console.WriteLine();


            urlyuktagito.Hull = 40;
            urlyuktagito.Repair();
            urlyuktagito.ShowStatus();
            urlyuktagito.Repair();
            urlyuktagito.ShowStatus();
            Console.WriteLine();

            urlyuktagito.Hull = 100;
            urlyuktagito.Shield = 80;
            urlyuktagito.TakeDamage();
            urlyuktagito.ShowStatus();
            urlyuktagito.TakeDamage();
            urlyuktagito.ShowStatus();
            Console.WriteLine();

            urlyuktagito.Fuel = 50;
            urlyuktagito.Travel();
            urlyuktagito.ShowStatus();
            Console.WriteLine();
            urlyuktagito.Fuel = 20;
            urlyuktagito.Travel();
            urlyuktagito.ShowStatus();
            Console.WriteLine();
            urlyuktagito.Fuel = 10;
            urlyuktagito.Travel();
            urlyuktagito.ShowStatus();
            Console.WriteLine();

            urlyuktagito.Hull = 20;
            urlyuktagito.Repair();
            urlyuktagito.ShowStatus();
            Console.WriteLine();
            urlyuktagito.Hull = 50;
            urlyuktagito.Repair();
            urlyuktagito.ShowStatus();
            Console.WriteLine();
            urlyuktagito.Hull = 80;
            urlyuktagito.Repair();
            urlyuktagito.ShowStatus();
            Console.WriteLine();

            Astronaut hozas = new Astronaut();
            hozas.Name = "Hózás";
            hozas.Health = 100;
            //hozas.Energy = 80;
            hozas.Oxygen = 100;

            Astronaut marosyx = new Astronaut();
            marosyx.Name = "Marosyx";
            marosyx.Health = 80;
            //marosyx.Energy = 40;
            marosyx.Oxygen = 70;

            Console.WriteLine($"Nevem: {hozas.Name}, egészség: {hozas.Health}, energiaszint: {hozas.Energy}, oxigén: {hozas.Oxygen}\n");
            Console.WriteLine($"Nevem: {marosyx.Name}, egészség: {marosyx.Health}, energiaszint: {marosyx.Energy}, oxigén: {marosyx.Oxygen}\n");

            
            marosyx.ShowStatus();
            hozas.ShowStatus();

            //marosyx.Energy = 40;
            marosyx.Rest();
            marosyx.ShowStatus();
            Console.WriteLine();

            Console.WriteLine("===============WORK===============");
            //marosyx.Energy = 80;
            marosyx.Oxygen = 100;
            marosyx.ShowStatus();
            marosyx.Work();
            marosyx.ShowStatus();
            marosyx.Work();
            marosyx.ShowStatus();
            Console.WriteLine();
            Console.WriteLine("----------tesztelés-----------------");

            //marosyx.Energy = 50;
            marosyx.Oxygen = 50;
            marosyx.Work();
            marosyx.ShowStatus();
            Console.WriteLine();

            //marosyx.Energy = 50;
            marosyx.Oxygen = 10;
            marosyx.Work();
            marosyx.ShowStatus();
            Console.WriteLine();

            //marosyx.Energy = 10;
            marosyx.Oxygen = 50;
            marosyx.Work();
            marosyx.ShowStatus();
            Console.WriteLine();

           // marosyx.Energy = 10;
            marosyx.Oxygen = 10;
            marosyx.Work();
            marosyx.ShowStatus();
            Console.WriteLine();


            Console.WriteLine("---------------Rest metódus tesztelése---------------");
            //marosyx.Energy = 10;
            marosyx.Rest();
            marosyx.ShowStatus();
            Console.WriteLine();

            //marosyx.Energy = 40;
            marosyx.Rest();
            marosyx.ShowStatus();
            Console.WriteLine();

            //marosyx.Energy = 80;
            marosyx.Rest();
            marosyx.ShowStatus();
            Console.WriteLine();

            Console.WriteLine("---------------diagnostics methódus----------------");
            urlyuktagito.Hull = 40;
            urlyuktagito.ShowStatus();
            urlyuktagito.diagnostics();
            urlyuktagito.ShowStatus();
            Console.WriteLine();

            Console.WriteLine("---------------diagnostics pro methódus----------------");
            urlyuktagito.Hull = 20;
            urlyuktagito.Shield = 20;
            urlyuktagito.Fuel = 10;
            urlyuktagito.ShowStatus();
            urlyuktagito.diagnostics();
            urlyuktagito.ShowStatus();
            Console.WriteLine();

            urlyuktagito.Hull = 40;
            urlyuktagito.Shield = 40;
            urlyuktagito.Fuel = 80;
            urlyuktagito.ShowStatus();
            urlyuktagito.diagnostics();
            urlyuktagito.ShowStatus();
            Console.WriteLine();

            urlyuktagito.Hull = 80;
            urlyuktagito.Shield = 20;
            urlyuktagito.Fuel = 80;
            urlyuktagito.ShowStatus();
            urlyuktagito.diagnostics();
            urlyuktagito.ShowStatus();
            Console.WriteLine();

            urlyuktagito.Hull = 90;
            urlyuktagito.Shield = 90;
            urlyuktagito.Fuel = 80;
            urlyuktagito.ShowStatus();
            urlyuktagito.diagnostics();
            urlyuktagito.ShowStatus();
            Console.WriteLine();


            Console.WriteLine("---------------űrhajós diagnostics methódus----------------");
            marosyx.Health = 20;
            //marosyx.Energy = 10;
            marosyx.Oxygen = 80;
            marosyx.ShowStatus();
            marosyx.diagnostics();
            marosyx.ShowStatus();
            Console.WriteLine();

            marosyx.Health = 80;
            //marosyx.Energy = 20;
            marosyx.Oxygen = 80;
            marosyx.ShowStatus();
            marosyx.diagnostics();
            marosyx.ShowStatus();
            Console.WriteLine();

            marosyx.Health = 80;
            //marosyx.Energy = 80;
            marosyx.Oxygen = 20;
            marosyx.ShowStatus();
            marosyx.diagnostics();
            marosyx.ShowStatus();
            Console.WriteLine();

            marosyx.Health = 100;
            //marosyx.Energy = 80;
            marosyx.Oxygen = 100;
            marosyx.ShowStatus();
            marosyx.diagnostics();
            marosyx.ShowStatus();
            Console.WriteLine();

            Console.WriteLine("---------------diagnostics pro plusz methódus----------------");
            urlyuktagito.Hull = 10;
            urlyuktagito.Shield = 10;
            urlyuktagito.Fuel = 80;
            urlyuktagito.ShowStatus();
            urlyuktagito.diagnostics();
            urlyuktagito.ShowStatus();
            Console.WriteLine();

            urlyuktagito.Hull = 10;
            urlyuktagito.Shield = 80;
            urlyuktagito.Fuel = 5;
            urlyuktagito.ShowStatus();
            urlyuktagito.diagnostics();
            urlyuktagito.ShowStatus();
            Console.WriteLine();

            urlyuktagito.Hull = 10;
            urlyuktagito.Shield = 80;
            urlyuktagito.Fuel = 80;
            urlyuktagito.ShowStatus();
            urlyuktagito.diagnostics();
            urlyuktagito.ShowStatus();
            Console.WriteLine();

            urlyuktagito.Hull = 80;
            urlyuktagito.Shield = 10;
            urlyuktagito.Fuel = 5;
            urlyuktagito.ShowStatus();
            urlyuktagito.diagnostics();
            urlyuktagito.ShowStatus();
            Console.WriteLine();

            Console.WriteLine("---------------űrhajós diagnostics pro methódus----------------");
            marosyx.Health = 20;
            //marosyx.Energy = 20;
            marosyx.Oxygen = 80;
            marosyx.ShowStatus();
            marosyx.diagnostics();
            marosyx.ShowStatus();
            Console.WriteLine();

            marosyx.Health = 80;
            //marosyx.Energy = 20;
            marosyx.Oxygen = 10;
            marosyx.ShowStatus();
            marosyx.diagnostics();
            marosyx.ShowStatus();
            Console.WriteLine();

            marosyx.Health = 20;
            //marosyx.Energy = 80;
            marosyx.Oxygen = 40;
            marosyx.ShowStatus();
            marosyx.diagnostics();
            marosyx.ShowStatus();
            Console.WriteLine();

            marosyx.Health = 80;
            //marosyx.Energy = 20;
            marosyx.Oxygen = 80;
            marosyx.ShowStatus();
            marosyx.diagnostics();
            marosyx.ShowStatus();
            Console.WriteLine();
            
            marosyx.Health = 80;
            //marosyx.Energy = 80;
            marosyx.Oxygen = 20;
            marosyx.ShowStatus();
            marosyx.diagnostics();
            marosyx.ShowStatus();
            Console.WriteLine();
            
            marosyx.Health = 100;
            //marosyx.Energy = 80;
            marosyx.Oxygen = 100;
            marosyx.ShowStatus();
            marosyx.diagnostics();
            marosyx.ShowStatus();
            Console.WriteLine();



            Console.WriteLine("---------------aszteroidamező----------------");

            urlyuktagito.Hull = 100;
            urlyuktagito.Shield = 80;
            urlyuktagito.Fuel = 90;

            marosyx.Health = 100;
            //marosyx.Energy = 80;
            marosyx.Oxygen = 100;

            hozas.Health = 80;
            //hozas.Energy = 40;
            hozas.Oxygen = 70;

            urlyuktagito.ShowStatus();
            marosyx.ShowStatus();
            hozas.ShowStatus();
            Console.WriteLine();

            urlyuktagito.Travel();
            Console.WriteLine();

            urlyuktagito.TakeDamage();
            urlyuktagito.TakeDamage();
            Console.WriteLine();

            marosyx.Work();
            marosyx.Work();
            Console.WriteLine();

            urlyuktagito.diagnostics();
            Console.WriteLine();

            marosyx.diagnostics();
            hozas.diagnostics();
            Console.WriteLine();

            urlyuktagito.ShowStatus();
            marosyx.ShowStatus();
            hozas.ShowStatus();
            Console.WriteLine();

            Console.WriteLine("---------------önálló diagnostics----------------");
            urlyuktagito.Hull = 15;
            urlyuktagito.Shield = 15;
            urlyuktagito.Fuel = 5;

            marosyx.Health = 20;
            //marosyx.Energy = 15;
            marosyx.Oxygen = 15;

            urlyuktagito.ShowStatus();
            marosyx.ShowStatus();
            Console.WriteLine();

            urlyuktagito.diagnostics();
            marosyx.diagnostics();
            Console.WriteLine();

            urlyuktagito.ShowStatus();
            marosyx.ShowStatus();
            Console.WriteLine();

            
            urlyuktagito.Showlogo();
            urlyuktagito.Name = "ASCII";
            urlyuktagito.Showlogo();
            Console.WriteLine();
            Console.WriteLine();


            urlyuktagito.Name = "Űrlyuktágító69";
            urlyuktagito.Hull = 100;
            urlyuktagito.Showlogo();
            Console.WriteLine();
            Console.WriteLine();

            urlyuktagito.Hull = 40;
            urlyuktagito.Showlogo();
            Console.WriteLine();
            Console.WriteLine();

            urlyuktagito.Hull = 10;
            urlyuktagito.Showlogo();
            Console.WriteLine();
            Console.WriteLine();

            Spacesuit moon_suit = new Spacesuit("moon_model", 100, 100);
            Spacesuit mars_suit = new Spacesuit("mars_model", 100, 97);

            Astronaut anna = new Astronaut("Anna", 100,80,100, moon_suit);
            Astronaut cigany = new Astronaut("Kolompár", 60,70,90, mars_suit);

            anna.ShowStatus();
            //mars_suit.ShowStatus();

            List<Astronaut> list = new List<Astronaut>();
            list.Add(anna);
            list.Add(cigany);

            Spaceship urlyukfelfedezo = new Spaceship("Űrlyuk felfedező 69", 100,80,90, list);
            //urlyukfelfedezo.ShowStatus();

            Astronaut misi = new Astronaut("Misi", 100,75,66, mars_suit);
            urlyukfelfedezo.AddAstronaut(misi);

            Console.WriteLine("foreach");
            foreach (Astronaut a in urlyukfelfedezo.Astronauts)
            {
                a.ShowStatus();
            }


            Console.WriteLine("\nShowfullstatus");
            urlyukfelfedezo.ShowFullStatus();



            hozas.Name = "Anna";
            Console.WriteLine(hozas.Name);
            marosyx.Name = "Béla";
            Console.WriteLine(marosyx.Name);

            Console.WriteLine(marosyx.Energy);
            marosyx.Rest();
            Console.WriteLine(marosyx.Energy);

            //marosyx.Energy = 9999;


            Console.WriteLine(urlyukfelfedezo.CrewCount);

            list.Add(marosyx);
            list.Add(hozas);
            Console.WriteLine(urlyukfelfedezo.CrewCount);


        }
    }
    
}
