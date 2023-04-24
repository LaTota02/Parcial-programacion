using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bot : MonoBehaviour
{
    Humano scriptHumano;
    public string nuevoNombre = "Bot";
    string nombreActual;
    public void Saludar()
    {
        Debug.Log("Hola" + nombreActual + "ahora te llamas" + nuevoNombre);
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Jugador")){
            Saludar();
            scriptHumano = other.GetComponent<Humano>();
            nombreActual = scriptHumano.Nombre;
            scriptHumano.Nombre = nuevoNombre;

        }
    }
}
