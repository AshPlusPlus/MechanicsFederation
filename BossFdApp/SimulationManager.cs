// **************************************************************************************************
//		CSimulationManager
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
/// The Simulation Manager manages the (multiple) federation execution(s) and the (multiple instances of) joined federate(s).
/// </summary>

// System
using System;
using System.Collections.Generic; // for List
using System.ComponentModel;
// Racon
using Racon;
using Racon.RtiLayer;
// Application
using MechanicsDesign.Som;


namespace MechanicsDesign
{
  public class CSimulationManager
  {
    #region Declarations
    // Communication layer related structures
    public CBossFdApp federate; //Application-specific federate 
                                // Local data structures
                                // TODO: user-defined data structures are declared here
    public bool IsBatleOn = false;
    public BindingList<CBossHlaObject> BossObjects;
    public BindingList<CPlayerHlaObject> PlayerObjects;

        #endregion //Declarations

        #region Constructor
        public CSimulationManager()
    {
      // Initialize the application-specific federate
      federate = new CBossFdApp(this);
      // Initialize the federation execution
      federate.FederationExecution.Name = "MechanicsFederation";
      federate.FederationExecution.FederateType = "BossFederate";
      federate.FederationExecution.ConnectionSettings = "rti://127.0.0.1";
      // Handle RTI type variation
      initialize();

      BossObjects = new BindingList<CBossHlaObject>();
      PlayerObjects = new BindingList<CPlayerHlaObject>();
    }
    #endregion //Constructor
    
    #region Methods
    // Handles naming variation according to HLA specification
    private void initialize()
    {
      switch (federate.RTILibrary)
      {
        case RTILibraryType.HLA13_DMSO: case RTILibraryType.HLA13_Portico: case RTILibraryType.HLA13_OpenRti:
                federate.Som.PlayerOC.Name = "objectRoot.Player";
                federate.Som.PlayerOC.PrivilegeToDelete.Name = "privilegeToDelete";
                federate.Som.BossOC.Name = "objectRoot.Boss";
                federate.Som.BossOC.PrivilegeToDelete.Name = "privilegeToDelete";
                federate.Som.BattleLogIC.Name = "interactionRoot.BattleLog";
                federate.FederationExecution.FDD = @"C:\Users\ahmed\source\repos\BossFdApp\MechanicsFOM.fed";
        break;
        case RTILibraryType.HLA1516e_Portico: case RTILibraryType.HLA1516e_OpenRti:
                federate.Som.PlayerOC.Name = "HLAobjectRoot.Player";
                federate.Som.PlayerOC.PrivilegeToDelete.Name = "HLAprivilegeToDeleteObject";
                federate.Som.BossOC.Name = "HLAobjectRoot.Boss";
                federate.Som.BossOC.PrivilegeToDelete.Name = "HLAprivilegeToDeleteObject";
                federate.Som.BattleLogIC.Name = "HLAinteractionRoot.BattleLog";
                federate.FederationExecution.FDD = @"C:\Users\ahmed\source\repos\BossFdApp\MechanicsFOM.xml";
        break;
      }
    }
    #endregion //Methods
  }
}
