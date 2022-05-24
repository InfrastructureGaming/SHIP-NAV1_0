using System;

namespace SHIP_NAV1_0
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("INITIALIZING SHIP-NAV v1.0, build 052422");
            Console.WriteLine("-----------");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Welcome to the SHIP-NAV interface! This program will guide you through the process of entering our Seaport safely and efficiently.");
            Console.WriteLine("Please enter your name:");
            string captainName = Console.ReadLine();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Greetings, Captain " + captainName);
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Please enter the name of your vessel:");
            string shipName = Console.ReadLine();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("The " + shipName + " has been cleared for port entry.");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("-----------");
            Console.WriteLine(shipName + " is approaching the PILOT ZONE. Standby for PILOT arrival.");
            Console.WriteLine("Press ENTER to confirm PILOT is aboard " + shipName);
            Console.ReadLine();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("PILOT CONFIRMED");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine(shipName + " is approaching the TUG ZONE. Please enter number of TUGS needed for your vessel.");
            string tugsQty = Convert.ToString(Console.ReadLine());
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Dispatching " + tugsQty + " TUGS to " + shipName);
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Press ENTER to confirm arrival of TUGS");
            Console.ReadLine();
            Console.WriteLine("-----------");
            Console.WriteLine("Please maintain radio contact with TUGS at all times. \n Refer to PILOT for further berthing instructions.\n Press ENTER to acknowledge.");
            Console.ReadLine();
            Console.WriteLine("Approaching designated BERTH. Please enter current loaded weight in TEU:");
            int shipWeight = Convert.ToInt32(Console.ReadLine());
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("CONFIRMED. Thank you, Captain " + captainName + ".");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("MOORING operations commencing. Please ensure adequate CREW coverage at bow and stern.");
            Console.WriteLine("Press ENTER to confirm CREW are in position for MOORING.");
            Console.ReadLine();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write("CONFIRMED.");
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("Please disengage all thrusters and set engines to IDLE. Once MOORED, deploy gangway.");
            Console.Write("Press ENTER to confirm gangway deployment");
            Console.ReadLine();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("CONFIRMED. \n BERTHING COMPLETE. \n CARGO UNLOADING OPERATIONS WILL COMMENCE SHORTLY.");
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("Press ENTER to complete port entry process.");
            Console.ReadLine();
            Console.WriteLine("-----------");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Container ship " + shipName + " current loaded weight " + shipWeight + " TEU is now unloading. \n Thank you, Captain " + captainName + ".");
            Console.WriteLine("EXITING SHIP-NAV v1.0, build 052422");
            Console.WriteLine("-----------");
        }
    }
}
