using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Behaviour.Storage
{
    public class Blackboard
    {
        //Attributes:
        Dictionary<string, GenericBoard<object>> boards;

        //Methods:
        public void Set(string key, object value) { boards[key] = new GenericBoard<object>(key, value); }
        public Type Get<Type>(string key)
        {
            if (!boards.ContainsKey(key)) return default;
            
            return (Type)boards[key].GetValue();
        }

        public void Empty() { boards.Clear(); }
    }
}