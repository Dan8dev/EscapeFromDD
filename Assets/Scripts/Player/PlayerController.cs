using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed = 2.5f;
    public float jumpForce = 5f;

    public Transform groundCheck;
    public LayerMask groundLayer;
    public float groundCheckRadius;

    private Rigidbody2D _rigidbody;
    private Animator _animator;

    private Vector2 _movement;
    private bool _facingRight = true;
    private bool _isGrounded;

    private void Awake()
    {
        _rigidbody = GetComponent<Rigidbody2D>();
        _animator = GetComponent<Animator>();
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float horizontalInput = Input.GetAxisRaw("Horizontal");
        _movement = new Vector2(horizontalInput, 0f);

        if (horizontalInput < 0f && _facingRight == true)
        {
            Flip();
        }
        else if(horizontalInput > 0f && _facingRight == false)
        {
            Flip();
        }

        _isGrounded = Physics2D.OverlapCircle(groundCheck.position, groundCheckRadius, groundLayer);
        
        if(Input.GetButtonDown("Jump") && _isGrounded == true)
        {
            //Agregamos una fuerza al componente rigidbody para que le permita hacer un salto explosivo
            _rigidbody.AddForce(Vector2.up * jumpForce, ForceMode2D.Impulse);
        }
    }

    void FixedUpdate()
    {
        float horizontalVelocity = _movement.normalized.x * speed;
        _rigidbody.velocity = new Vector2(horizontalVelocity, _rigidbody.velocity.y);
    }

    void LateUpdate()
    {
        _animator.SetBool("Idle", _movement == Vector2.zero);
        _animator.SetBool("IsGrounded", _isGrounded);
        _animator.SetFloat("VerticalVelocity", _rigidbody.velocity.y);
    }

    void Flip()
    {
        //Verificamos si estamos viendo hacía la derecha o izquierda y cambiarlo según sea el caso
        _facingRight = !_facingRight;
        //Obtenemos la escala en x de nuestro personaje
        float localScaleX = transform.localScale.x;
        //Multiplicamos la escala por negativo para cambiar el valor de scale en x y mire hacía
        //la izquierda o derecha
        localScaleX = localScaleX * -1f;
        //Creamos un nuevo vector para llevar a cabo el cambio de la dirección del personaje en X
        transform.localScale = new Vector3(localScaleX, transform.localScale.y, transform.localScale.z);
    }
}
