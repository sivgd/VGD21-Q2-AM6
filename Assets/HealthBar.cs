using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthBar : MonoBehaviour
{
    public Slider Warmthbar;
   
    public void SetMaxHealth(int health)
    {
        Warmthbar.maxValue = health;
        Warmthbar.value = health;
    }
    public void SetHealth(int health)
    {
        Warmthbar.value = health;
    }
}
