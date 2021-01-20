using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Warmthbar : MonoBehaviour
{
    public Slider warmthbar;
     void OnCollisionStay2D(Collision2D collision)
    {
        warmthbar.value += 0.01f;
    }
}
