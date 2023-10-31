using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawn : MonoBehaviour
{
    [SerializeField] bool movingRight;
    [SerializeField] Enemy[] enemyPrefabs;

    [SerializeField] int healthPerLevel;
    [SerializeField] int damagePerLevel;


    public Enemy SpawnEnemy()
    {
        Enemy enemy = Instantiate(RandomEnemy, transform.position, Quaternion.identity);
        enemy.Movement.movingRight = movingRight;
        int health = healthPerLevel * GameManager.Instance.Round;
        int damage = damagePerLevel * GameManager.Instance.Round;
        enemy.Initizlise(health, damage);
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
