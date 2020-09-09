using UnityEngine;

public class ButtonInputVariable : VariableMonoBehaviour
{
    [SerializeField] private bool isPressed;
    [SerializeField] private bool wasPressedThisFrame;
    [SerializeField] private bool wasReleasedThisFrame;

    public bool IsPressed
    {
        get => isPressed;
        set => isPressed = value;
    }

    public bool WasPressedThisFrame
    {
        get => wasPressedThisFrame;
        set => wasPressedThisFrame = value;
    }

    public bool WasReleasedThisFrame
    {
        get => wasReleasedThisFrame;
        set => wasReleasedThisFrame = value;
    }
}
