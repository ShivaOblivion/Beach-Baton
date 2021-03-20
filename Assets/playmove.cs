using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playmove : MonoBehaviour
{
    public float moveSpeed;
    public Rigidbody2D rb;
    private Vector3 velocity = Vector3.zero;
    private bool isJumping = false;
    public float jumpForce;



    void FixedUpdate()
    {
        float horizontalMovement = Input.GetAxis("Horizontal") * moveSpeed * Time.deltaTime;

        if (Input.GetButtonDown("Jump"))
        {
            isJumping = true;
        }

        MovePlayer(horizontalMovement);


    }
    void MovePlayer(float _horizontalMovement)
    {



        Vector3 targetVelocity = new Vector2(_horizontalMovement, rb.velocity.y);
        rb.velocity = Vector3.SmoothDamp(rb.velocity, targetVelocity, ref velocity, .05f);

        if (isJumping)
        {
            rb.AddForce(new Vector2(0f, jumpForce));
            isJumping = false;
        }
    }
}

