using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEditor;
using UnityEngine;

public class Movement : MonoBehaviour
{
    private Rigidbody2D rb2d;
    float Speed = 10;
    float jump = 8f;
    private bool facingRight = true;//
    public float fallMultiplier = 0.1f;//




    void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();


    }
        void Update()
    {
        float moveInput = Input.GetAxis("Horizontal");
        rb2d.velocity = new Vector2(moveInput * Speed, rb2d.velocity.y);

        if (moveInput > 0 && !facingRight)//
        {
            Flip();
        }
        else if (moveInput < 0 && facingRight)
        {
            Flip();
        }//

        if (Input.GetKeyDown(KeyCode.Space))
        {
            rb2d.velocity = new Vector2(rb2d.velocity.x, jump);
    }
        if (rb2d.velocity.y < 0)//
        {
            rb2d.velocity += Vector2.up * Physics2D.gravity.y * (fallMultiplier - 1) * Time.deltaTime;
        }//

    }
    private void Flip()//
    {
        facingRight = !facingRight;
        Vector3 scale = transform.localScale;
        scale.x *= -1;
        transform.localScale = scale;
    }
}

