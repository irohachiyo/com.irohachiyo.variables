using UnityEngine;

public class Variable<T> : VariableMonoBehaviour
{
    [SerializeField] public T value;

    public T Value
    {
        get => value;
        set => this.value = value;
    }
}
