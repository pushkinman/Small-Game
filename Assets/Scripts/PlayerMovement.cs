using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] private float speed = 1;

    public void Move(Vector3 direction)
    {
        Debug.Log($"Moving: {direction}");
        transform.Translate(direction * speed);
    }
}
