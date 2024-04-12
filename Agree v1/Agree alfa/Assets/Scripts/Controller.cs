using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Controller : MonoBehaviour
{

    public float speed = 5f; // Velocidad de movimiento del personaje
    public float jumpForce = 10f; // Fuerza del salto
    private Rigidbody rb; // Referencia al componente Rigidbody del personaje
    private bool isGrounded; // Variable para comprobar si el personaje está en el suelo


    // Start is called before the first frame update
    void Start()
    {

        rb = GetComponent<Rigidbody>(); // Obtener referencia al componente Rigidbody

    }

    // Update is called once per frame
    void Update()
    {
        // Movimiento horizontal y vertical
        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");

        Vector3 movement = new Vector3(moveHorizontal, 0.0f, moveVertical);
        rb.AddForce(movement * speed);

        // Comprobar si el personaje está en el suelo
        isGrounded = Physics.Raycast(transform.position, Vector3.down, 0.1f);

        // Saltar si se presiona la tecla de salto y el personaje está en el suelo
        if (Input.GetButtonDown("Jump") && isGrounded)
        {
            rb.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
        }
    }
}
