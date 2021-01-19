using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public float xcl;
    public float SpeedCap;
    private Rigidbody2D BodyBoi;


    void Start()
    {
        BodyBoi = GetComponent<Rigidbody2D>();
    }

    
    void Update()
    {
        

        

        if (BodyBoi.velocity.x > SpeedCap)
        {
            BodyBoi.velocity = new Vector2(SpeedCap, BodyBoi.velocity.y);
        }
        if (BodyBoi.velocity.x < -SpeedCap)
        {
            BodyBoi.velocity = new Vector2(-SpeedCap, BodyBoi.velocity.y);
        }
    }
    private void OnTriggerEnter2D(Collider2D wall)
    {
        if(wall.tag == "Bounding1")
        {
            

            BodyBoi.AddForce(new Vector2(-xcl, 0));
        }

        if (wall.tag == "Bounding2")
        {
            

            BodyBoi.AddForce(new Vector2(xcl, 0));
        }
    }

   
}
