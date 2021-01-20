using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class slowchil : MonoBehaviour
{
    public Slider degrading;
    void Update()
    {
        degrading.value -=  .005f;
    }
}
