using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class deathscreen : MonoBehaviour
{
    public Slider health;
    void Update()
    {
        if (health.value == 0)
        {
            SceneManager.LoadScene("Dead");
        }
    }
}
