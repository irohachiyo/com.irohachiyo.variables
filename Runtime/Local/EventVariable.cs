using UnityEngine;

public class EventVariable : VariableMonoBehaviour
{
    public delegate void EventHandler(GameObject arg);

    private event EventHandler value;

    public event EventHandler Value
    {
        add => this.value += value;
        remove => this.value -= value;
    }

    public void InvokeEvent(GameObject arg = null)
    {
        value?.Invoke(arg);
    }

#if UNITY_EDITOR
    [Header("Debug")]
    [SerializeField] private bool debugTrigger;
    [SerializeField] private GameObject debugArg;

    private void Update()
    {
        if (debugTrigger)
        {
            debugTrigger = false;
            InvokeEvent(debugArg);
        }
    }
#endif
}
