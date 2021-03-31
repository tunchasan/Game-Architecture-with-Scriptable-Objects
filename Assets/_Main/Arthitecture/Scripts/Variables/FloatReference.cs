using System;
using Project.Architecture.ScriptableObjects.Variables;

namespace Project.Architecture
{
    [Serializable]
    public class FloatReference
    {
        public FloatVariable Variable;
        
        public FloatReference(){}

        public float Value => Variable;
    }
}