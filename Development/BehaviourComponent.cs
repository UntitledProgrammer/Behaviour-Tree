using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Behaviour.Development
{
    /// <summary>The behaviour component updates a behaviour tree starting with the 'root' attribute.</summary>
    public class BehaviourComponent : MonoBehaviour
    {
        //Attributes:
        public bool loops = false;
        public Behaviour.BehaviouralNode root;
        private Behaviour.BehaviourTree tree;

        //Methods:
        private void Start()
        {
            tree = new Behaviour.BehaviourTree(root);
            tree.Tick();
        }

        private void Update()
        {
            if (loops) tree.Tick();
        }
    }
}
