using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Humano : MonoBehaviour
{
    public int velocidad;
    Vector3 moverse;

    private string Name = "Pablo";

    public string Nombre
    {
        get { return Name; }
        set { Name = value; }
    }
    void Update()
    {
        Debug.Log("Hola" + Name);
        float MovimientoHorizontal = Input.GetAxisRaw("Horizontal");

        moverse = new Vector3(MovimientoHorizontal, 0f, 0f);

        moverse = moverse * velocidad * Time.deltaTime;
        transform.position += moverse;
    }
}
