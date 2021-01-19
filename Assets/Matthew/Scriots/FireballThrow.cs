using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireballThrow : MonoBehaviour
{
    public Transform firepoint;
    public SpriteRenderer SR;
    public GameObject Throwing;
    public float Ammo;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Fire2"))
        {
            Shoot();
        }
    }

    void Shoot()
    {
        SR.enabled = false;
        Throwing.active = true;
    }
}
