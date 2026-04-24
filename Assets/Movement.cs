using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    public float velocity = 1f;
    public float rotationSpeed = 100f;

    void Start()
    {
        
    }

    void Update()
    {
        float horizontalInput = Input.GetAxis("Horizontal");
        float verticalInput = Input.GetAxis("Vertical");

        // Movimento
        transform.position += new Vector3(horizontalInput * velocity, 0, 0);
        transform.position += new Vector3(0, verticalInput * velocity, 0);

        // Limite no eixo X
        if (transform.position.x > 10)
        {
            transform.position = new Vector3(10, transform.position.y, transform.position.z);
        }
        else if (transform.position.x < -10)
        {
            transform.position = new Vector3(-10, transform.position.y, transform.position.z);
        }

        // Rotação vertical (eixo X) ao segurar espaço
        if (Input.GetKey(KeyCode.Space))
        {
            transform.Rotate(rotationSpeed * Time.deltaTime, 0, 0);
        }
    }
}