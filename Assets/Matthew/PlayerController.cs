using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float xcl;
    public float jumpforce = 400;
    public float SpeedCap;
    public bool IsGrounded;
    private Rigidbody2D BodyBoi;
    private SpriteRenderer Spr;
    
    void Start()
    {
        BodyBoi = GetComponent<Rigidbody2D>();
        Spr = GetComponent<SpriteRenderer>();
    }

    private void OnTriggerStay2D(Collider2D collision)
    {
        IsGrounded = true;
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        IsGrounded = false;
    }

    void Update()
    {
        if (Input.GetAxis("Horizontal") > 0)
        {
            Spr.flipX = true;
            BodyBoi.AddForce(new Vector2(xcl, 0));

        }

        if (Input.GetAxis("Horizontal") < 0) 
        {
            Spr.flipX = false;
            BodyBoi.AddForce(new Vector2(-xcl, 0));
        }

        if (BodyBoi.velocity.x > SpeedCap)
        {
            BodyBoi.velocity = new Vector2(SpeedCap, BodyBoi.velocity.y);
        }
        if (BodyBoi.velocity.x < -SpeedCap)
        {
            BodyBoi.velocity = new Vector2(-SpeedCap, BodyBoi.velocity.y);
        }

        if (Input.GetButtonDown("Jump") && IsGrounded == true)
        {
            BodyBoi.AddForce(new Vector2(0, jumpforce));
        }
    }
}
