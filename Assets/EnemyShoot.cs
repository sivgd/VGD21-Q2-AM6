using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyShoot : MonoBehaviour
{
    public Transform Shootpoint;
    public GameObject IceBall;
    public float Tick;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Tick += Time.deltaTime;

        if(Tick > 2)
        {
            Shoot();
            Tick = 0;
        }
    }

    void Shoot()
    {
        Instantiate(IceBall, Shootpoint.position, Shootpoint.rotation);
    }
}
