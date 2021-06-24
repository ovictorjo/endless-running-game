using UnityEngine;

namespace Assets.Scripts
{
    public class CameraMoviment : MonoBehaviour
    {
        public float cameraSpeed;
    
        // Update is called once per frame
        void Update()
        {
            transform.position += new Vector3(cameraSpeed * Time.deltaTime, 0f, 0f);
        }
    }
}
