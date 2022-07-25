using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Behaviour.Storage
{
    public abstract class Board
    {
        //Constructor:
        public Board() { }
    }

    public class GenericBoard<Type> : Board
    {
        //Attributes:
        public Type value;
        private string key;

        //Constructor:
        public GenericBoard(string key, Type value)
        {
            this.key = key;
            this.value = value;
        }

        //Methods:
        public void SetValue(Type value) { this.value = value; }

        public string GetKey() { return key; }
        public Type GetValue() { return value; }
    }
}
