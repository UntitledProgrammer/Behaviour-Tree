using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Behaviour.Storage
{
    public class Blackboard
    {
        //Attributes:
        Dictionary<string, Board> boards;

        //Methods:
        public void Set<Type>(string key, Type value) { boards[key] = new GenericBoard<Type>(key, value); }
        public Type Get<Type>(string key)
        {
            if (!boards.ContainsKey(key)) return default;
            //return (boards[key]) as GenericBoard<Type>        }
            return default;
        }
    }
}