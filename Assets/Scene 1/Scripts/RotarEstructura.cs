using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotarEstructura : MonoBehaviour
{
    // Velocidad de rotación ajustable desde el Inspector.
    public float rotationSpeed = 100f;


    // Update is called once per frame
    void Update()
    {
        // Obtener la cantidad de rotación basada en la entrada del teclado y multiplicarla por la velocidad y el tiempo de cuadro.
        float horizontalRotation = Input.GetAxis("Horizontal") * rotationSpeed * Time.deltaTime;
        float verticalRotation = Input.GetAxis("Vertical") * rotationSpeed * Time.deltaTime;

        // Aplicar la rotación al objeto.
        transform.Rotate(verticalRotation, horizontalRotation, 0);
    }
}
