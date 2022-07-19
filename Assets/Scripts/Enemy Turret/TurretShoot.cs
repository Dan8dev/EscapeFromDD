using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TurretShoot : MonoBehaviour
{
    public GameObject bulletPrefab;
    public GameObject shooter;
    public float aimingTime = 0.5f;
    public float shootingTime = 1f;
    public int damage = 1;

    private Transform _firePoint;
    private Animator _animator;
    private AudioSource _audio;
    private bool _isShoot;

    private void Awake()
    {
        _firePoint = transform.Find("FirePoint");
        _animator = GetComponent<Animator>();
        _audio = GetComponent<AudioSource>();
    }
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void Shoot()
    {
        if (bulletPrefab != null && _firePoint != null)
        {
            GameObject myBullet = Instantiate(bulletPrefab, _firePoint.position, Quaternion.identity) as GameObject;

            Bullet bulletComponent = myBullet.GetComponent<Bullet>();

            if (shooter.transform.localScale.x < 0f)
            {
                bulletComponent.direction = Vector2.right;
            }
            else
            {
                bulletComponent.direction = Vector2.left;
            }
        }
    }

    private void OnTriggerStay2D(Collider2D collision)
    {
        if(_isShoot == false && collision.CompareTag("Player"))
        {
            StartCoroutine(AimAndShoot());
        }
    }

    private IEnumerator AimAndShoot()
    {
        _isShoot = true;

        yield return new WaitForSeconds(aimingTime);

        _animator.SetTrigger("Shoot");
        _audio.Play();

        yield return new WaitForSeconds(shootingTime);

        _isShoot = false;
    }
}
