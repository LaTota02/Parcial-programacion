using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ReiniciarYMenu : MonoBehaviour
{
    public int Escenas;

    void Update()
    {
        if(Input.GetKeyDown("r"))
        {
            SceneManager.LoadScene(1);
            Time.timeScale = 1;
        }
        if(Input.GetKeyDown("m"))
        {
            Time.timeScale = 0;
            SceneManager.LoadScene(0);
        }
    }
}
