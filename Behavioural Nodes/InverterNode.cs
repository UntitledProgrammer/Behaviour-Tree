using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Behaviour
{
    /// <summary>An inverter is a decorator node that when invoked returns a status opposite to the result of it's child node.</summary>
    [CreateAssetMenu(fileName = "Inverter_node", menuName = "Behaviour_Tree/Inverter_node")]
    public class InverterNode : DecoratorNode
    {
        //Derived methods:
        public override Status Invoke()
        {
            switch(child.Invoke())
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
