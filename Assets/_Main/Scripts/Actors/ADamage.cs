using System.Collections;
using System.Collections.Generic;
using Project.Interfaces;
using UnityEngine;

namespace Project
{
    public class ADamage : MonoBehaviour, ICanDamage
    {
        [SerializeField] private float damageAmount = 10;
    
        public float DamageAmount()
        {
            return damageAmount;
        }
    }
}
