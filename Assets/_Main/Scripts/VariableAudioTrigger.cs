using Project.Architecture.ScriptableObjects.Variables;
using UnityEngine;

namespace Project
{
    public class VariableAudioTrigger : MonoBehaviour
    {
        [SerializeField] private AudioSource audioSource;

        [SerializeField] private FloatVariable variable;

        private void Update()
        {
            if (variable < 20)
            {
                if (!audioSource.isPlaying)
                    audioSource.Play();
            }
            else
            {
                if (audioSource.isPlaying)
                    audioSource.Stop();
            }
        }
    }
}