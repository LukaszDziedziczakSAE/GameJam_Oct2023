using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawn : MonoBehaviour
{
    [SerializeField] bool movingRight;
    [SerializeField] Enemy[] enemyPrefabs;


    public Enemy SpawnEnemy()
    {
        Enemy enemy = Instantiate(RandomEnemy, transform.position, Quaternion.identity);
        enemy.Movement.movingRight = movingRight;
        return enemy;
    }

    public bool IsMovingRight => movingRight;

    private Enemy RandomEnemy
    {
        get
        {
            int randomInt = Random.Range(0, enemyPrefabs.Length);
            return enemyPrefabs[randomInt];
        }
    }
}
