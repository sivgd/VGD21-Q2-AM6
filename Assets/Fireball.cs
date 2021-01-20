using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fireball : MonoBehaviour
{
    private Rigidbody2D BodyBoi;
    public float speed;
    public float speed2;
    public float timer;
  
    // Start is called before the first frame update
    void Start()
    {
        BodyBoi = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        BodyBoi.velocity = transform.right * speed;

        Destroy(gameObject, timer);
    }


    private void OnTriggerEnter2D(Collider2D Other)
    {
        Debug.Log("Contact");
        if (Other.tag == "Enemy")
        {

            Destroy(Other.gameObject);

        }



        Destroy(gameObject);
    }
}
