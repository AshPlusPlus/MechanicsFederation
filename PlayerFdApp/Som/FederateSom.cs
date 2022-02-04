// **************************************************************************************************
//		FederateSom
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
/// This class is extended from the object model of RACoN API
/// </summary>

// System
using System;
using System.Collections.Generic; // for List
// Racon
using Racon;
using Racon.RtiLayer;
// Application
using MechanicsDesign.Som;


namespace MechanicsDesign.Som
{
  public class FederateSom : Racon.ObjectModel.CObjectModel
  {
    #region Declarations
    #region SOM Declaration
    public MechanicsDesign.Som.CPlayerOC PlayerOC;
    public MechanicsDesign.Som.CBossOC BossOC;
    public MechanicsDesign.Som.CBattleLogIC BattleLogIC;
    #endregion
    #endregion //Declarations
    
    #region Constructor
    public FederateSom() : base()
    {
      // Construct SOM
      PlayerOC = new MechanicsDesign.Som.CPlayerOC();
      AddToObjectModel(PlayerOC);
      BossOC = new MechanicsDesign.Som.CBossOC();
      AddToObjectModel(BossOC);
      BattleLogIC = new MechanicsDesign.Som.CBattleLogIC();
      AddToObjectModel(BattleLogIC);
    }
    #endregion //Constructor
  }
}
