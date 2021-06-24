using UnityEngine;

namespace Assets.Scripts
{
    public class BackgroundMusic : MonoBehaviour
    {
        private static BackgroundMusic backgroundMusic;
        void Awake()
        {
            if (backgroundMusic == null)
            {
                backgroundMusic = this;
                DontDestroyOnLoad(backgroundMusic);
            }

            else
            {
                Destroy(gameObject);
            }
        }
    }
}
