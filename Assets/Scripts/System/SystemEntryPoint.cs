using VContainer.Unity;

namespace Yukiori
{
    public class SystemEntryPoint : IStartable
    {
        public void Start()
        {
            UnityEngine.Debug.Log("Starting SystemEntryPoint...");
            UnityEngine.Debug.Log($"Initial Scene Path: {PlayModeBootstrapper.InitialScenePath}");
            UnityEngine.SceneManagement.SceneManager.LoadScene(PlayModeBootstrapper.InitialScenePath);
        }
    }
}