using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Portal : MonoBehaviour
{
    public int totalHealth = 3;
    public RectTransform heartUI;
    public RectTransform toBeContinueMenu;
    public GameObject unknown;
    public GameObject music;

    private int _health;
    private float _heartSize = 16f;
    private Vector3 _startPosition;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            if (toBeContinueMenu != null)
                toBeContinueMenu.gameObject.SetActive(true);

            music.SetActive(false);
            _startPosition = new Vector3(-2.428f, 0.964f, -0.7113206f);
            unknown.transform.position = _startPosition;

            _health = totalHealth;
            heartUI.sizeDelta = new Vector2(_heartSize * _health, _heartSize);
        }
    }
}
