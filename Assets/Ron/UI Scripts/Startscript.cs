using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Startscript : MonoBehaviour
{
    public string LoadLevelname;
    void OnMouseDown()
    {
        SceneManager.LoadScene(LoadLevelname);
    }
}
