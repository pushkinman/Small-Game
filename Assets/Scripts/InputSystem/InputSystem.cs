using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputSystem : MonoBehaviour
{
    public PlayerMovement PlayerMovement { private get; set; }

    // Update is called once per frame
    void Update()
    {
        var movX = Input.GetAxis("Horizontal");
        var movZ = Input.GetAxis("Vertical");

        var moveVector = new Vector3(movX, 0, movZ).normalized * Time.deltaTime;
        Debug.Log(moveVector);
        PlayerMovement.Move(moveVector);
    }
}
