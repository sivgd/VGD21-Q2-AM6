using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Creditscroller : MonoBehaviour
{
    public int count = 1;
    public GameObject credit1;
    public GameObject credit2;
    public GameObject credit3;
    public GameObject credit4;
    public GameObject credit5;
    public GameObject credit6;
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.C))
        {
            count += 1;
        }
        //credits that will scroll
        if(count == 1)
        {
            credit1.SetActive(true);
        }
        else
        {
            credit1.SetActive(false);
        }
        //credit 2
        if (count == 2)
        {
            credit2.SetActive(true);
        }
        else
        {
            credit2.SetActive(false);
        }
        //credit 3
        if (count == 3)
        {
            credit3.SetActive(true);
        }
        else
        {
            credit3.SetActive(false);
        }
        //credit 4
        if (count == 4)
        {
            credit4.SetActive(true);
        }
        else
        {
            credit4.SetActive(false);
        }
        //credit 5
        if (count == 5)
        {
            credit5.SetActive(true);
        }
        else
        {
            credit5.SetActive(false);
        }
        //credit 6
        if (count == 6)
        {
            credit6.SetActive(true);
        }
        else
        {
            credit6.SetActive(false);
        }

        if(count == 7)
        {
            count = 1;
        }
    }
}
