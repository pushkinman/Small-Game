using System;
using System.Collections;
using SmallGame.Enemies;
using SmallGame.Interfaces;
using SmallGame.Parameters;
using UnityEngine;

namespace SmallGame.Bullets
{
    public class FastBullet : MonoBehaviour, IBullet
    {
        private BulletParameters _bulletParameters;
        private Vector3 _startPosition;
        private void Awake()
        {
            _startPosition = transform.position;
        }

        public void SetBulletParameters(BulletParameters bulletParameters)
        {
            _bulletParameters = bulletParameters;
        }

        public void Fly(BulletParameters bulletParameters)
        {
            _bulletParameters = bulletParameters;
            StartCoroutine(StartFly());
        }

        private IEnumerator StartFly()
        {
            while (Vector3.Distance(_startPosition, transform.position) < _bulletParameters.Range)
            {
                transform.Translate(Vector3.forward * (_bulletParameters.Speed * Time.deltaTime));
                yield return null;
            }
            Destroy(gameObject);
        }

        private void OnTriggerEnter(Collider other)
        {
            if (other.CompareTag("Enemy"))
            {
                other.GetComponent<Enemy>().TakeDamage(_bulletParameters.Damage);
                StopCoroutine(StartFly());
                Destroy(gameObject);
            }
        }
    }
}
