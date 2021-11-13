using System.Collections;
using System.Collections.Generic;
using SmallGame.Interfaces;
using SmallGame.Parameters;
using SmallGame.Weapons;
using UnityEngine;

namespace SmallGame
{
    public class ShotgunWeapon : BaseWeapon
    {
        [SerializeField] private int numberOfBullets = 5;
        [SerializeField] private float bulletSpread = 10f;
        
        
        protected override void Shoot()
        {
            for (int i = 0; i < numberOfBullets; i++)
            {
                var rotationSpred = Quaternion.Euler(0, Random.Range(-bulletSpread, bulletSpread), 0);
                var obj = Instantiate(bulletPrefab, bulletSpawnPoint.position, bulletSpawnPoint.rotation * rotationSpred);
                var bullet = obj.GetComponent<IBullet>();
                var bulletParameters =
                    new BulletParameters(weaponParameters.damage, weaponParameters.range, weaponParameters.speed);
                bullet.Fly(bulletParameters);
            }
        }
    }
}
