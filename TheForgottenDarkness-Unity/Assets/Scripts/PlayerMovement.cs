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
        //move horizontally
        if (Input.GetKey(KeyCode.LeftShift))
        {
            playerRB.velocity = new Vector2(Input.GetAxisRaw("Horizontal") * runSpeed, playerRB.velocity.y);
        } else
        {
            playerRB.velocity = new Vector2(Input.GetAxisRaw("Horizontal") * moveSpeed, playerRB.velocity.y);
        }

        //move vertically 
        if (Input.GetKey(KeyCode.LeftShift))
        {
            playerRB.velocity = new Vector2(playerRB.velocity.x, Input.GetAxisRaw("Vertical") * runSpeed);
        }
        else
        {
            playerRB.velocity = new Vector2(playerRB.velocity.x, Input.GetAxisRaw("Vertical") * moveSpeed);
        }

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
