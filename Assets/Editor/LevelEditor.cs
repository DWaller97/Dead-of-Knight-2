using UnityEditor;
public class LevelEditor : EditorWindow
{
    [MenuItem("Window/DoK2/Level Editor")]
    public static void ShowWindow()
    {
        GetWindow<LevelEditor>("Level Editor");
    }

    private void OnGUI()
    {

    }
}
