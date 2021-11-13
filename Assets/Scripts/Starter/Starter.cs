using SmallGame.InputSystems;
using SmallGame.Player;
using SmallGame.Weapons;
using UnityEngine;

namespace SmallGame.Starter
{
    public class Starter : MonoBehaviour
    {
        [SerializeField] private GameObject playerPrefab;
        [SerializeField] private Vector3 playerStartPosition;
        [SerializeField] private InputSystem inputSystem;
        [SerializeField] private CameraFollow camera;
        [SerializeField] private WeaponSystem weaponSystem;

        private GameObject player;
        private PlayerMovement playerMovement;
        private PlayerShoot playerShoot;
        private void Awake()
        {
            SpawnObjects();
            SetDependencies();
        }

        private void SpawnObjects()
        {
            player = Instantiate(playerPrefab, playerStartPosition, Quaternion.identity);
            playerMovement = player.GetComponent<PlayerMovement>();
            playerShoot = player.GetComponent<PlayerShoot>();
        }

        private void SetDependencies()
        {
            inputSystem.PlayerMovement = playerMovement;
            inputSystem.PlayerShoot = playerShoot;
            camera.objectToFollow = playerMovement.transform;
            weaponSystem.PlayerShoot = playerShoot;
        }
    }
}
