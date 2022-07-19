using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BasicScript : MonoBehaviour
{
    public int numeroEntero = 8;
    public float puntoFlotante = 2.5f;
    public string cadenaDeCaracteres = "Hola";
    public bool booleano = true;
    public int[] miArreglo;

    //atributos/variables privadas
    //private int _numeroEntero2 = 16;
    //string _cadenaDeCaracteres2 = "Adiós";
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Suma de números en Unity, mi variable numeroEntero tiene el valor de: " + numeroEntero);
        numeroEntero += 10;
        Debug.Log("Ahora mi número entero tiene el valor de: " + numeroEntero);
        Debug.Log(cadenaDeCaracteres);
        Debug.Log(puntoFlotante);
        Debug.Log(booleano);

        for (int i = 0; i < miArreglo.Length; i++)
        {
            miArreglo[i] = i+1;
            Debug.Log("Mi arreglo en la posición: " + i + " tiene el valor de: " + miArreglo[i]);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
