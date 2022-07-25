using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Behaviour
{
    /// <summary>A decorator is behavioural node that can only have one child node.</summary>
    public abstract class DecoratorNode : BehaviouralNode
    {
        //Attributes:
        public BehaviouralNode child;

        //Constructors:
        public DecoratorNode() { child = null; }
        public DecoratorNode(BehaviouralNode childNode) { child = childNode; }
    }
}