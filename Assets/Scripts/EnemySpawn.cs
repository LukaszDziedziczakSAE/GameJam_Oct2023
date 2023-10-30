using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawn : MonoBehaviour
{
    [SerializeField] bool movingRight;
    [SerializeField] Enemy enemyPrefab;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void SpawnEnemy()
    {
        Enemy enemy = Instantiate(enemyPrefab, transform.position, Quaternion.identity);
        enemy.Movement.movingRight = movingRight;
    }

}
