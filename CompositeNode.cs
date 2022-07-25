using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Behaviour
{
    /// <summary>A composite node is a structure with one or more child behavioural nodes.</summary>
    public abstract class CompositeNode : BehaviouralNode
    {
        //Attributes:
        public List<BehaviouralNode> children;
    }
}