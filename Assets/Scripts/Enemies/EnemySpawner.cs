using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;

namespace SmallGame.Enemies
{
    public class EnemySpawner : MonoBehaviour
    {
        [SerializeField] private List<Enemy> enemies;
        [SerializeField] private int startEnemyCount = 4;

        private void Start()
        {
            SpawnBaseEnemies();
        }

        private void SpawnBaseEnemies()
        {
            for (int i = 0; i < startEnemyCount; i++)
            {
                var randomPosition = new Vector3(Random.Range(-4f, 4f), 0.5f,Random.Range(-4f, 4f));
                Instantiate(enemies[0], randomPosition, Quaternion.identity);
            }
        }
    
    }
}
