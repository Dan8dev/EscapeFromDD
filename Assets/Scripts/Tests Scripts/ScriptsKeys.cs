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
        //C�digo para interactuar con el rat�n
        if (Input.GetMouseButtonDown(0)) //cuando se presiona el bot�n del mouse
        {
            Debug.Log("presionaste el bot�n izquierdo del mouse!");
        }
        if (Input.GetMouseButton(0)) //cuando dejas presionado el b�ton del mouse
        {
            Debug.Log("est�s presionando el bot�n izquierdo del mouse!");
        }
        if (Input.GetMouseButtonUp(0)) //cuando sueltas el bot�n del mouse
        {
            Debug.Log("dejaste de presionar el bot�n izquierdo del mouse!");
        }
        //Nota: bot�n izquierdo del mouse(0), derecho(1) y bot�n de la ruedita(2)

        //C�digo para interactuar con el teclado
        //m�todo con las keycodes
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Debug.Log("Con Keycode: presionaste la tecla de espacio");
        }
        //m�todo con inputs definidos
        if (Input.GetButtonDown("Jump"))
        {
            Debug.Log("Con Input Jump: presionaste la tecla de espacio");
        }
    }
}
