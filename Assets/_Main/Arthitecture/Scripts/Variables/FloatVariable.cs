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

        public float Value => value;

        public void SetValue(float newValue)
        {
            value = newValue;
        }
    }
}

