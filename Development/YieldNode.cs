using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>Structures located in the '.Development' namespace are for testing purposes only.</summary>
namespace Behaviour.Development
{
    /// <summary>YieldNode is designed to return only it's 'status' attribute upon invocation. 
    /// This behaviour was written for the purose of testing out hierarchical logic/flow.</summary>
    [CreateAssetMenu(fileName = "Yield_Node", menuName = "Behaviour_Tree/Development/Yield_Node")]
    public class YieldNode : Behaviour.BehaviouralNode
    {
        //Attributes:
        public Behaviour.Status status = Behaviour.Status.Success;

        //Derived methods:
        public override Behaviour.Status Invoke()
        {
            return status;
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
