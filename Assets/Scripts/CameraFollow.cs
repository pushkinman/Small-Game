using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public Transform objectToFollow { private get; set; }

    private Vector3 startPosition;
    private Vector3 offSet;
    
    void Start()
    {
        offSet = startPosition - objectToFollow.position;
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = objectToFollow.position + offSet;
    }
}
