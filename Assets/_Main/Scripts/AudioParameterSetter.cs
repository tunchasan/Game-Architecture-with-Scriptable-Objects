using Project.Architecture;
using Project.Architecture.ScriptableObjects.Variables;
using UnityEngine;
using UnityEngine.Audio;

namespace Project
{
    public class AudioParameterSetter : MonoBehaviour
    {
        [Tooltip("Mixer to set the parameter in.")]
        [SerializeField] private AudioMixer mixer;

        [SerializeField] private string parameterName = "";

        [Tooltip("Variable to send to the mixer parameter.")]
        [SerializeField] private FloatVariable variable;

        [Tooltip("Curve to evaluate in order to look up a final value to send as the parameter.\n" +
                 "T=0 is when Variable == Min\n" +
                 "T=1 is when Variable == Max")]
        [SerializeField] private AnimationCurve curve;

        private void Update()
        {
            var t = Mathf.InverseLerp(0, 20, variable);
            var value = curve.Evaluate(Mathf.Clamp01(t));
            mixer.SetFloat(parameterName, value);
        }
    }
}