#if UNITY_EDITOR
using UnityEditor;
using UnityEditor.SceneManagement;

namespace Yukiori
{
    [InitializeOnLoad]
    public static class PlayModeBootstrapper
    {
        public static string InitialScenePath = "Assets/Scenes/Title.unity";

        static PlayModeBootstrapper()
        {
            EditorApplication.playModeStateChanged += OnPlayModeStateChanged;
        }

        private static void OnPlayModeStateChanged(PlayModeStateChange state)
        {
            if (state == PlayModeStateChange.ExitingEditMode)
            {
                // 変更シーンの保存確認
                if (!EditorSceneManager.SaveCurrentModifiedScenesIfUserWantsTo())
                {
                    EditorApplication.isPlaying = false;
                    return;
                }

                // 現在開いているシーンパスを保存
                var active = EditorSceneManager.GetActiveScene();
                InitialScenePath = active.path;

                // Preload シーンを単一ロード
                EditorSceneManager.OpenScene("Assets/Scenes/Preload.unity", OpenSceneMode.Single);
            }
        }
    }
}
#endif
