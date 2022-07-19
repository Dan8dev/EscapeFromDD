using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementPlayer : MonoBehaviour
{
    public float speed = 1f;
    public Vector2 direction;

    private Animator _animator;
    private SpriteRenderer _spriteRenderer;

    private void Awake()
    {
        _animator = GetComponent<Animator>();
        _spriteRenderer = GetComponent<SpriteRenderer>();
    }

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("El personaje se comienza a mover");
    }

    // Update is called once per frame
    void Update()
    {
        //Utilizamos axis de input para detectar los movimientos de izquerda a derecha 
        float horizontal = Input.GetAxis("Horizontal"); //valores de -1 a 1
        float vertical = Input.GetAxis("Vertical");

        //Si detecta que el gameobject tiene un movimiento en el eje x con valor negativo
        //se moverá hacia la izquierda
        if(horizontal < 0f)
        {
            _spriteRenderer.flipX = true;
            _animator.SetBool("Idle", false);
            //Se calcula el movimiento con valor negativo
            Vector2 movement = new Vector2(-direction.x * speed * Time.deltaTime, 0);
            transform.Translate(movement);
            Debug.Log("El movimiento del personaje hacia la izquierda por el eje x es: " + movement.x);
        }

        //Si detecta que el gameobject tiene un movimiento en el eje x con valor positivo
        //se moverá hacia la derecha
        if (horizontal > 0f)
        {
            _spriteRenderer.flipX = false;
            _animator.SetBool("Idle", false);
            //Se calcula el movimiento con valor positivo
            Vector2 movement = new Vector2(direction.x * speed * Time.deltaTime, 0);
            //Se lleva a cabo el movimiento
            transform.Translate(movement);
            //Mostramos los valores en el eje x
            Debug.Log("El movimiento del personaje hacia la derecha por el eje x es: " + movement.x);
        }
        
        if(horizontal == 0f)
        {
            _animator.SetBool("Idle", true);
        }

        //if(Input.GetButtonDown("Jump"))
        //{
        //    _animator.SetTrigger("Jump");
        //}
    }
}
