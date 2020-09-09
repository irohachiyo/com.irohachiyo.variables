using UnityEditor;
using UnityEngine;

[CustomPropertyDrawer(typeof(GlobalBoolVariable))]
public class GlobalBoolVariableDrawer : VariableDrawer
{
    public override void DrawDisabledField(Rect rect)
    {
        EditorGUI.Toggle(rect, false);
    }
}
