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
        print(other.name);

        if (other.tag == "Player") return;


        if (other.TryGetComponent<Health>(out Health enemy))
        {
            enemy.TakeDamage(player.AttackDamage);
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        print(collision.gameObject.name);
    }
}
