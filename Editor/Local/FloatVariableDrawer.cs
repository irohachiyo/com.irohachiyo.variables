using UnityEditor;
using UnityEngine;

[CustomPropertyDrawer(typeof(FloatVariable))]
public class FloatVariableDrawer : VariableDrawer
{
    public override void DrawDisabledField(Rect rect)
    {
        EditorGUI.FloatField(rect, 0);
    }
}
