using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Project.Architecture.ScriptableObjects.Variables
{
    [CreateAssetMenu]
    public class FloatVariable : ScriptableObject
    {
        [SerializeField] private string description;

        [SerializeField] private float value;

        public void SetValue(float newValue)
        {
            value = newValue;
        }
        
        public static implicit operator float(FloatVariable reference)
        {
            return reference.value;
        }

        public void ApplyChange(float applyValue)
        {
            value += applyValue;
        }
    }
}


