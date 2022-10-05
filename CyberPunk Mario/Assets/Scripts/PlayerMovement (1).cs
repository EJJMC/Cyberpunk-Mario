using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class PlayerMovement : MonoBehaviour
{

    public float playerSpeed = 3.0f; 
    public Rigidbody2D PlayerRigidbody;
    public LayerMask JumpLayer;
    public Collider2D playerCollider;
    public float playerJumpSpeed = 100f;
    //public static int power = 0;
    bool facingRight = true;
    bool Death = true;
   


    void Start()
    {
        PlayerRigidbody = GetComponent<Rigidbody2D>();
        //power = 0;
        Death = false;
    }


    void Update()
    {
        if (Input.GetKey(KeyCode.A))
        {
            transform.localRotation = Quaternion.Euler(0, 180, 0);
            transform.Translate(Vector2.right * playerSpeed * Time.deltaTime);
            facingRight = false;

        }
        if (Input.GetKey(KeyCode.D))
        {
            transform.localRotation = Quaternion.Euler(0, 0, 0);
            transform.Translate(Vector2.right * playerSpeed * Time.deltaTime);
        }

        if (Input.GetButtonDown("Jump"))
        {
            if (!playerCollider.IsTouchingLayers(JumpLayer))
            {
                return;
            }
            Vector2 jumpVelocityToAdd = new Vector2(0f, playerJumpSpeed);
            PlayerRigidbody.velocity += jumpVelocityToAdd;
        }
    }

    void PlayerFlip()
    {
        facingRight = !facingRight;
        transform.Rotate(0f, 180f, 0f);
    }

    void OnTriggerEnter2D(Collider2D Collision)
    {
       // if (Collision.gameObject.tag == "Enemy")
       // {
          //  playerHealth--;
        //}

        //Power ups
       // if (Collision.tag == "PlayerPowerUps")
        //{
           // power++;

        //}
    }

    void PlayerDie()
    {
        //f (playerHealth == 0 && !Death)
        //{
           // SceneManager.LoadScene("Lose");
            Death = true;
        ///}
    }
}
