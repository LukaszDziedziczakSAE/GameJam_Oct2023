using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerWeapon : MonoBehaviour
{
    PlayerAttack player;

    private void Awake()
    {
        player = GetComponentInParent<PlayerAttack>();
    }

    private void OnTriggerEnter(Collider other)
    {
        print("Hit " + other.name);

        if (other.TryGetComponent<Enemy>(out Enemy enemy))
        {
            enemy.Health.TakeDamage(player.AttackDamage);
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        print(collision.gameObject.name);
    }
}
