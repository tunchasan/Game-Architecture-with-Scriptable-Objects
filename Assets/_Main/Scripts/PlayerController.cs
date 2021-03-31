using System;
using System.Collections;
using System.Collections.Generic;
using Project.Architecture;
using Project.Interfaces;
using UnityEngine;
using UnityEngine.Events;

namespace Project
{
    public class PlayerController : MonoBehaviour
    {
        [SerializeField] private UnityEvent damageEvent;

        [SerializeField] private UnityEvent deathEvent;
        
        private Player _player = null;

        private MoveAxis _horizontal;

        private MoveAxis _vertical;

        private void Start()
        {
            _player = GetComponent<Player>();
            
            _horizontal = new MoveAxis(KeyCode.D, KeyCode.A);
            
            _vertical = new MoveAxis(KeyCode.W, KeyCode.S);
        }

        private void Update()
        {
            var moveNormal = new Vector3(_horizontal, _vertical, 0.0f).normalized;

            transform.position += moveNormal * (Time.deltaTime * _player.Speed);
        }

        private void OnTriggerEnter(Collider other)
        {
            if (other.TryGetComponent(out ICanDamage actor))
            {
                _player.Health.ApplyChange(-actor.DamageAmount());
                
                damageEvent?.Invoke();

                if (_player.Health <= 0)
                {
                    deathEvent?.Invoke();
                }
            }
        }
    }
}

