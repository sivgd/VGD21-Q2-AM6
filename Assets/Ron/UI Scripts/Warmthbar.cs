using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Warmthbar : MonoBehaviour
{
    public Slider warmthbar;

    private void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            warmthbar.value -= 0.1f;
        }
    }
}
