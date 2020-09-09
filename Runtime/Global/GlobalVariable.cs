using UnityEngine;

public class GlobalVariable<T> : GlobalVariableScriptableObject
{
    [SerializeField] private T value;

    public T Value
    {
        get => value;
        set => this.value = value;
    }
}
