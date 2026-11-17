using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace urtagitas
{
    internal class Spacesuit
    {
        public string Model;
        public int OxygenLevel;
        public int Integrity;

        public Spacesuit(string model, int oxygenLevel, int integrity)
        {
            Model = model;
            OxygenLevel = oxygenLevel;
            Integrity = integrity;
        }
        public void ShowStatus()
        {
            Console.WriteLine($"Ruha=> Modell: {Model}, oxigénszint: {OxygenLevel}, integritás: {Integrity}");
        }
    }
}
