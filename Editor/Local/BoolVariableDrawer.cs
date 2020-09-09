using UnityEditor;
using UnityEngine;

[CustomPropertyDrawer(typeof(BoolVariable))]
public class BoolVariableDrawer : VariableDrawer
{
    public override void DrawDisabledField(Rect rect)
    {
        EditorGUI.Toggle(rect, false);
    }
}
