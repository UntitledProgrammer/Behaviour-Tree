using Behaviour.Storage;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Behaviour
{
    /// <summary>The behavioural node is an interface that forms the base construction of a behaviour tree and hierarchy.</summary>
    public abstract class BehaviouralNode : ScriptableObject
    {
        //Abstract methods:

        /// <summary>All behaviour and game logic should exist within the scope of the invoke method.</summary>
        public abstract Status Invoke(Blackboard blackboard);
        /// <summary>Invoked when a behaviour has completed it's cycle.</summary>
        public abstract void Terminate();
        /// <summary>Invoked once before a new behaviour is invoked.</summary>
        public abstract void Initialise();
    }
}