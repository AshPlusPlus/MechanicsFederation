// **************************************************************************************************
//		CPlayerHlaObject
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
/// This is a wrapper class for local data structures. This class is extended from the object model of RACoN API
/// </summary>

// System
using System;
using System.Collections.Generic; // for List
// Racon
using Racon;
using Racon.RtiLayer;
// Application
using MechanicsDesign.Som;

using BossFdApp.LocalData;


namespace MechanicsDesign.Som
{
  public class CPlayerHlaObject : HlaObject
  {
        #region Declarations
        // TODO: Declare your local object structure here
        // Your_LocalData_Type Data;
        public CPlayer Player;
    #endregion //Declarations
    
    #region Constructor
    public CPlayerHlaObject(HlaObjectClass _type) : base(_type)
    {
            // TODO: Instantiate local data here
            // var Data = new Your_LocalData_Type();
            Player = new CPlayer();
    }
    // Copy constructor - used in callbacks
    public CPlayerHlaObject(HlaObject _obj) : base(_obj)
    {
            // TODO: Instantiate local data here
            // var Data = new Your_LocalData_Type();
            Player = new CPlayer();
    }
    #endregion //Constructor
  }
}
