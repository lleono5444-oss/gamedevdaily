using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerController : MonoBehaviour
{
    
    public float jumpForce = 700f;


    private int jumpCount = 0;
    private bool isGrounded = false;
    private bool isDead = false;

    private Rigidbody2D playerRigidbody;
  

    private void Start()
    {
        playerRigidbody = GetComponent<Rigidbody2D>();
    
    }


     private void Update()
    {
        if (isDead) return;
        if(Mouse.current.leftButton.wasPressedThisFrame && jumpCount < 2)
        {
            jumpCount++;
            playerRigidbody.linearVelocity = Vector3.zero;
            playerRigidbody.AddForce(new Vector3(0, jumpForce));
           
            
        }
        else if(Mouse.current.leftButton.wasReleasedThisFrame && playerRigidbody.linearVelocity.y > 0)
        {
            playerRigidbody.linearVelocity *= 0.5f;
        }
    }

    private void Die()
    {
     
        playerRigidbody.linearVelocity = Vector3.zero;
        isDead = true;
        GameManager.instance.OnplayerDead();
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Dead" && !isDead) Die();

    }
    
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.contacts[0].normal.y > 0.7f)
        {
            isGrounded = true;
            jumpCount = 0;
        }
    }

    private void OnCollisionExit2D(Collision2D collision)
    {
        isGrounded = false;
    }
}