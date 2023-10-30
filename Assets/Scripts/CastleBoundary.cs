using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CastleBoundary : MonoBehaviour
{
    EnemyMovement enemyMovement;
    Enemy enemy;

    bool reachedCastle;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (reachedCastle==true) 
        {
            enemy.Animator.SetFloat("speed", 0);
            //Vector3 position = Vector3.zero;

        }
    }
}
