using System;
using System.Collections;
using UnityEngine;

/// <summary>
/// Disabling some mothods/properties to avoid confusion.
/// </summary>
public class VariableMonoBehaviour : MonoBehaviour
{
    private const string message = "You're trying to use a function of a Variable class instead of the actual variable. If it was intentional, then you need to cast Variable component to MonoBehaviour class first.";

    // Properties
    [Obsolete(message, true)] [HideInInspector] public new bool runInEditMode;
    [Obsolete(message, true)] [HideInInspector] public new bool useGUILayout;

    // Public Methods
    [Obsolete(message, true)] public new void CancelInvoke() { }
    [Obsolete(message, true)] public new void Invoke(string methodName, float time) { }
    [Obsolete(message, true)] public new void InvokeRepeating(string methodName, float time, float repeatRate) { }
    [Obsolete(message, true)] public new void IsInvoking(string methodName) { }
    [Obsolete(message, true)] public new void StartCoroutine(IEnumerator x) { }
    [Obsolete(message, true)] public new void StopAllCoroutines() { }
    [Obsolete(message, true)] public new void StopCoroutine(string methodName) { }
    [Obsolete(message, true)] public new void StopCoroutine(IEnumerator routine) { }
    [Obsolete(message, true)] public new void StopCoroutine(Coroutine routine) { }

    // Inherited Properties
    [Obsolete(message, true)] [HideInInspector] public new bool enabled;
    [Obsolete(message, true)] [HideInInspector] public new bool isActiveAndEnabled;
    [Obsolete(message, true)] [HideInInspector] public new bool gameObject;
    [Obsolete(message, true)] [HideInInspector] public new bool tag;
    [Obsolete(message, true)] [HideInInspector] public new bool transform;
    [Obsolete(message, true)] [HideInInspector] public new bool hideFlags;
    [Obsolete(message, true)] [HideInInspector] public new bool name;

    // Inherited Public Methods
    [Obsolete(message, true)] public new void BroadcastMessage(string methodName, object parameter = null, SendMessageOptions options = SendMessageOptions.RequireReceiver) { }
    [Obsolete(message, true)] public new void BroadcastMessage(string methodName, SendMessageOptions options) { }
    [Obsolete(message, true)] public new void CompareTag(string x) { }
    [Obsolete(message, true)] public new void GetComponent(Type type) { }
    [Obsolete(message, true)] public new void GetComponent<T>() { }
    [Obsolete(message, true)] public new void GetComponentInChildren(Type t) { }
    [Obsolete(message, true)] public new void GetComponentInChildren<T>() { }
    [Obsolete(message, true)] public new void GetComponentInParent(Type t) { }
    [Obsolete(message, true)] public new void GetComponentInParent<T>() { }
    [Obsolete(message, true)] public new void GetComponents(Type type) { }
    [Obsolete(message, true)] public new void GetComponents<T>() { }
    [Obsolete(message, true)] public new void GetComponentsInChildren(Type t, bool includeInactive) { }
    [Obsolete(message, true)] public new void GetComponentsInChildren<T>(bool includeInactive) { }
    [Obsolete(message, true)] public new void GetComponentsInParent(Type t, bool includeInactive = false) { }
    [Obsolete(message, true)] public new void GetComponentsInParent<T>(bool includeInactive = false) { }
    [Obsolete(message, true)] public new void SendMessage(string methodName) { }
    [Obsolete(message, true)] public new void SendMessage(string methodName, object value) { }
    [Obsolete(message, true)] public new void SendMessage(string methodName, object value, SendMessageOptions options) { }
    [Obsolete(message, true)] public new void SendMessage(string methodName, SendMessageOptions options) { }
    [Obsolete(message, true)] public new void SendMessageUpwards(string methodName, SendMessageOptions options) { }
    [Obsolete(message, true)] public new void SendMessageUpwards(string methodName, object value = null, SendMessageOptions options = SendMessageOptions.RequireReceiver) { }
    [Obsolete(message, true)] public new void TryGetComponent(Type type, out Component component) { component = null; }
    [Obsolete(message, true)] public new void TryGetComponent<T>(out T component) where T : MonoBehaviour { component = null; }
    [Obsolete(message, true)] public new void GetInstanceID() { }
    [Obsolete(message, true)] public new void ToString() { }

    // Operators
    [Obsolete(message, true)] public static implicit operator bool(VariableMonoBehaviour instance) { return false; }
    [Obsolete(message, true)] public static bool operator !=(VariableMonoBehaviour a, VariableMonoBehaviour b) { return false; }
    [Obsolete(message, true)] public static bool operator ==(VariableMonoBehaviour a, VariableMonoBehaviour b) { return false; }
}
