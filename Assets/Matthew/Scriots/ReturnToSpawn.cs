using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ReturnToSpawn : MonoBehaviour
{
    public Transform Spawnpoint;
    public GameObject Player;
    void Start()
    {

    }

    // Update is called once per frame
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Return")
        {
            Player.transform.position = Spawnpoint.position;
        }
    }
}
