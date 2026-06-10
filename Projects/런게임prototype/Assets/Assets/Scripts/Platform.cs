using UnityEngine;

public class Platform : MonoBehaviour {
    public GameObject[] obstacles; 
    private bool stepped = false; 

    private void OnEnable() 
    {

        stepped = false;

    }

    private void OnCollisionEnter2D(Collision2D collision)  
    {

        if(collision.collider.tag == "Player" && !stepped)
        {

            stepped = true;
            GameManager.instance.AddScore(10+(int)Time.time);
            

        }
    }
}