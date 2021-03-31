using Project.Architecture.Events;
using UnityEditor;
using UnityEngine;

namespace Project.Architecture.Editor
{
    [CustomEditor(typeof(GameEvent), editorForChildClasses: true)]
    public class EventEditor : UnityEditor.Editor
    {
        public override void OnInspectorGUI()
        {
            base.OnInspectorGUI();

            GUI.enabled = Application.isPlaying;

            var e = target as GameEvent;
            if (GUILayout.Button("Raise"))
                e.Raise();
        }
    }
}