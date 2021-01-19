using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Freeze : MonoBehaviour
{
    public Slider warmthbar;
    public float heatlevel;

     void Update()
    {
        if (Input.GetKeyDown(KeyCode.T))
        {
            warmthbar.value  -= 1;
        }
    }
     void OnCollisionStay2D(Collision2D collision)
    {
        warmthbar.value -= 1;
    }
}
