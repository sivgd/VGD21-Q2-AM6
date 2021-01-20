using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireballThrow : MonoBehaviour
{
    public Transform firepoint;
    public GameObject fireball;
    public float Ammo;
    public float Tick;
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

    private void OnTriggerStay2D(Collider2D collision)
    {
        if(collision.tag == "Reload" && Ammo < 100 )
        {
            Tick += Time.deltaTime;
            if(Tick >= 1)
            {
                Ammo = Ammo + 1;
            }
            
        }
    }
}
