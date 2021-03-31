using System.Collections;
using System.Collections.Generic;
using Project;
using Project.Architecture;
using Project.Architecture.ScriptableObjects.Variables;
using UnityEngine;

namespace Project
{
    [RequireComponent(typeof(PlayerController))]
    public class Player : MonoBehaviour
    {
        [SerializeField] private FloatReference health;
        
        [SerializeField] private FloatReference speed;

        public FloatVariable Speed => speed.Variable;

        public FloatVariable Health => health.Variable;
    }
}


