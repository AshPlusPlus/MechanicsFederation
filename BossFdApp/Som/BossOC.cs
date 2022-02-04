// **************************************************************************************************
//		CBossOC
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
  public class CBossOC : HlaObjectClass
  {
    #region Declarations
    public HlaAttribute Action;
    public HlaAttribute BName;
    #endregion //Declarations
    
    #region Constructor
    public CBossOC() : base()
    {
      // Initialize Class Properties
      Name = "HLAobjectRoot.Boss";
      ClassPS = PSKind.PublishSubscribe;
      
      // Create Attributes
      // Action
      Action = new HlaAttribute("Action", PSKind.PublishSubscribe);
      Attributes.Add(Action);
      // BName
      BName = new HlaAttribute("BName", PSKind.PublishSubscribe);
      Attributes.Add(BName);
    }
    #endregion //Constructor
  }
}
