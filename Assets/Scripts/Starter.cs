using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Starter : MonoBehaviour
{
    [SerializeField] private PlayerMovement playerMovement;
    [SerializeField] private Vector3 playerStartPosition;
    [SerializeField] private InputSystem inputSystem;

    private void Awake()
    {
        SpawnObjects();
        SetDependencies();
    }

    private void SpawnObjects()
    {
        playerMovement = Instantiate(playerMovement, playerStartPosition, Quaternion.identity);
    }
    
    private void SetDependencies()
    {
        inputSystem.PlayerMovement = playerMovement;
    }
}
