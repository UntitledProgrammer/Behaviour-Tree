using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Behaviour
{
    /// <summary>Every behaviour that is invoked must return a status to notify the tree what to do next.</summary>
    public enum Status
    {
        /// <summary>A behavioural node was successfully invoked and completed.</summary>
        Success,
        /// <summary>A behavioural node has failed upon being invoked.</summary>
        Failure,
        /// <summary>A behavioural node is still active and should continue to be invoked again.</summary>
        Running,
        /// <summary>Returned when an unexpected result occurs during a behavioural node's invocation.</summary>
        Invalid
    }
}