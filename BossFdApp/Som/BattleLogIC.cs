// **************************************************************************************************
//		CBattleLogIC
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
  public class CBattleLogIC : HlaInteractionClass
  {
    #region Declarations
    public HlaParameter amount;
    public HlaParameter message;
    public HlaParameter type;
    #endregion //Declarations
    
    #region Constructor
    public CBattleLogIC() : base()
    {
      // Initialize Class Properties
      Name = "HLAinteractionRoot.BattleLog";
      ClassPS = PSKind.PublishSubscribe;
      
      // Create Parameters
      // amount
      amount = new HlaParameter("amount");
      Parameters.Add(amount);
      // message
      message = new HlaParameter("message");
      Parameters.Add(message);
      // type
      type = new HlaParameter("type");
      Parameters.Add(type);
    }
    #endregion //Constructor
  }
}
