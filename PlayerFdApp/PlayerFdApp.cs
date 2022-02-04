// **************************************************************************************************
//		CPlayerFdApp
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

namespace MechanicsDesign
{
  public partial class CPlayerFdApp : Racon.CGenericFederate
  {
    #region Manually Added Code
    
    // Local Data
    private CSimulationManager manager;
    
    #region Constructor
    public CPlayerFdApp(CSimulationManager parent) : this()
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
            return (SendInteraction(interaction, "Players finished dodging."));
        }

        public void UpdateAll(CPlayerHlaObject player)
        {
            // Add Values
            player.AddAttributeValue(Som.PlayerOC.PId, player.Player.PId);
            player.AddAttributeValue(Som.PlayerOC.PName, player.Player.PName);
            player.AddAttributeValue(Som.PlayerOC.Lives, (uint)player.Player.Lives);
            player.AddAttributeValue(Som.PlayerOC.Dodge, player.Player.Dodge);
            UpdateAttributeValues(player, Tags.updateReflectTag);
        }

        public bool UpdateName(CPlayerHlaObject player)
        {
            player.AddAttributeValue(Som.PlayerOC.PName, player.Player.PName);

            return (UpdateAttributeValues(player, Tags.updateReflectTag));
        }
        public bool UpdateLives (CPlayerHlaObject player)
        {
            player.AddAttributeValue(Som.PlayerOC.Lives, (uint) player.Player.Lives);

            return (UpdateAttributeValues(player, Tags.updateReflectTag));
        }

        public bool UpdateDodge(CPlayerHlaObject player)
        {
            player.AddAttributeValue(Som.PlayerOC.Dodge, player.Player.Dodge);

            return (UpdateAttributeValues(player, Tags.updateReflectTag));
        }


        #endregion

    }
}
