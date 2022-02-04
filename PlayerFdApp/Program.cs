using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Racon;
using Racon.RtiLayer;

using MechanicsDesign.Som;

using PlayerFdApp;
using PlayerFdApp.LocalData;
using System.Threading;

namespace MechanicsDesign
{
    class Program
    {
        static CSimulationManager manager = new CSimulationManager();
        //   static CShip ship = new CShip(); // Own ship
        static bool Terminate = false; // exit switch for app
        public static int dodgeChance = 0;
        public static bool battleStart = false;
        public static int attacks = 0;
        public static int updates = 0;
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

            //Object Initialization

            CPlayerHlaObject encapsulatedPlayerObject1 = new CPlayerHlaObject(manager.federate.Som.PlayerOC);
            manager.PlayerObjects.Add(encapsulatedPlayerObject1);






            // Federation Initialization
            // connect, create and join to federation execution, declare object model
            bool result = manager.federate.InitializeFederation(manager.federate.FederationExecution);


            // FM Test
            manager.federate.ListFederationExecutions();
            battleStart = false;


            bool req = true;
            int x = 0;
            // process rti events (callbacks) and tick
            while (true)
            {
                if (manager.federate.FederateState.HasFlag(Racon.FederateStates.JOINED))
                    manager.federate.Run();

                if (finished)
                    break;


            }

            manager.federate.DeleteObjectInstance(manager.PlayerObjects[0], Tags.deleteRemoveTag);
            // Leave and destroy federation execution
            bool result2 = manager.federate.FinalizeFederation(manager.federate.FederationExecution);

            Console.WriteLine("Press any key to exit.");
            Console.ReadKey();

        }


        private static void PrintVersion()
        {
            Console.WriteLine(
              "***************************************************************************\n"
              + "                        " + "PlayerFdApp v1.0.0" + "\n"
              + "***************************************************************************");
        }

        private static void Federate_StatusMessageChanged(object sender, EventArgs e)
        {
            Console.ResetColor();
            Console.WriteLine((sender as CPlayerFdApp).StatusMessage);
        }
    }
}
