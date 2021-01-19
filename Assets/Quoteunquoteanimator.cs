using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Quoteunquoteanimator : MonoBehaviour
{
    public SpriteRenderer SR;
    public GameObject Idle;
    public GameObject Falling;
    public GameObject Jumping;
    public GameObject Throwing;
    public bool IsMoving;
    private Rigidbody2D BodyBoi;

    void Start()
    {
        IsMoving = false;
        BodyBoi = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        if (BodyBoi.velocity.x > 0)
        {
            SR.enabled = true;
            Idle.active = false;
            Falling.active = false;
            Jumping.active = false;
            Throwing.active = false;
        }

        else if (BodyBoi.velocity.x < 0)
        {
            SR.enabled = true;
            Idle.active = false;
            Falling.active = false;
            Jumping.active = false;
            Throwing.active = false;
        }

        else
        {
            SR.enabled = false;
            Idle.active = true;
            Falling.active = false;
            Jumping.active = false;
            Throwing.active = false;
        }

        if(BodyBoi.velocity.y < 0)
        {
            SR.enabled = false;
            Idle.active = false;
            Falling.active = true;
            Jumping.active = false;
            Throwing.active = false;
        }

        else if(BodyBoi.velocity.y > 0)
        {
            SR.enabled = false;
            Idle.active = false;
            Falling.active = false;
            Jumping.active = true;
            Throwing.active = false;
        }

        if (Input.GetButton("Fire2"))
        {
            SR.enabled = false;
            Idle.active = false;
            Falling.active = false;
            Jumping.active = false;
            Throwing.active = true;
        }

        if (Input.GetButtonUp("Fire2"))
        {
            SR.enabled = false;
            Idle.active = false;
            Falling.active = false;
            Jumping.active = false;
            Throwing.active = true;
        }
    }

    
}
