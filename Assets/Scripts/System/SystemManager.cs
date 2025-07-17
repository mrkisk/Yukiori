using UnityEngine;

namespace Yukiori
{
    public class SystemManager : MonoBehaviour
    {
        private static SystemManager _instance;

        [SerializeField] private SystemLifetimeScope _systemLifetimeScope;

        private void Awake()
        {
            if (_instance == null)
            {
                _instance = this;
                DontDestroyOnLoad(gameObject);
                _systemLifetimeScope.Build();
            }
            else
            {
                Destroy(gameObject);
            }
        }
    }
}
