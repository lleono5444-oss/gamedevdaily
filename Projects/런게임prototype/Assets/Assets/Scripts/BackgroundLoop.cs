using UnityEngine;

namespace RunGame
{
    public class BackgroundLoop : MonoBehaviour
    {
        private float width; 

        private void Awake()
        {
            
            BoxCollider2D backgroundCollider = GetComponent<BoxCollider2D>();
            width = backgroundCollider.size.x;
        }
        
        private void Update()
        {
            
            if (transform.position.x <= -width) Reposition();
        }
        private void Reposition()
        {
            Vector3 offset = new Vector3(width * 2f, 0, 0);
            transform.position = (Vector3)transform.position + offset;
        }



    }
}