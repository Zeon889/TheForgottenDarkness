using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    private Rigidbody2D playerRB;
    private Animator anim;
    private SpriteRenderer playerSR;

    public float moveSpeed;
    public float runSpeed;

    public float horizontalInput;
    public float verticalInput;

    // Start is called before the first frame update
    void Start()
    {
        playerRB = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
        playerSR = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        horizontalInput = Input.GetAxis("Horizontal");
        verticalInput = Input.GetAxis("Vertical");

        if (Input.GetKey(KeyCode.LeftShift))
        {
            transform.Translate(Vector3.forward * Time.deltaTime * verticalInput * runSpeed);
            transform.Translate(Vector3.right * Time.deltaTime * horizontalInput * runSpeed);
        } else
        {
            transform.Translate(Vector3.forward * Time.deltaTime * verticalInput * moveSpeed);
            transform.Translate(Vector3.right * Time.deltaTime * horizontalInput * moveSpeed);
        }
        

        ////move horizontally
        //if (Input.GetKey(KeyCode.LeftShift))
        //{
        //    playerRB.velocity = new Vector2(Input.GetAxisRaw("Horizontal") * runSpeed, playerRB.velocity.y);
        //} else
        //{
        //    playerRB.velocity = new Vector2(Input.GetAxisRaw("Horizontal") * moveSpeed, playerRB.velocity.y);
        //}

        ////move vertically 
        //if (Input.GetKey(KeyCode.LeftShift))
        //{
        //    playerRB.velocity = new Vector3(playerRB.velocity.z, Input.GetAxisRaw("Vertical") * runSpeed);
        //}
        //else
        //{
        //    playerRB.velocity = new Vector3(playerRB.velocity.z, Input.GetAxisRaw("Vertical") * moveSpeed);
        //}

        //flip player
        if (Input.GetAxisRaw("Horizontal") > 0)
        {
            playerSR.flipX = false;
            anim.SetBool("isMoving", true);
        } else if (Input.GetAxisRaw("Horizontal") < 0) 
        {
            playerSR.flipX= true;
            anim.SetBool("isMoving", true);
        } else if (Input.GetAxisRaw("Vertical") < 0 || Input.GetAxisRaw("Vertical") > 0)
        {
            anim.SetBool("isMoving", true);
        } else
        {
            anim.SetBool("isMoving", false);
        }
    }
}
