using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerGun : MonoBehaviour
{

    public bool canShoot = true;
    public bool shooting;

    [Header("Stats")]
    [SerializeField] private Rigidbody2D bulletPrefab;
    [SerializeField] private float bulletSpeed = 10;
    [SerializeField] private float fireRate = 4;

    private float nextTimeToFire;

    void Update() {
        if (shooting && Time.time >= nextTimeToFire && canShoot)
        {
            nextTimeToFire = Time.time + 1 / fireRate;
            Fire();
        }
    }

    private void Fire() {
        Rigidbody2D bulletBody = Instantiate(bulletPrefab, transform.position, transform.rotation);
        bulletBody.AddRelativeForce(Vector2.up * bulletSpeed, ForceMode2D.Impulse);
    }

}
