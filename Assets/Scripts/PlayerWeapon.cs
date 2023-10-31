using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerWeapon : MonoBehaviour
{
    Player player;
    [SerializeField] Collider weaponCollider;

    Vector3 postition;
    Quaternion rotation;
    Vector3 scale;

    private void Awake()
    {
        player = GetComponentInParent<Player>();
    }

    private void Start()
    {
        ColliderEnabled(false);
        postition = transform.localPosition;
        rotation = transform.localRotation;
        scale = transform.localScale;
    }

    private void Update()
    {
        transform.localPosition = postition;
        transform.localRotation = rotation;
        transform.localScale = scale;
    }

    private void OnTriggerEnter(Collider other)
    {
        //print("Hit " + other.name);

        if (other.TryGetComponent<Enemy>(out Enemy enemy))
        {
            enemy.Health.TakeDamage(player.Attack.AttackDamage);
            player.WeaponSound.PlayWeaponHitSound();
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
