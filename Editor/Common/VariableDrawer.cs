using UnityEditor;
using UnityEngine;

public static class VariableDrawerHelper
{
    private const int fieldWidth = 60;
    private const int spaceWidth = 1;
    private const int fieldAndSpaceWidth = fieldWidth + spaceWidth;

    public static Rect GetVariableRect(Rect position)
    {
        return new Rect(position.x + fieldAndSpaceWidth, position.y, position.width - fieldAndSpaceWidth, position.height);
    }

    public static Rect GetValueRect(Rect position)
    {
        return new Rect(position.x, position.y, fieldWidth, position.height);
    }

}

public abstract class VariableDrawer : PropertyDrawer
{
    public abstract void DrawDisabledField(Rect rect);

    public override void OnGUI(Rect position, SerializedProperty property, GUIContent label)
    {
        label = EditorGUI.BeginProperty(position, label, property);
        position = EditorGUI.PrefixLabel(position, label);

        var indent = EditorGUI.indentLevel;
        EditorGUI.indentLevel = 0;

        var variableRect = VariableDrawerHelper.GetVariableRect(position);
        var valueRect = VariableDrawerHelper.GetValueRect(position);

        EditorGUI.PropertyField(variableRect, property, GUIContent.none);
        property.serializedObject.ApplyModifiedProperties();

        if (property.objectReferenceValue != null)
        {
            var serializedObject = new SerializedObject(property.objectReferenceValue);
            var serializedProperty = serializedObject.FindProperty("value");
            EditorGUI.PropertyField(valueRect, serializedProperty, GUIContent.none);
            serializedObject.ApplyModifiedProperties();
        }
        else
        {
            EditorGUI.BeginDisabledGroup(true);
            DrawDisabledField(valueRect);
            EditorGUI.EndDisabledGroup();
        }

        EditorGUI.indentLevel = indent;
        EditorGUI.EndProperty();
    }
}
