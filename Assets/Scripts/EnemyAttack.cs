using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyAttack : MonoBehaviour
{
    Enemy enemy;
    Castle castle;

    private void Awake()
    {
        enemy = GetComponent<Enemy>();
        castle = FindObjectOfType<Castle>();
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (!enemy.Health.IsAlive) return;

        if (!IsAttacking && castle.IsWithinAttackRange(transform))
        {
            enemy.Animator.SetTrigger("attack");
            enemy.Movement.movementEnabled = false;
        }
    }

    private bool IsAttacking
    {
        get
        {
            if (enemy.Animator.GetCurrentAnimatorStateInfo(0).IsTag("attack"))
            {
                return enemy.Animator.GetCurrentAnimatorStateInfo(0).normalizedTime < 1;
            }
            else return false;
        }
    }
}
