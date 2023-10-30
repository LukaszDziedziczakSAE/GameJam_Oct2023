using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerWeapon : MonoBehaviour
{
    PlayerAttack player;
    [SerializeField] Collider weaponCollider;

    private void Awake()
    {
        player = GetComponentInParent<PlayerAttack>();
    }

    private void Start()
    {
        ColliderEnabled(false);
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

    public void ColliderEnabled(bool isEnabled = true)
    {
        weaponCollider.enabled = isEnabled;
    }
}
