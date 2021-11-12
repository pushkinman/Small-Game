using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FastBullet : MonoBehaviour, IBullet
{
    public void SetBulletParameters()
    {
        
    }
    public IEnumerator Fly(float speed)
    {
        transform.Translate(transform.forward * speed);
        yield return null;
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Enemy"))
        {
            other.GetComponent<Enemy>().TakeDamage(100);
        }
    }
}
