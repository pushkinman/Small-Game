using System;
using System.Collections;
using System.Linq;
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

        private bool canShoot = true;

        public void FireWeapon()
        {
            if (canShoot)
                StartCoroutine(TryShootBullet());
        }

        private IEnumerator TryShootBullet()
        {
            Shoot();
            canShoot = false;
            yield return new WaitForSeconds(1 / weaponParameters.fireRate);
            canShoot = true;
        }
        
        protected abstract void Shoot();

        private void Update()
        {
            Debug.Log(canShoot);
        }
    }
}