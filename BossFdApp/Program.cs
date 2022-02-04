using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Racon;
using Racon.RtiLayer;

using MechanicsDesign.Som;

using BossFdApp.LocalData;
using System.Threading;

namespace MechanicsDesign
{
    class Program
    {
        static CSimulationManager manager = new CSimulationManager();
     //   static CShip ship = new CShip(); // Own ship
        static bool Terminate = false; // exit switch for app
        public static int playersPresent = 0;
        public static int playersAlive = 0;
        public static int attacksPerformed = 0;
        public static int reacting = 0;
        public static bool startAttacking = false;
        public static int nameUpdate = 0;
        public static double startTime;
        public static bool finished = false;
        static bool test = false; // guard for testing for various RTI interface

        static void Main(string[] args)
        {

            PrintVersion();

            // Racon Initialization
            // Getting the information/debugging messages from RACoN
            manager.federate.StatusMessageChanged += Federate_StatusMessageChanged;
            manager.federate.LogLevel = LogLevel.ALL;




            CBossHlaObject encapsulatedBossObject = new CBossHlaObject(manager.federate.Som.BossOC);
            encapsulatedBossObject.Boss = new CBoss();
            encapsulatedBossObject.Boss.BName = "Diablo the Undying";
            manager.BossObjects.Add(encapsulatedBossObject);


            // Federation Initialization
            // connect, create and join to federation execution, declare object model
            if (manager.federate.InitializeFederation(manager.federate.FederationExecution))
            {

                Console.WriteLine("Federation was connected, created, joined, and had federate capabilities declared.\n");
            }
        


            // FM Test
            manager.federate.ListFederationExecutions();





            while (true)
            {
                if (manager.federate.FederateState.HasFlag(Racon.FederateStates.JOINED))
                    manager.federate.Run();

                if (!startAttacking && playersAlive > 0 && nameUpdate == playersAlive )
                {
                    Console.ForegroundColor = ConsoleColor.Magenta;
                    Console.WriteLine("Diablo the Undying has risen, you can only hope to dodge his attacks so be ready!");
                    Console.WriteLine(manager.federate.SendMessage("Diablo the Undying has risen, you can only hope to dodge his attacks so be ready!", 0));
                    Thread.Sleep(400);
                    Console.ResetColor();
                    startAttacking = true;
                }

                if (finished)
                    break;
            }

            manager.federate.DeleteObjectInstance(manager.BossObjects[0], Tags.deleteRemoveTag);
            // Leave and destroy federation execution
            bool result2 = manager.federate.FinalizeFederation(manager.federate.FederationExecution);

            Console.WriteLine("Press any key to exit.");
            Console.ReadKey();
        }

        private static void PrintVersion()
        {
            Console.WriteLine(
              "***************************************************************************\n"
              + "                        " + "BossFdApp v1.0.0" + "\n"
              + "***************************************************************************");
        }

        public static string AttackMessage(int action)
        {
            if (action == 1)
                return "Diablo conjures a sword -> a frontal attack will be performed! Move behind!\nDodge Chance = " + (100 - action * 15) + "%";
            else if (action == 2)
                return "Diablo conjures an axe -> a point blank AOE attack will be performed! Move away!\nDodge Chance = " + (100 - action * 15) + "%";
            else if (action == 3)
                return "Diablo conjures a scythe -> a donut attack will be performed! Move close!\nDodge Chance = " + (100 - action * 15) + "%";
            else if (action == 4)
                return "Diablo conjures a bow -> a behind attack will be performed! Move in front!\nDodge Chance = " + (100 - action * 15) + "%";
            else if (action == 5)
                return "Diablo summons a meteor -> attack on all players in line of sight will be performed! Move behind a wall!\nDodge Chance = " + (100 - action * 15) + "%";
            else return null;
        }

        private static void Federate_StatusMessageChanged(object sender, EventArgs e)
        {
            Console.ResetColor();
            Console.WriteLine((sender as CBossFdApp).StatusMessage);
        }



    }

}
