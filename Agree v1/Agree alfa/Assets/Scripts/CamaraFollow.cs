using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamaraFollow : MonoBehaviour
{

    public Transform target; // Referencia al transform del personaje
    public Vector3 offset; // Offset de la c�mara respecto al personaje


    void LateUpdate()
    {
        if (target != null)
        {
            // Posiciona la c�mara en la posici�n del personaje m�s el offset
            transform.position = target.position + offset;
        }
    }
}

