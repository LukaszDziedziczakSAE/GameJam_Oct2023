using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    [field: SerializeField] public Animator Animator { get; private set; }
    [field: SerializeField] public Health Health { get; private set; }
    [field: SerializeField] public EnemyMovement Movement { get; private set; }
    [field: SerializeField] public EnemyAttack Attack { get; private set; }
    [field: SerializeField] public EnemySounds Sound { get; private set; }

    private void Awake()
    {
        if (Attack == null) Attack = GetComponent<EnemyAttack>();
        if (Sound == null) Sound = GetComponentInChildren<EnemySounds>();
        if (Health == null) Health = GetComponent<Health>();
    }

    public void Initizlise(int health, int damage)
    {
        Health.SetHealth(health);
        Attack.SetDamage(damage);
    }
}
