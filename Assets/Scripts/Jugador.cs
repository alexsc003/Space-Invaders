using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jugador : MonoBehaviour
{
    [SerializeField]
    float velocidadMovimiento;
    [SerializeField]
    float movimientoEjeX;
    [SerializeField]
    GameObject balaInicio;
    [SerializeField]
    GameObject balaPrefab;
    [SerializeField]
    float balaVelocidad;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("space"))
        {
            GameObject balaTemporal = Instantiate(balaPrefab, balaInicio.transform.position, balaInicio.transform.rotation) as GameObject;

            Rigidbody rb = balaTemporal.GetComponent<Rigidbody>();

            rb.AddForce(transform.forward * balaVelocidad);

            Destroy(balaTemporal, 5.0f);
        }
        movimientoEjeX = Input.GetAxis("Horizontal") * Time.deltaTime * velocidadMovimiento;
        transform.Translate(movimientoEjeX, 0, 0);
        if (transform.position.x < -6) transform.position = new Vector3(-6f, -3.5f, 0);
        if (transform.position.x > 6) transform.position = new Vector3(6f, -3.5f, 0);
    }
}
