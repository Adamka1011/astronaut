using System.ComponentModel.DataAnnotations;

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

            Astronaut anna = new Astronaut("Anna", 100, 80, 100);
            Astronaut cigany = new Astronaut("Kolompár", 60, 70, 90);

            anna.ShowStatus();
            //mars_suit.ShowStatus();

            List<Astronaut> list = new List<Astronaut>();
            list.Add(anna);
            list.Add(cigany);

            Spaceship urlyukfelfedezo = new Spaceship("Űrlyuk felfedező 69", 100, 80, 90, list);
            //urlyukfelfedezo.ShowStatus();

            Astronaut misi = new Astronaut("Misi", 100, 75, 66);
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


            Captain pirx = new Captain("Pirx", 95, 88, 92);
            Captain ijon = new Captain("Ijon Tichy", 90, 95, 85);
            Captain horpach = new Captain("Horpach", 88, 75, 90);
            Captain rohan = new Captain("Rohan", 94, 82, 96);
            Captain bregg = new Captain("Bregg", 96, 88, 95);
            Captain tempe = new Captain("Tempe", 89, 84, 90);
            Captain kelvin = new Captain("Kelvin", 82, 78, 85);
            Captain gibarian = new Captain("Gibarian", 70, 65, 80);
            Captain snaut = new Captain("Snaut", 78, 72, 85);

            Captain hari = new Captain("Hari Seldon", 92, 86, 94);
            Captain salvor = new Captain("Salvor Hardin", 87, 90, 88);
            Captain hober = new Captain("Hober Mallow", 90, 85, 92);
            Captain bel = new Captain("Bel Riose", 85, 80, 89);
            Captain golan = new Captain("Golan Trevize", 91, 92, 87);
            Captain elijah = new Captain("Elijah Baley", 88, 78, 90);
            Captain gladia = new Captain("Gladia Delmarre", 93, 85, 95);
            Captain biron = new Captain("Biron Farrill", 79, 88, 82);

            Engineer trurl = new Engineer("Trurl", 92, 90, 85);
            Engineer klapancius =    new Engineer("Klapaucius", 88, 95, 90);
            Engineer elekry  =   new Engineer("Elektrybałt", 100, 100, 100);
            Engineer corcoran =    new Engineer("Corcoran", 90, 85, 88);
            Engineer dobb  =  new Engineer("Dobb", 75, 70, 80);
            Engineer tarantoga  =  new Engineer("Tarantoga", 95, 85, 90);
            Engineer murdas  =   new Engineer("Murdas", 86, 75, 90);
            Engineer hylas   =  new Engineer("Hylas", 83, 88, 85);

            Engineer daneel  =   new Engineer("R. Daneel Olivaw", 100, 95, 100);
            Engineer giskard  =   new Engineer("R. Giskard Reventlov", 100, 90, 100);
            Engineer andrew   =  new Engineer("Andrew Martin", 95, 88, 100);
            Engineer herbie   =  new Engineer("Herbie", 90, 85, 95);
            Engineer cutie   =  new Engineer("QT-1 Cutie", 100, 100, 100);
            Engineer sammy   =  new Engineer("R. Sammy", 85, 75, 90);
            Engineer jander   =  new Engineer("R. Jander Panell", 92, 88, 100);
            Engineer amadiro  =   new Engineer("R. Amadiro", 80, 85, 90);
            Engineer fastolfe  =   new Engineer("R. Fastolfe", 88, 92, 95);

            Scientist sartrius = new Scientist("Sartorius", 82, 80, 88);
            Scientist golem = new Scientist("Golem XIV", 100, 100, 100);
            Scientist decantor = new Scientist("Decantor", 88, 90, 92);
            Scientist azzie = new Scientist("Azzie", 78, 85, 88);
            Scientist mimow = new Scientist("Mimow", 86, 90, 80);
            Scientist panta = new Scientist("Panta", 78, 92, 82);
            Scientist profcorcoran = new Scientist("Professor Corcoran", 90, 85, 88);
            Scientist construct = new Scientist("The Constructor", 87, 95, 89);

            Scientist susan = new Scientist("Susan Calvin", 90, 80, 95);
            Scientist peter = new Scientist("Peter G. Vassilyev", 85, 75, 90);
            Scientist arkady = new Scientist("Arkady Darell", 88, 92, 85);
            Scientist bayta = new Scientist("Bayta Darell", 94, 88, 92);
            Scientist ebling = new Scientist("Ebling Mis", 75, 65, 80);
            Scientist janov = new Scientist("Janov Pelorat", 82, 70, 88);
            Scientist dors = new Scientist("Dors Venabili", 98, 95, 100);
            Scientist yugo = new Scientist("Yugo Amaryl", 87, 90, 85);

            List<Astronaut> astronauts = new List<Astronaut>()
            {
                pirx , ijon, horpach , rohan , bregg , tempe , kelvin , gibarian , snaut ,
                hari , salvor , hober , bel , golan , elijah , gladia , biron ,
                trurl, klapancius, elekry, corcoran, dobb , tarantoga, murdas, hylas,
                daneel, giskard , andrew, herbie, cutie, sammy, jander, amadiro, fastolfe,
                sartrius , golem , decantor, azzie , mimow , panta , profcorcoran , construct,
                susan,  peter, arkady , bayta , ebling , janov , dors , yugo
            };

            foreach (var astronaut in astronauts)
            {
                Console.WriteLine(astronaut.Name);
            }
            Console.WriteLine($"Összes asztronauta: {astronauts.Count}");
            foreach (var astronaut in astronauts)
            {
                if(astronaut.Name == "Pirx")
                {
                    astronaut.ShowStatus();
                }
            }
            foreach (var astronaut in astronauts)
            {
                if (astronaut.Health == 100)
                {
                    Console.WriteLine($"Űrhajos 100 életponttal: {astronaut.Name}");
                }
            }
            int healthy = 0;
            foreach (var astronaut in astronauts)
            {
                if (astronaut.Health > 85)
                {
                    healthy += 1;
                }
            }
            Console.WriteLine($"85 feletti űrhajósok száma: {healthy}");
            foreach (var astronaut in astronauts)
            {
                if (astronaut.Oxygen < 42)
                {
                    astronaut.ShowStatus();
                }
            }
            Console.WriteLine();
            Console.WriteLine("Kapitányok: ");
            foreach (var astronaut in astronauts)
            {
                if (astronaut is Captain)
                {
                    Console.WriteLine(astronaut.Name);
                }
            }

            Captain miguel = new Captain("Miguel", 69, 80, 85);
            Console.WriteLine(astronauts.Contains(miguel));

            astronauts.Insert(astronauts.Count - 1, miguel);
            Console.WriteLine(astronauts.Contains(miguel));

            Console.WriteLine(astronauts.IndexOf(miguel));
            Console.WriteLine(astronauts.Count);

            double atlageletero = 0;
            foreach (var astronaut in astronauts)
            {
                atlageletero += astronaut.Health;
            }
            Console.WriteLine($"Átlag életerő: {atlageletero/astronauts.Count}");
            double atlageleterocap = 0;
            int capcount = 0;
            foreach (var astronaut in astronauts)
            {
                if(astronaut is Captain)
                {
                    atlageleterocap += astronaut.Health;
                    capcount++;
                }
            }
            Console.WriteLine($"Átlag kapitány életerő: {atlageleterocap / capcount}");

            double atlageleteroeng = 0;
            int engcount = 0;
            foreach (var astronaut in astronauts)
            {
                if (astronaut is Engineer)
                {
                    atlageleteroeng += astronaut.Health;
                    engcount++;
                }
            }
            Console.WriteLine($"Átlag mérnök életerő: {atlageleteroeng / engcount}");

            double atlageleterosci = 0;
            int scicount = 0;
            foreach (var astronaut in astronauts)
            {
                if (astronaut is Scientist)
                {
                    atlageleterosci += astronaut.Health;
                    scicount++;
                }
            }
            Console.WriteLine($"Átlag tudós életerő: {atlageleterosci / scicount}");
            
            int minimumenergy = astronauts.Min(x => x.Energy);
            Console.WriteLine(minimumenergy);
            int maxenergy = astronauts.Max(x => x.Energy);
            Console.WriteLine(maxenergy);

            double legtáposabb = 0;
            foreach (var astronaut in astronauts)
            {
                int tápos = astronaut.Health + astronaut.Oxygen + astronaut.Energy;
                double avg = tápos / 3;
                if( avg > legtáposabb)
                {
                    legtáposabb = avg;
                }
            }
            Console.WriteLine(legtáposabb);
            foreach(var astronaut in astronauts)
            {

            }
        }
    }
}
