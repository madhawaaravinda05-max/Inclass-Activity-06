using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Robot
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ServiceRobot sRobot = new ServiceRobot("ServBot", 24, "v1.0", "Hospitality");
            sRobot.DisplayDetails();

            ServiceRobot clonedSRobot = (ServiceRobot)sRobot.Clone();
            clonedSRobot.BatteryCapacity = 48; 
            clonedSRobot.SoftwareVersion = "v1.1"; 
            clonedSRobot.DisplayDetails();

            Console.WriteLine();

            IndustrialRobot iRobot = new IndustrialRobot("IndusPro", 48, "v2.0", "Welding");
            iRobot.DisplayDetails();

            IndustrialRobot clonedIRobot = (IndustrialRobot)iRobot.Clone();
            clonedIRobot.SoftwareVersion = "v2.5";
            clonedIRobot.DisplayDetails();

            Console.WriteLine();

            EntertainmentRobot eRobot = new EntertainmentRobot("EntertainMe", 12, "v3.0", "Dancing");
            eRobot.DisplayDetails();

            EntertainmentRobot clonedERobot = (EntertainmentRobot)eRobot.Clone();
            clonedERobot.EntertainmentFeature = "Singing and Dancing";
            clonedERobot.DisplayDetails();

            Console.ReadLine();
        }
    }
}
