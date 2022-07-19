using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScriptsKeys : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //Código para interactuar con el ratón
        if (Input.GetMouseButtonDown(0)) //cuando se presiona el botón del mouse
        {
            Debug.Log("presionaste el botón izquierdo del mouse!");
        }
        if (Input.GetMouseButton(0)) //cuando dejas presionado el bóton del mouse
        {
            Debug.Log("estás presionando el botón izquierdo del mouse!");
        }
        if (Input.GetMouseButtonUp(0)) //cuando sueltas el botón del mouse
        {
            Debug.Log("dejaste de presionar el botón izquierdo del mouse!");
        }
        //Nota: botón izquierdo del mouse(0), derecho(1) y botón de la ruedita(2)

        //Código para interactuar con el teclado
        //método con las keycodes
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Debug.Log("Con Keycode: presionaste la tecla de espacio");
        }
        //método con inputs definidos
        if (Input.GetButtonDown("Jump"))
        {
            Debug.Log("Con Input Jump: presionaste la tecla de espacio");
        }
    }
}
