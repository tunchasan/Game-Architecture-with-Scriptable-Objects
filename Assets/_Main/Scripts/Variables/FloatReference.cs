using Project.Architecture.ScriptableObjects.Variables;

namespace Project.Architecture
{
    public class FloatReference
    {
        public FloatVariable Variable;
        
        public FloatReference(){}

        public float Value => Variable.Value;
    }
}