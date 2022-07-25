using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>Structures located in the '.Development' namespace are for testing purposes only.</summary>
namespace Behaviour.Development
{
    /// <summary>Debugger successfully logs the 'message' attribute to Unity upon invocation.</summary>
    [CreateAssetMenu(fileName = "Debug_Node", menuName = "Behaviour_Tree/Development/Debug_Node", order = 0)]
    public class DebugNode : Behaviour.BehaviouralNode
    {
        //Attributes:
        public string message = "Default_Message";

        //Derived Methods:
        public override Behaviour.Status Invoke()
        {
            Debug.Log(message);

            return Behaviour.Status.Success;
        }

        public override void Terminate()
        {
            throw new System.NotImplementedException();
        }

        public override void Initialise()
        {
            throw new System.NotImplementedException();
        }
    }
}