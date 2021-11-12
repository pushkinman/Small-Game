using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AssaultWeapon : MonoBehaviour, IWeapon
{
    [SerializeField] private GameObject bulletPrefab;
    [SerializeField] private WeaponParameters _type;
    

    public void Shoot()
    {
        var bullet = Instantiate(bulletPrefab, transform.forward, Quaternion.identity);
        bullet.GetComponent<IBullet>().Fly(1);
    }
}
