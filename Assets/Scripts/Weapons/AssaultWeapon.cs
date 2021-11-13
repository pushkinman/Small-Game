using SmallGame.Interfaces;
using SmallGame.Parameters;
using UnityEngine;

namespace SmallGame.Weapons
{
    public class AssaultWeapon : BaseWeapon
    {
        public override void Shoot()
        {
            var obj = Instantiate(bulletPrefab, bulletSpawnPoint.position, bulletSpawnPoint.rotation);
            var bullet = obj.GetComponent<IBullet>();
            var bulletParameters =
                new BulletParameters(weaponParameters.damage, weaponParameters.range, weaponParameters.speed);
            bullet.Fly(bulletParameters);
        }
    }
}
