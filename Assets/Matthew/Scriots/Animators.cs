using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Animators : MonoBehaviour
{
    public bool IsMoving;
    private Rigidbody2D BodyBoi;
    private Animator Movement;

    void Start()
    {
        BodyBoi = GetComponent<Rigidbody2D>();
        Movement = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (BodyBoi.velocity.x > 0)
        {
            IsMoving = true;
        }

        else if (BodyBoi.velocity.x < 0)
        {
            IsMoving = true;
        }

        else
        {
            IsMoving = false;
        }

        
    }
}
