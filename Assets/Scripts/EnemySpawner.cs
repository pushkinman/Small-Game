using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    [SerializeField] private List<Enemy> enemies;
    [SerializeField] private int startEnemyCount = 4;
    

    public void SpawnBaseEnemies()
    {
        for (int i = 0; i < startEnemyCount; i++)
        {
            Instantiate(enemies)
        }
    }
    
}
