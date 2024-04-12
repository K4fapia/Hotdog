using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamaraFollow : MonoBehaviour
{

    public Transform target; // Referencia al transform del personaje
    public Vector3 offset; // Offset de la cámara respecto al personaje


    void LateUpdate()
    {
        if (target != null)
        {
            // Posiciona la cámara en la posición del personaje más el offset
            transform.position = target.position + offset;
        }
    }
}

