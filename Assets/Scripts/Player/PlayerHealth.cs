using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerHealth : MonoBehaviour
{
    public int totalHealth = 3;
    public RectTransform heartUI;

    //Game Over
    public RectTransform gameOverMenu;
    public GameObject unknown;
    public GameObject music;


    private int _health;
    private float _heartSize = 16f;
    private SpriteRenderer _renderer;
    private Animator _animator;
    private Vector3 _startPosition;
    

    void Awake()
    {
        _renderer = GetComponent<SpriteRenderer>();
        _animator = GetComponent<Animator>();
    }
    // Start is called before the first frame update
    void Start()
    {
        _health = totalHealth;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void AddDamage(int amount)
    {
        _health -= amount;
        _animator.SetTrigger("Hurt");
        StartCoroutine("VisualFeedback");

        if (_health <= 0)
        {
            _health = 0;
            unknown.SetActive(false);
        }
        
        heartUI.sizeDelta = new Vector2(_heartSize * _health, _heartSize);
    }

    private IEnumerator VisualFeedback()
    {
        _renderer.color = Color.red;

        yield return new WaitForSeconds(0.1f);

        _renderer.color = Color.white;
    }

    private void OnEnable()
    {
        _health = totalHealth;
        heartUI.sizeDelta = new Vector2(_heartSize * _health, _heartSize);
        unknown.SetActive(true);
    }

    private void OnDisable()
    {
        if (gameOverMenu != null)
            gameOverMenu.gameObject.SetActive(true);

        if(music != null)
            music.SetActive(false);

        if (heartUI != null)
            heartUI.sizeDelta = new Vector2(0, 0);

        _startPosition = new Vector3(-2.428f, 0.964f, -0.7113206f);
        unknown.transform.position = _startPosition;
        _renderer.color = Color.white;
    }
}
