using SmallGame.Interfaces;
using SmallGame.Weapons;
using UnityEngine;

namespace SmallGame.Player
{
    public class PlayerShoot : MonoBehaviour
    {
        public BaseWeapon CurrentWeapon { private get; set; }
        public Transform weaponHolder;

        public void FireWeapon()
        {
            CurrentWeapon.FireWeapon();
        }

        public void MakeGunLookAt(Vector3 objectToLookAt)
        {
            CurrentWeapon.transform.LookAt(objectToLookAt);
        }
    }
}
