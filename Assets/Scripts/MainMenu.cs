using UnityEngine;
using UnityEngine.SceneManagement;

namespace Assets.Scripts
{
    public class MainMenu : MonoBehaviour
    {
        public void PlayGame(string LevelName)
        {
            SceneManager.LoadScene(LevelName);
        }

        public void QuitGame()
        {
            Debug.Log("QUIT!");
            Application.Quit();
        }
        
    }
}
