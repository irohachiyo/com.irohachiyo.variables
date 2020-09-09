using UnityEditor;
using UnityEngine;

[CustomPropertyDrawer(typeof(IntVariable))]
public class IntVariableDrawer : VariableDrawer
{
    public override void DrawDisabledField(Rect rect)
    {
        EditorGUI.IntField(rect, 0);
    }
}
