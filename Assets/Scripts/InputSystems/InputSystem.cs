using SmallGame.Player;
using UnityEngine;

namespace SmallGame.InputSystems
{
    public class InputSystem : MonoBehaviour
    {
        public PlayerMovement PlayerMovement { private get; set; }
        public PlayerShoot PlayerShoot { private get; set; }

        // Update is called once per frame
        void Update()
        {
            MovePlayer();
            Shoot();
            RotateGun();
        }

        private void MovePlayer()
        {
            var movX = Input.GetAxis("Horizontal");
            var movZ = Input.GetAxis("Vertical");

            var moveVector = new Vector3(movX, 0, movZ).normalized * Time.deltaTime;
            if (moveVector.magnitude == 0) return;
            
            PlayerMovement.Move(moveVector);
        }

        private void Shoot()
        {
            if (Input.GetMouseButtonDown(0))
            {
                PlayerShoot.FireWeapon();
            }
        }

        private void RotateGun()
        {
            Vector3 direction = Vector3.zero;
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            if (Physics.Raycast(ray, out RaycastHit rh))
                direction = rh.point;
            direction.y = 1f;
            PlayerShoot.MakeGunLookAt(direction);
        }
    }
}
