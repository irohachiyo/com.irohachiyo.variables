using UnityEngine;
using UnityEngine.Events;

public class UnityEventVariable : VariableMonoBehaviour
{
    [SerializeField] private UnityEvent value;

    public event UnityAction Value
    {
        add => this.value.AddListener(value);
        remove => this.value.RemoveListener(value);
    }

    public void InvokeEvent()
    {
        value.Invoke();
    }
}
