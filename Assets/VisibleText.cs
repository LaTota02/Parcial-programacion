using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class  VisibleText: MonoBehaviour
{
    public int numeroNivel;
    public GameObject texto;
    private bool visible;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.M) && visible == true)
        {
            SceneManager.LoadScene(numeroNivel);
        }
    }

    private void OnTriggerEnter2D(Collider2D obstaculo)
    {
        if (obstaculo.tag == "Jugador")
        {
            texto.SetActive(true);
            visible = true;
        }
    }

    private void OnTriggerExit2D(Collider2D other)
    {

        if (other.tag == "Jugador")
        {
            texto.SetActive(false);
            visible = false;
        }
    }
}