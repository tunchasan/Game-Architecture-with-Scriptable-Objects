using System;
using System.Collections;
using System.Collections.Generic;
using Project.Architecture;
using UnityEngine;

namespace Project
{
    public class PlayerController : MonoBehaviour
    {
        [SerializeField] private FloatReference playerSpeed;
        
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

            transform.position += moveNormal * (Time.deltaTime * playerSpeed.Value);
        }
    }
}

