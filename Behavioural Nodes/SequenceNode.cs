using Behaviour.Storage;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Behaviour
{
    [CreateAssetMenu(fileName = "Sequence_Node", menuName = "Behaviour_Tree/Sequence_Node", order = 0)]
    public class SequenceNode : CompositeNode
    {
        //Constructor:
        public SequenceNode()
        {
            //Initialise the list of behavioural nodes.
            children = new List<BehaviouralNode> ();
        }

        //Methods:
        /// <summary>Adds specified node as a child node.</summary>
        public void AddChild(BehaviouralNode node) { children.Add(node); }
        /// <summary>Adds specified ndoes as child nodes.</summary>
        public void AddChildren(BehaviouralNode[] nodes) { children.AddRange(nodes); }

        //Derived Methods:
        public override Status Invoke(Blackboard blackboard)
        {
            for(int i = 0; i < children.Count; i++)
            {
                switch(children[i].Invoke(blackboard))
                {
                    case Status.Success: continue; //Continue to the next child if invocation was successful.
                    case Status.Failure: return Status.Failure; //Return failure if the child node fails.
                    case Status.Running: return Status.Running; //Return running if the child node fails.
                    default: return Status.Invalid;
                }
            }

            return Status.Invalid; //No children have been attached to sequence.
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