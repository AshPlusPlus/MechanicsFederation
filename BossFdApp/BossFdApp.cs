// **************************************************************************************************
//		CBossFdApp
//
//		generated
//			by		: 	Simulation Generator (SimGe) v.0.3.3
//			at		: 	Sunday, January 30, 2022 2:44:38 PM
//		compatible with		: 	RACoN v.0.0.2.5
//
//		copyright		: 	(C) 
//		email			: 	
// **************************************************************************************************
/// <summary>
/// The application specific federate that is extended from the Generic Federate Class of RACoN API. This file is intended for manual code operations.
/// </summary>

// System
using System;
using System.Collections.Generic; // for List

// Racon
using Racon;
using Racon.RtiLayer;
// Application
using MechanicsDesign.Som;
using System.Threading;

namespace MechanicsDesign
{
  public partial class CBossFdApp : Racon.CGenericFederate
  {
    #region Manually Added Code
    
    // Local Data
    private CSimulationManager manager;
        private bool initialization = true;
        private int rounds = 0;
        #region Constructor
        public CBossFdApp(CSimulationManager parent) : this()
    {
      manager = parent; // Set simulation manager
      // Create regions manually
    }
        #endregion //Constructor


        public bool SendMessage(string txt, int amount)
        {
            HlaInteraction interaction = new Racon.RtiLayer.HlaInteraction(Som.BattleLogIC, "BattleLog");

            // Add Values
            interaction.AddParameterValue(Som.BattleLogIC.type, 1); // int
            interaction.AddParameterValue(Som.BattleLogIC.message, txt); // String
            interaction.AddParameterValue(Som.BattleLogIC.amount, amount); // int


            // Send interaction
            return (SendInteraction(interaction,"Boss Attacks"));
        }
        public void UpdateAll(CBossHlaObject boss)
        {
            // Add Values
            boss.AddAttributeValue(Som.BossOC.BName, boss.Boss.BName);
            boss.AddAttributeValue(Som.BossOC.Action, (uint)boss.Boss.Action);
            UpdateAttributeValues(boss, Tags.updateReflectTag);
        }
        public void UpdateName(CBossHlaObject boss)
        {
            boss.AddAttributeValue(Som.BossOC.BName, boss.Boss.BName);
            UpdateAttributeValues(boss, Tags.updateReflectTag);
        }
        public void UpdateAction(CBossHlaObject boss)
        {
            boss.AddAttributeValue(Som.BossOC.Action, (uint)boss.Boss.Action);
            UpdateAttributeValues(boss, Tags.updateReflectTag);
            if (boss.Boss.Action > 0)
                Program.attacksPerformed++;
        }

        #endregion


        #region Event Handlers
        #region Federate Callback Event Handlers
        #region Federation Management Callbacks
        // FdAmb_ConnectionLost
        public override void FdAmb_ConnectionLost(object sender, HlaFederationManagementEventArgs data)
        {
            // Call the base class handler
            base.FdAmb_ConnectionLost(sender, data);

            #region User Code
            throw new NotImplementedException("FdAmb_ConnectionLost");
            #endregion //User Code
        }
        // FdAmb_FederationExecutionsReported
        public override void FdAmb_FederationExecutionsReported(object sender, HlaFederationManagementEventArgs data)
        {
            // Call the base class handler
            base.FdAmb_FederationExecutionsReported(sender, data);

            #region User Code
          //  throw new NotImplementedException("FdAmb_FederationExecutionsReported");
            #endregion //User Code
        }
        // FdAmb_OnSynchronizationPointRegistrationConfirmedHandler
        public override void FdAmb_OnSynchronizationPointRegistrationConfirmedHandler(object sender, HlaFederationManagementEventArgs data)
        {
            // Call the base class handler
            base.FdAmb_OnSynchronizationPointRegistrationConfirmedHandler(sender, data);

            #region User Code
            throw new NotImplementedException("FdAmb_OnSynchronizationPointRegistrationConfirmedHandler");
            #endregion //User Code
        }
        // FdAmb_OnSynchronizationPointRegistrationFailedHandler
        public override void FdAmb_OnSynchronizationPointRegistrationFailedHandler(object sender, HlaFederationManagementEventArgs data)
        {
            // Call the base class handler
            base.FdAmb_OnSynchronizationPointRegistrationFailedHandler(sender, data);

            #region User Code
            throw new NotImplementedException("FdAmb_OnSynchronizationPointRegistrationFailedHandler");
            #endregion //User Code
        }
        // FdAmb_SynchronizationPointAnnounced
        public override void FdAmb_SynchronizationPointAnnounced(object sender, HlaFederationManagementEventArgs data)
        {
            // Call the base class handler
            base.FdAmb_SynchronizationPointAnnounced(sender, data);

            #region User Code
            throw new NotImplementedException("FdAmb_SynchronizationPointAnnounced");
            #endregion //User Code
        }
        // FdAmb_FederationSynchronized
        public override void FdAmb_FederationSynchronized(object sender, HlaFederationManagementEventArgs data)
        {
            // Call the base class handler
            base.FdAmb_FederationSynchronized(sender, data);

            #region User Code
            throw new NotImplementedException("FdAmb_FederationSynchronized");
            #endregion //User Code
        }
        // FdAmb_InitiateFederateSaveHandler
        public override void FdAmb_InitiateFederateSaveHandler(object sender, HlaFederationManagementEventArgs data)
        {
            // Call the base class handler
            base.FdAmb_InitiateFederateSaveHandler(sender, data);

            #region User Code
            throw new NotImplementedException("FdAmb_InitiateFederateSaveHandler");
            #endregion //User Code
        }
        // FdAmb_FederationSaved
        public override void FdAmb_FederationSaved(object sender, HlaFederationManagementEventArgs data)
        {
            // Call the base class handler
            base.FdAmb_FederationSaved(sender, data);

            #region User Code
            throw new NotImplementedException("FdAmb_FederationSaved");
            #endregion //User Code
        }
        // FdAmb_FederationSaveStatusResponse
        public override void FdAmb_FederationSaveStatusResponse(object sender, HlaFederationManagementEventArgs data)
        {
            // Call the base class handler
            base.FdAmb_FederationSaveStatusResponse(sender, data);

            #region User Code
            throw new NotImplementedException("FdAmb_FederationSaveStatusResponse");
            #endregion //User Code
        }
        // FdAmb_ConfirmFederationRestorationRequestHandler
        public override void FdAmb_ConfirmFederationRestorationRequestHandler(object sender, HlaFederationManagementEventArgs data)
        {
            // Call the base class handler
            base.FdAmb_ConfirmFederationRestorationRequestHandler(sender, data);

            #region User Code
            throw new NotImplementedException("FdAmb_ConfirmFederationRestorationRequestHandler");
            #endregion //User Code
        }
        // FdAmb_FederationRestoreBegun
        public override void FdAmb_FederationRestoreBegun(object sender, HlaFederationManagementEventArgs data)
        {
            // Call the base class handler
            base.FdAmb_FederationRestoreBegun(sender, data);

            #region User Code
            throw new NotImplementedException("FdAmb_FederationRestoreBegun");
            #endregion //User Code
        }
        // FdAmb_InitiateFederateRestoreHandler
        public override void FdAmb_InitiateFederateRestoreHandler(object sender, HlaFederationManagementEventArgs data)
        {
            // Call the base class handler
            base.FdAmb_InitiateFederateRestoreHandler(sender, data);

            #region User Code
            throw new NotImplementedException("FdAmb_InitiateFederateRestoreHandler");
            #endregion //User Code
        }
        // FdAmb_FederationRestored
        public override void FdAmb_FederationRestored(object sender, HlaFederationManagementEventArgs data)
        {
            // Call the base class handler
            base.FdAmb_FederationRestored(sender, data);

            #region User Code
            throw new NotImplementedException("FdAmb_FederationRestored");
            #endregion //User Code
        }
        // FdAmb_FederationRestoreStatusResponse
        public override void FdAmb_FederationRestoreStatusResponse(object sender, HlaFederationManagementEventArgs data)
        {
            // Call the base class handler
            base.FdAmb_FederationRestoreStatusResponse(sender, data);

            #region User Code
            throw new NotImplementedException("FdAmb_FederationRestoreStatusResponse");
            #endregion //User Code
        }
        #endregion //Federation Management Callbacks
        #region Declaration Management Callbacks
        // FdAmb_StartRegistrationForObjectClassAdvisedHandler
        public override void FdAmb_StartRegistrationForObjectClassAdvisedHandler(object sender, HlaDeclarationManagementEventArgs data)
        {
            // Call the base class handler
            base.FdAmb_StartRegistrationForObjectClassAdvisedHandler(sender, data);

            #region User Code
            if (data.ObjectClassHandle == Som.BossOC.Handle)
            {
                for (int i = 0; i < manager.BossObjects.Count; i++)
                {
                    RegisterHlaObject(manager.BossObjects[i]);
                }
            }
            //throw new NotImplementedException("FdAmb_StartRegistrationForObjectClassAdvisedHandler");
            #endregion //User Code
        }
        // FdAmb_StopRegistrationForObjectClassAdvisedHandler
        public override void FdAmb_StopRegistrationForObjectClassAdvisedHandler(object sender, HlaDeclarationManagementEventArgs data)
        {
            // Call the base class handler
            base.FdAmb_StopRegistrationForObjectClassAdvisedHandler(sender, data);

            #region User Code
            throw new NotImplementedException("FdAmb_StopRegistrationForObjectClassAdvisedHandler");
            #endregion //User Code
        }
        // FdAmb_TurnInteractionsOffAdvisedHandler
        public override void FdAmb_TurnInteractionsOffAdvisedHandler(object sender, HlaDeclarationManagementEventArgs data)
        {
            // Call the base class handler
            base.FdAmb_TurnInteractionsOffAdvisedHandler(sender, data);

            #region User Code
            manager.IsBatleOn = false;
            //throw new NotImplementedException("FdAmb_TurnInteractionsOffAdvisedHandler");
            #endregion //User Code
        }
        // FdAmb_TurnInteractionsOnAdvisedHandler
        public override void FdAmb_TurnInteractionsOnAdvisedHandler(object sender, HlaDeclarationManagementEventArgs data)
        {
            // Call the base class handler
            base.FdAmb_TurnInteractionsOnAdvisedHandler(sender, data);

            #region User Code
            manager.IsBatleOn = true;
            //throw new NotImplementedException("FdAmb_TurnInteractionsOnAdvisedHandler");
            #endregion //User Code
        }
        #endregion //Declaration Management Callbacks
        #region Object Management Callbacks
        // FdAmb_ObjectDiscoveredHandler
        public override void FdAmb_ObjectDiscoveredHandler(object sender, HlaObjectEventArgs data)
        {
            // Call the base class handler
            base.FdAmb_ObjectDiscoveredHandler(sender, data);
            if (data.ClassHandle == Som.PlayerOC.Handle) 
            {
                // Create and add a new player to the list
                CPlayerHlaObject newPlayer = new CPlayerHlaObject(data.ObjectInstance);
                newPlayer.Type = Som.PlayerOC;
                RequestAttributeValueUpdate(newPlayer, string.Empty);
                manager.PlayerObjects.Add(newPlayer);
                Program.playersAlive++;
                initialization = true;
                // Request Update Values of Attributes        
                //  List<HlaAttribute> attributes = new List<HlaAttribute>();
                //  attributes.Add(Som.PlayerOC.Lives);
                //  RequestAttributeValueUpdate(newPlayer, attributes);
                

            }

            #region User Code
            //throw new NotImplementedException("FdAmb_ObjectDiscoveredHandler");
            #endregion //User Code
        }
        // FdAmb_ObjectRemovedHandler
        public override void FdAmb_ObjectRemovedHandler(object sender, HlaObjectEventArgs data)
        {
            // Call the base class handler
            base.FdAmb_ObjectRemovedHandler(sender, data);

            #region User Code
            // MUST DO
            Console.WriteLine("\n A federate has disconnect... Terminating! \n");
            Program.finished = true;
            //throw new NotImplementedException("FdAmb_ObjectRemovedHandler");
            #endregion //User Code
        }
        // FdAmb_AttributeValueUpdateRequestedHandler
        public override void FdAmb_AttributeValueUpdateRequestedHandler(object sender, HlaObjectEventArgs data)
        {
            // Call the base class handler
            base.FdAmb_AttributeValueUpdateRequestedHandler(sender, data);

            #region User Code
            if (data.ObjectInstance.Handle == manager.BossObjects[0].Handle)
            {
                // Get parameter values
                // 1st method
                // First check wheather the attr is updated or not. Result returns 0/null if the updated attribute set does not contain the attr and its value 
                if (initialization)
                {
                    manager.federate.UpdateName(manager.BossObjects[0]);
                    initialization = false;
                }
                else {
                    Program.playersAlive  = 0;
                    foreach (CPlayerHlaObject player in manager.PlayerObjects)
                    {
                        if (player.Player.Lives > 0)
                            Program.playersAlive++;
                    }
                    rounds++;
   
                    if (rounds < 9 && Program.playersAlive > 0)
                    {
                        if (rounds == 1)
                            Program.startTime = DateTime.Now.TimeOfDay.TotalSeconds;
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.WriteLine(
                          "***************************************************************************\n"
                          + "                             " + "Round " + rounds + "\n"
                          + "***************************************************************************");
                        
                        Console.WriteLine("Time Stamp: " + DateTime.Now.TimeOfDay.Hours + ":" +
                            DateTime.Now.TimeOfDay.Minutes + ":" +DateTime.Now.TimeOfDay.Seconds);
                        manager.BossObjects[0].Boss.attack();
                        Console.ForegroundColor = ConsoleColor.Magenta;
                        Console.WriteLine(Program.AttackMessage(manager.BossObjects[0].Boss.Action));
                        Console.ResetColor();
                        SendMessage(Program.AttackMessage(manager.BossObjects[0].Boss.Action), 0);
                        UpdateAction(manager.BossObjects[0]);
                       
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.WriteLine(
                        "***************************************************************************\n"
                        + "                             " + "Results" + "\n" +
                        "***************************************************************************");
                        if (Program.playersAlive > 0)
                        {
                            Console.ForegroundColor = ConsoleColor.DarkCyan;
                            Console.WriteLine("\nDiablo has been defeated!\nWinners:\n");
                            foreach (CPlayerHlaObject player in manager.PlayerObjects)
                            {
                                if (player.Player.Lives > 0)
                                    Console.WriteLine(player.Player.PName + "\n");

                            }
                            Console.ForegroundColor = ConsoleColor.Yellow;
                            Console.WriteLine("\nElapsed time in seconds = " + (DateTime.Now.TimeOfDay.TotalSeconds - Program.startTime));
                            SendMessage("Players Won", 1);
                        }
                        else
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("Diablo has triumphed...");
                            Console.ForegroundColor = ConsoleColor.Yellow;
                            Console.WriteLine("\nElapsed time in seconds = " + (DateTime.Now.TimeOfDay.TotalSeconds - Program.startTime));
                            SendMessage("Diablo Won", 0);
                        }
                        Program.finished = true;

                    }
                    
                }

                //   ViewText = "NickName: " + user.NickName + ". Status: " + user.Status + ". Update reason: " + data.Tag.GetData<string>() + Environment.NewLine;
            }
            //throw new NotImplementedException("FdAmb_AttributeValueUpdateRequestedHandler");
            #endregion //User Code
        }
        // FdAmb_ObjectAttributesReflectedHandler
        public override void FdAmb_ObjectAttributesReflectedHandler(object sender, HlaObjectEventArgs data)
        {
            // Call the base class handler
            base.FdAmb_ObjectAttributesReflectedHandler(sender, data);

            #region User Code
            // User code
            foreach (var player in manager.PlayerObjects)
            {
                // Find the Object
                if (data.ObjectInstance.Handle == player.Handle)
                {
                    // Get parameter values
                    // 1st method
                    // First check wheather the attr is updated or not. Result returns 0/null if the updated attribute set does not contain the attr and its value 
                    if (data.IsValueUpdated(Som.PlayerOC.PName))
                    {
                        player.Player.PName = data.GetAttributeValue<string>(Som.PlayerOC.PName);
                        Program.nameUpdate++;
                    }
                    if (data.IsValueUpdated(Som.PlayerOC.Dodge))
                    {
                        player.Player.Dodge = data.GetAttributeValue<bool>(Som.PlayerOC.Dodge);
                        if (Program.startAttacking && Program.reacting < Program.playersAlive)
                        {
                            
                            if (player.Player.Dodge)
                            {
                                Console.ForegroundColor = ConsoleColor.DarkCyan;
                                Console.WriteLine(player.Player.PName + " has succeeded in dodging the attack!");
                            }
                            else
                            {
                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.WriteLine(player.Player.PName + " has failed in dodging the attack...");
                            }
                            Console.ResetColor();

                            if (data.IsValueUpdated(Som.PlayerOC.Lives))
                            {
                                player.Player.Lives = data.GetAttributeValue<int>(Som.PlayerOC.Lives);
                                
                                if (player.Player.Lives > 0)
                                {
                                    Console.ForegroundColor = ConsoleColor.DarkCyan;
                                    Console.WriteLine(player.Player.PName + " has survived this round with " + player.Player.Lives + " Lives remaining.");
                                }
                                else
                                {
                                    Console.ForegroundColor = ConsoleColor.Red;
                                    Console.WriteLine(player.Player.PName + " has died...");
                          
                                }
                                Console.ResetColor();
                            }
                        }
                    }
          
                  
                 //   ViewText = "NickName: " + user.NickName + ". Status: " + user.Status + ". Update reason: " + data.Tag.GetData<string>() + Environment.NewLine;
                }
            }
            //throw new NotImplementedException("FdAmb_ObjectAttributesReflectedHandler");
            #endregion //User Code
        }
        // FdAmb_InteractionReceivedHandler
        public override void FdAmb_InteractionReceivedHandler(object sender, HlaInteractionEventArgs data)
        {
            // Call the base class handler
            base.FdAmb_InteractionReceivedHandler(sender, data);

            #region User Code

            //throw new NotImplementedException("FdAmb_InteractionReceivedHandler");
            if (data.Interaction.ClassHandle == Som.BattleLogIC.Handle)
            {
                string sentBy = "";
                string msg = "";
                int amount = 0;

                // Get parameter values
                // 1st Method: Check which parameter is updated
                if (data.IsValueUpdated(Som.BattleLogIC.type) && data.GetParameterValue<int>(Som.BattleLogIC.type) == 2)
                    sentBy = "Players";
                if (data.IsValueUpdated(Som.BattleLogIC.message))
                    msg = data.GetParameterValue<string>(Som.BattleLogIC.message);
                if (data.IsValueUpdated(Som.BattleLogIC.amount))
                    amount = data.GetParameterValue<int>(Som.BattleLogIC.amount);

                

                var handle = data.SupplementalReceiveInfo.ProducingFederateHandle; // returns the federate handle of the federate, which produces this message
                var retractionHandle = data.RetractionHandle; // returns event retraction handle in acse of a TSO message

               // Console.WriteLine($"BattleLog: From: {sentBy} > {msg}\n Players still alive: {amount}" + Environment.NewLine);


                #endregion //User Code
            }
        }
        #endregion //Object Management Callbacks
        #region Ownership Management Callbacks
        // FdAmb_AttributeOwnershipAssumptionRequested
        public override void FdAmb_AttributeOwnershipAssumptionRequested(object sender, HlaOwnershipManagementEventArgs data)
        {
            // Call the base class handler
            base.FdAmb_AttributeOwnershipAssumptionRequested(sender, data);

            #region User Code
            throw new NotImplementedException("FdAmb_AttributeOwnershipAssumptionRequested");
            #endregion //User Code
        }
        // FdAmb_AttributeOwnershipAcquisitionCancellationConfirmed
        public override void FdAmb_AttributeOwnershipAcquisitionCancellationConfirmed(object sender, HlaOwnershipManagementEventArgs data)
        {
            // Call the base class handler
            base.FdAmb_AttributeOwnershipAcquisitionCancellationConfirmed(sender, data);

            #region User Code
            throw new NotImplementedException("FdAmb_AttributeOwnershipAcquisitionCancellationConfirmed");
            #endregion //User Code
        }
        // FdAmb_AttributeOwnershipUnavailable
        public override void FdAmb_AttributeOwnershipUnavailable(object sender, HlaOwnershipManagementEventArgs data)
        {
            // Call the base class handler
            base.FdAmb_AttributeOwnershipUnavailable(sender, data);

            #region User Code
            throw new NotImplementedException("FdAmb_AttributeOwnershipUnavailable");
            #endregion //User Code
        }
        // FdAmb_AttributeOwnershipDivestitureNotified
        public override void FdAmb_AttributeOwnershipDivestitureNotified(object sender, HlaOwnershipManagementEventArgs data)
        {
            // Call the base class handler
            base.FdAmb_AttributeOwnershipDivestitureNotified(sender, data);

            #region User Code
            throw new NotImplementedException("FdAmb_AttributeOwnershipDivestitureNotified");
            #endregion //User Code
        }
        // FdAmb_AttributeOwnershipAcquisitionNotified
        public override void FdAmb_AttributeOwnershipAcquisitionNotified(object sender, HlaOwnershipManagementEventArgs data)
        {
            // Call the base class handler
            base.FdAmb_AttributeOwnershipAcquisitionNotified(sender, data);

            #region User Code
            throw new NotImplementedException("FdAmb_AttributeOwnershipAcquisitionNotified");
            #endregion //User Code
        }
        // FdAmb_AttributeOwnershipInformed
        public override void FdAmb_AttributeOwnershipInformed(object sender, HlaOwnershipManagementEventArgs data)
        {
            // Call the base class handler
            base.FdAmb_AttributeOwnershipInformed(sender, data);

            #region User Code
            throw new NotImplementedException("FdAmb_AttributeOwnershipInformed");
            #endregion //User Code
        }
        // FdAmb_AttributeOwnershipReleaseRequestedHandler
        public override void FdAmb_AttributeOwnershipReleaseRequestedHandler(object sender, HlaOwnershipManagementEventArgs data)
        {
            // Call the base class handler
            base.FdAmb_AttributeOwnershipReleaseRequestedHandler(sender, data);

            #region User Code
            throw new NotImplementedException("FdAmb_AttributeOwnershipReleaseRequestedHandler");
            #endregion //User Code
        }
        // FdAmb_RequestDivestitureConfirmation
        public override void FdAmb_RequestDivestitureConfirmation(object sender, HlaOwnershipManagementEventArgs data)
        {
            // Call the base class handler
            base.FdAmb_RequestDivestitureConfirmation(sender, data);

            #region User Code
            throw new NotImplementedException("FdAmb_RequestDivestitureConfirmation");
            #endregion //User Code
        }
        #endregion //Ownership Management Callbacks
        #region Time Management Callbacks
        // FdAmb_TimeRegulationEnabled
        public override void FdAmb_TimeRegulationEnabled(object sender, HlaTimeManagementEventArgs data)
        {
            // Call the base class handler
            base.FdAmb_TimeRegulationEnabled(sender, data);

            #region User Code
            throw new NotImplementedException("FdAmb_TimeRegulationEnabled");
            #endregion //User Code
        }
        // FdAmb_TimeConstrainedEnabled
        public override void FdAmb_TimeConstrainedEnabled(object sender, HlaTimeManagementEventArgs data)
        {
            // Call the base class handler
            base.FdAmb_TimeConstrainedEnabled(sender, data);

            #region User Code
            throw new NotImplementedException("FdAmb_TimeConstrainedEnabled");
            #endregion //User Code
        }
        // FdAmb_TimeAdvanceGrant
        public override void FdAmb_TimeAdvanceGrant(object sender, HlaTimeManagementEventArgs data)
        {
            // Call the base class handler
            base.FdAmb_TimeAdvanceGrant(sender, data);

            #region User Code
            throw new NotImplementedException("FdAmb_TimeAdvanceGrant");
            #endregion //User Code
        }
        // FdAmb_RequestRetraction
        public override void FdAmb_RequestRetraction(object sender, HlaTimeManagementEventArgs data)
        {
            // Call the base class handler
            base.FdAmb_RequestRetraction(sender, data);

            #region User Code
            throw new NotImplementedException("FdAmb_RequestRetraction");
            #endregion //User Code
        }
        #endregion //Time Management Callbacks
        #endregion //Federate Callback Event Handlers
        #endregion //Event Handlers

    }
}
