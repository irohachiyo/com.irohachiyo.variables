using UnityEditor;
using UnityEngine;

[CustomPropertyDrawer(typeof(StringVariable))]
public class StringVariableDrawer : VariableDrawer
{
    public override void DrawDisabledField(Rect rect)
    {
        EditorGUI.TextField(rect, "");
    }
}
