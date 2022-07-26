using Behaviour.Storage;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Behaviour
{
    /// <summary>A selector node is a composite node that will return successfully upon successfull invocation from any of it's child nodes.
    /// A selector node will only return 'failure' in the event all child nodes fail invocation.</summary>
    [CreateAssetMenu(fileName = "Selector_Node", menuName = "Behaviour_Tree/Selector_Node")]
    public class SelectorNode : CompositeNode
    {
        //Derived methods:
        public override Status Invoke(Blackboard blackboard)
        {
            for(int i = 0; i < children.Count; i++)
            {
                if (children[i].Invoke(blackboard) == Status.Success) return Status.Success; //If branch is successfull exit invocation.
            }

            return Status.Failure; //Return failure if all branches fail to invoke.
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