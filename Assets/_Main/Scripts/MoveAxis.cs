using System;
using UnityEngine;

namespace Project
{
    [Serializable]
    public class MoveAxis
    {
        private KeyCode _positive;
        private KeyCode _negative;

        public MoveAxis(KeyCode positive, KeyCode negative)
        {
            _positive = positive;
            _negative = negative;
        }

        public static implicit operator float(MoveAxis axis)
        {
            return (Input.GetKey(axis._positive)
                       ? 1.0f : 0.0f) -
                   (Input.GetKey(axis._negative)
                       ? 1.0f : 0.0f);
        }
    }
}