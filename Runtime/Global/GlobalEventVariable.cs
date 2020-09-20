using UnityEngine;

[CreateAssetMenu(menuName = "Variables/Event Variable")]
public class GlobalEventVariable : GlobalVariableScriptableObject
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
    public bool triggerEventOnChange;
    public GameObject debugArg;

    private void Update()
    {
        if (triggerEventOnChange)
        {
            triggerEventOnChange = false;
            value?.Invoke(debugArg);
        }
    }
#endif
}
