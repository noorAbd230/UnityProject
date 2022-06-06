using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovment : MonoBehaviour
{
    [SerializeField] float playerSpeed = 4;
    [SerializeField] float jumpForce = 200;

    //private bool canJump = false;
    private Rigidbody2D rb;
    private Animator anim;
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        HorizontalMovment();
        
    }

    void HorizontalMovment()
    {
        float value = Input.GetAxis("Horizontal");
        transform.Translate(new Vector2(value, 0) * playerSpeed * Time.deltaTime);

        if (value > 0)
        {
            transform.localScale = new Vector2(1, 1);
        }else if (value < 0)
        {
            transform.localScale = new Vector2(-1, 1);
        }

        if (value != 0 && rb.velocity.y == 0)
        {
            anim.SetInteger("PlayerState", 1);
        }
        else
        {
            CheckJump();
        }

        





    }

    void CheckJump()
    {
        if (Input.GetKeyDown(KeyCode.UpArrow) && rb.velocity.y == 0)
        {
            rb.AddForce(new Vector2(0, jumpForce));
        }
        if (rb.velocity.y > 0)
        {
            anim.SetInteger("PlayerState", 2);
        }
        if (rb.velocity.y == 0)
        {
            anim.SetInteger("PlayerState", 0);
        }
        if (rb.velocity.y < 0)
        {
            anim.SetInteger("PlayerState", 3);
        }

    }

   /* private void OnCollisionEnter2D(Collision2D collision)
    {
        GameObject other = collision.collider.gameObject;
        if(other.tag == "solid")
        {
            Vector2 point = collision.contacts[0].normal;

            if (point.y > 0)
            {
                canJump = true;
            }
        }

    }*/
}
