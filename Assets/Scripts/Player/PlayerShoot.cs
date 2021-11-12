using UnityEngine;

public class PlayerShoot : MonoBehaviour
{
    
    
    private IWeapon _currentWeapon;

    public void ShootBullet()
    {
        _currentWeapon.Shoot();
    }
}
