using System.Collections;
using System.Collections.Generic;
using Project;
using Project.Architecture;
using UnityEngine;

namespace Project
{
    [RequireComponent(typeof(PlayerController))]
    public class Player : MonoBehaviour
    {
        [SerializeField] private FloatReference Health;
    }
}


