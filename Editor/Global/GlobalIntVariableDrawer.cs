using UnityEditor;
using UnityEngine;

[CustomPropertyDrawer(typeof(GlobalIntVariable))]
public class GlobalIntVariableDrawer : VariableDrawer
{
    public override void DrawDisabledField(Rect rect)
    {
        EditorGUI.IntField(rect, 0);
    }
}
