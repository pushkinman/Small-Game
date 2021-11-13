using System.Timers;
using SmallGame.Parameters;
using UnityEngine;

namespace SmallGame.Weapons
{
    public abstract class BaseWeapon : MonoBehaviour
    {
        [SerializeField] protected GameObject bulletPrefab;
        [SerializeField] protected Transform bulletSpawnPoint;
        [SerializeField] protected WeaponParameters weaponParameters;

        private bool _canShoot = true;

        // public void Shoot()
        // {
        //     //if (_canShoot)
        // }
        public abstract void Shoot();
    }
}