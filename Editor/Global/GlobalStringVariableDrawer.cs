using UnityEditor;
using UnityEngine;

[CustomPropertyDrawer(typeof(GlobalStringVariable))]
public class GlobalStringVariableDrawer : VariableDrawer
{
    public override void DrawDisabledField(Rect rect)
    {
        EditorGUI.TextField(rect, "");
    }
}
