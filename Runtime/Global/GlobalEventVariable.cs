using UnityEngine;

[CreateAssetMenu(menuName = "Variables/Event Variable")]
public class GlobalEventVariable : ScriptableObject
{
    public delegate void EventHandler(GameObject arg);

    private event EventHandler value;

    public event EventHandler Value
    {
        add => this.value += value;
        remove => this.value -= value;
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
