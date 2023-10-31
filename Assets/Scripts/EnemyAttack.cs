using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyAttack : MonoBehaviour
{
    Enemy enemy;
    Castle castle;

    public int AttackDamage = 10; 

    private void Awake()
    {
        enemy = GetComponent<Enemy>();
        castle = FindObjectOfType<Castle>();
    }
    // Start is called before the first frame update
    void Start()
    {
        if (castle == null) Debug.LogError(name + ": Castle not found");
    }

    // Update is called once per frame
    void Update()
    {
        //print(name + Vector3.Distance(transform.position, castle.transform.position));

        if (!enemy.Health.IsAlive) return;

        if (!IsAttacking && castle.IsWithinAttackRange(transform))
        {
            enemy.Animator.SetTrigger("attack");
            enemy.Movement.movementEnabled = false;
            enemy.Sound.PlayHittingSound();
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

    public void SetDamage(int amount)
    {
        AttackDamage = amount;
    }
}
