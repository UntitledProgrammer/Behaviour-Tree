using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// https://www.gamedeveloper.com/programming/behavior-trees-for-ai-how-they-work
/// </summary>
namespace Behaviour
{
    public class BehaviourTree
    {
        //Attributes:
        private BehaviouralNode root;

        //Constructor:
        public BehaviourTree(BehaviouralNode root)
        {
            this.root = root;
        }

        //Methods:
        public void Tick()
        {
            if (root == null) return;

            root.Invoke();
        }
    }
}