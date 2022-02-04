// **************************************************************************************************
//		CPlayerOC
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
  public class CPlayerOC : HlaObjectClass
  {
    #region Declarations
    public HlaAttribute PName;
    public HlaAttribute Dodge;
    public HlaAttribute Lives;
    public HlaAttribute PId;
    #endregion //Declarations
    
    #region Constructor
    public CPlayerOC() : base()
    {
      // Initialize Class Properties
      Name = "HLAobjectRoot.Player";
      ClassPS = PSKind.Subscribe;
      
      // Create Attributes
      // PName
      PName = new HlaAttribute("PName", PSKind.PublishSubscribe);
      Attributes.Add(PName);
      // Dodge
      Dodge = new HlaAttribute("Dodge", PSKind.PublishSubscribe);
      Attributes.Add(Dodge);
      // Lives
      Lives = new HlaAttribute("Lives", PSKind.PublishSubscribe);
      Attributes.Add(Lives);
      // PId
      PId = new HlaAttribute("PId", PSKind.PublishSubscribe);
      Attributes.Add(PId);
    }
    #endregion //Constructor
  }
}
