using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerShoot : MonoBehaviour
{
    public GameObject BulletPrefab;
    public Transform firepoint;
    public float fireForce = 20f;
    public void Shoot()
    {
        GameObject Bullet = Instantiate(BulletPrefab, firepoint.position, firepoint.rotation);
        Bullet.GetComponent<Rigidbody2D>().AddForce(firepoint.up * fireForce, ForceMode2D.Impulse);
    }
}
