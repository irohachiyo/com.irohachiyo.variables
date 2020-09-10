using UnityEngine;

public class Variable<T> : VariableMonoBehaviour
{
    [SerializeField] private T value;

    public T Value
    {
        get => value;
        set => this.value = value;
    }
}
