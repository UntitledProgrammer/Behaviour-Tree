using Behaviour.Storage;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Behaviour
{
    /// <summary>An inverter is a decorator node that when invoked returns a status opposite to the result of it's child node.</summary>
    [CreateAssetMenu(fileName = "Inverter_Node", menuName = "Behaviour_Tree/Inverter_Node")]
    public class InverterNode : DecoratorNode
    {
        //Derived methods:
        public override Status Invoke(Blackboard blackboard)
        {
            switch(child.Invoke(blackboard))
            {
                case Status.Running: return Status.Running;
                case Status.Failure: return Status.Success;
                default: return Status.Failure;
            }
        }
        public override void Initialise()
        {
            throw new System.NotImplementedException();
        }
        public override void Terminate()
        {
            throw new System.NotImplementedException();
        }
    }
}
