using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Health : MonoBehaviour
{
    [SerializeField] int health;
    [SerializeField] int maxHealth;

    Enemy enemy;
    Castle castle;

    private void Awake()
    {
        enemy = GetComponent<Enemy>();
        castle = GetComponent<Castle>();
    }

    // Start is called before the first frame update
    void Start()
    {
        ResetHealth();
        UI.UpdateUI();
    }

    public void ResetHealth()
    {
        health = maxHealth;
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
                enemy.Sound.PlayHittingSound();
                GameManager.Instance.Enemies.Remove(enemy);
                Destroy(gameObject, 3f);
                
            }

            if (castle != null)
            {
                GameManager.EndGame();
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
