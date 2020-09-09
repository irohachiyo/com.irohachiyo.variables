using UnityEditor;
using UnityEngine;

[CustomPropertyDrawer(typeof(GlobalFloatVariable))]
public class GlobalFloatVariableDrawer : VariableDrawer
{
    public override void DrawDisabledField(Rect rect)
    {
        EditorGUI.FloatField(rect, 0);
    }
}
