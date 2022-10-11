using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class PlayerMovement : MonoBehaviour
{

    public float playerSpeed = 3.0f; 
    public Rigidbody PlayerRigidbody;
    public LayerMask JumpLayer; // need this is player scrfipt tommorrow
    public Transform groundCheck;// need this
    public float groundDistance = 0.4f;//need this
    bool isGrounded;//need this
    public float playerJumpSpeed = 100f;
    //public static int power = 0;
    bool facingRight = true;
    bool Death = true;
   // public Collider 


    // add animation code under here

    public Animator animator;
    public bool characterMoving = true;


   


    void Start()
    {
        PlayerRigidbody = GetComponent<Rigidbody>();
        //power = 0;
        Death = false;
       // characterMoving = false;
        animator = GetComponentInChildren<Animator>();
    }


    void Update()
    {

        isGrounded = Physics.CheckSphere(groundCheck.position, groundDistance, JumpLayer);//need this for tomorrow add to update

        if (Input.GetKey(KeyCode.A))
        {
            transform.localRotation = Quaternion.Euler(0, 180, 0);
            transform.Translate(Vector2.right * playerSpeed * Time.deltaTime);
            facingRight = false;

            animator.SetBool("IsMoving", true);
           // characterMoving = true;

        }
     
        if (Input.GetKey(KeyCode.D))
        {
            transform.localRotation = Quaternion.Euler(0, 0, 0);
            transform.Translate(Vector2.right * playerSpeed * Time.deltaTime);

            animator.SetBool("IsMoving", true);
            //characterMoving = true;
        }
      
        if (Input.anyKey == false)
        
        {
            animator.SetBool("IsMoving", false);
            animator.SetBool("Jump", false);

        }


        if (Input.GetButtonDown("Jump") && isGrounded )
        {
           
            Vector3 jumpVelocityToAdd = new Vector3(0f, playerJumpSpeed, 0f);
            PlayerRigidbody.velocity += jumpVelocityToAdd;

            animator.SetBool("Jump",true) ;
        }
        //else
       // {
          // animator.SetBool("Jump",false) ;
       // }
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
