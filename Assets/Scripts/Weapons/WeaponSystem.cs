using System;
using System.Collections.Generic;
using SmallGame.Interfaces;
using SmallGame.Player;
using UnityEngine;

namespace SmallGame.Weapons
{
    public class WeaponSystem : MonoBehaviour
    {
        public PlayerShoot PlayerShoot { private get; set; }
        
        [SerializeField] private List<BaseWeapon> weaponPrefabs;
        private readonly List<BaseWeapon> _weapons = new List<BaseWeapon>();

        private void Start()
        {
            InstantiateWeapons();
            SetPlayerWeapon(_weapons[0]);
        }

        private void InstantiateWeapons()
        {
            foreach (var weaponPrefab in weaponPrefabs)
            {
                _weapons.Add(Instantiate(weaponPrefab, PlayerShoot.weaponHolder.position, Quaternion.identity));
            }

            foreach (var weapon in _weapons)
            {
                weapon.transform.SetParent(PlayerShoot.weaponHolder);
            }
        }

        private void SetPlayerWeapon(BaseWeapon weapon)
        {
            _weapons.ForEach(w => w.gameObject.SetActive(false));
            PlayerShoot.CurrentWeapon = weapon;
            weapon.gameObject.SetActive(true);
        }
    }
}
