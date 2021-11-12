using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FastBullet : MonoBehaviour, IShoot
{
    public IEnumerator Shoot(float speed)
    {
        transform.Translate(transform.forward * speed);
        yield return null;
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Enemy"))
        {
            other.GetComponent<>()
        }
    }
}
