using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireballThrow : MonoBehaviour
{
    public Transform firepoint;
    public GameObject fireball;
    public float Ammo;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Fire2") && Ammo > 0)
        {
            
            Shoot();
        }
    }

    void Shoot()
    {
        Instantiate(fireball, firepoint.position, firepoint.rotation);
        Ammo = Ammo - 10;
    }
}
