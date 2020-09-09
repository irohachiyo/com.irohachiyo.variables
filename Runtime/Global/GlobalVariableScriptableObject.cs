using System;
using UnityEngine;

/// <summary>
/// Disabling some mothods/properties to avoid confusion.
/// </summary>
public class GlobalVariableScriptableObject : ScriptableObject
{
    private const string message = "You're trying to use a function of a Variable class instead of the actual variable. If it was intentional, then you need to cast Variable component to ScriptableObject class first.";

    // Inherited properties
    [Obsolete(message, true)] [HideInInspector] public new bool hideFlags;
    [Obsolete(message, true)] [HideInInspector] public new bool name;

    // Inherited Methods
    [Obsolete(message, true)] public new void GetInstanceID() { }
    [Obsolete(message, true)] public new void ToString() { }

    // Operators
    [Obsolete(message, true)] public static implicit operator bool(GlobalVariableScriptableObject instance) { return false; }
    [Obsolete(message, true)] public static bool operator !=(GlobalVariableScriptableObject a, GlobalVariableScriptableObject b) { return false; }
    [Obsolete(message, true)] public static bool operator ==(GlobalVariableScriptableObject a, GlobalVariableScriptableObject b) { return false; }
    [Obsolete(message, true)] public static bool operator !=(GlobalVariableScriptableObject a, ScriptableObject b) { return false; }
    [Obsolete(message, true)] public static bool operator ==(GlobalVariableScriptableObject a, ScriptableObject b) { return false; }
}
