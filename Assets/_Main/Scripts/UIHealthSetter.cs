using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace Project.Architecture
{
    public class UIHealthSetter : MonoBehaviour
    {
        public FloatReference Variable;

        public Image Image;

        private void Update()
        {
            Image.fillAmount = Mathf.Clamp01(Mathf.InverseLerp(0, 100, Variable.Value));
        }
    }
}