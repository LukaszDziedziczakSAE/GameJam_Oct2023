using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyWeapon : MonoBehaviour
{
    EnemyAttack enemy;
    [SerializeField] Collider weaponCollider;

    private void Awake()
    {
        enemy = GetComponentInParent<EnemyAttack>();
    }

    private void Start()
    {
        ColliderEnabled(false);
    }

    private void OnTriggerEnter(Collider other)
    {
        print("Hit " + other.name);

        if (other.TryGetComponent<Castle>(out Castle castle))
        {
            castle.Health.TakeDamage(this.enemy.AttackDamage);
            castle.Sounds.PlayCastleHitSound();
            UI.UpdateUI();
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
