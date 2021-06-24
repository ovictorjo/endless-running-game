using UnityEngine;
using UnityEngine.SceneManagement;
namespace Assets.Scripts
{
    public class GameOver : MonoBehaviour
    {
        public GameObject gamerOverPanel;
        
        // Update is called once per frame
        void Update()
        {
            if (GameObject.FindGameObjectWithTag("Player") == null)
            {
                gamerOverPanel.SetActive(true);
            }
        }

        public void Restart()
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }
    }
}
