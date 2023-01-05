using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Controls : MonoBehaviour
{
   
    public float jumpHeight = 8f;
    public float jump;

  

    public GameObject Character;

    private bool isGrounded;
    public Transform groundCheck;
    private float CheckRadius = 0.1f;
    public LayerMask whatIsGround;


    private Rigidbody2D rb;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
      
    }

    // Update is called once per frame
    void Update()
    {
        
        isGrounded = Physics2D.OverlapCircle(groundCheck.position,CheckRadius,whatIsGround);
       
        //Walking
        if (Input.GetKey(KeyCode.D))
        {
            this.gameObject.transform.Translate(new Vector3(6 * Time.deltaTime, 0, 0));
            this.gameObject.transform.localScale = new Vector3(1f, 1f, 1);
            this.gameObject.GetComponent<Animator>().SetBool("IsWalking", true);
        }

        if (Input.GetKey(KeyCode.A))
        {
            this.gameObject.transform.Translate(new Vector3(-6 * Time.deltaTime, 0, 0));
            this.gameObject.transform.localScale = new Vector3(-1f, 1f, 1);
            this.gameObject.GetComponent<Animator>().SetBool("IsWalking", true);
        }


        //Idle
        if (Input.GetKeyUp(KeyCode.A) || Input.GetKeyUp(KeyCode.D))
        {
            this.gameObject.GetComponent<Animator>().SetBool("IsWalking", false);
        }


        //jumping
        if (Input.GetKeyDown(KeyCode.Space) && jump > 0 )
        {
           
            rb.velocity = Vector2.up * jumpHeight;
            this.gameObject.GetComponent<Animator>().SetBool("Jumping", true);
            jump = 0;
        } 

        if (isGrounded == true)
        {
            this.gameObject.GetComponent<Animator>().SetBool("Jumping", false);
            jump = 2;
        }

    }

    }



