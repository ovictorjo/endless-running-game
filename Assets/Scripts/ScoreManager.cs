using UnityEngine;
using UnityEngine.UI;
namespace Assets.Scripts
{
    public class ScoreManager : MonoBehaviour
    {
        public Text scoreText;

        private float score;
       
        // Update is called once per frame
        void Update()
        {
            if (GameObject.FindGameObjectWithTag("Player") != null)
            {
                score += 1 * Time.deltaTime;
                scoreText.text = ((int) score).ToString();
            }
        }
    }
}
