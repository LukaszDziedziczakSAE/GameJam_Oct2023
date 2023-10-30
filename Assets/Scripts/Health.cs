using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Health : MonoBehaviour
{
    [SerializeField] int health;
    [SerializeField] int maxHealth;

    Enemy enemy;

    private void Awake()
    {
        enemy = GetComponent<Enemy>();
    }

    // Start is called before the first frame update
    void Start()
    {
        health=maxHealth;
    }

    public void TakeDamage(int damage) 
    {

        health -= damage;

        if (health <= 0)
        {
            if (enemy != null)
            {
                enemy.Animator.SetTrigger("death");
                enemy.Movement.movementEnabled = false;
                GameManager.Instance.enemies.Remove(enemy);
                Destroy(gameObject, 3f);
            }

        }
        else
        {
            if (enemy != null)
            {
                enemy.Animator.SetTrigger("hit");
            }
        }
    }

    public bool IsAlive => health > 0;

    public string HealthString => health.ToString() + " / " + maxHealth.ToString();

    public float HealthNormalzed => (float)health / (float)maxHealth;
}
