using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireballThrow : MonoBehaviour
{
    public Transform firepoint;
    public float Ammo;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Fire2)"))
        {
            Shoot();
        }
    }

    void Shoot()
    {

    }
}
