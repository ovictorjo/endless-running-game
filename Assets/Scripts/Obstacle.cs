using UnityEditor.Animations;
using UnityEngine;

namespace Assets.Scripts
{
    public class Obstacle : MonoBehaviour
    {
        private GameObject player;
        // Start is called before the first frame update
        void Start()
        {
            player = GameObject.FindGameObjectWithTag("Player");
        }

        // Update is called once per frame
        private void OnTriggerEnter2D(Collider2D col)
        {
            if (col.tag == "Border")
            {
                Destroy(this.gameObject);
            }
            
            else if (col.tag == "Player")
            {
                Destroy(player.gameObject);
            }
        }
        
    }
}
