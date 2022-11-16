using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Escena : MonoBehaviour
{
    public int numeroNivel;

    public void CambioEscena()
    {
        SceneManager.LoadScene(1);
    }
}