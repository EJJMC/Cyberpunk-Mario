using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class PlayerMovement : MonoBehaviour
{

    public float playerSpeed = 3.0f; 
    public Rigidbody PlayerRigidbody;
    public LayerMask JumpLayer;
    public Collider2D playerCollider;
    public float playerJumpSpeed = 100f;
    //public static int power = 0;
    bool facingRight = true;
    bool Death = true;
   


    void Start()
    {
        PlayerRigidbody = GetComponent<Rigidbody>();
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
            Vector3 jumpVelocityToAdd = new Vector3(0f, playerJumpSpeed, 0f);
            PlayerRigidbody.velocity += jumpVelocityToAdd;
        }
    }

    void PlayerFlip()
    {
        facingRight = !facingRight;
        transform.Rotate(0f, 180f, 0f);
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