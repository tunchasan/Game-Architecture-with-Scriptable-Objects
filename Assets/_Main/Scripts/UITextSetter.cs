using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

namespace Project
{
    public class UITextSetter : MonoBehaviour
    {
        [SerializeField] private TextMeshProUGUI text;

        public void UpdateText(string content)
        {
            text.text = content;
        }
    }
}