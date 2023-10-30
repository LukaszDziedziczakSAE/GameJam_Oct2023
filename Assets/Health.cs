using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Health : MonoBehaviour
{
    [SerializeField] int health;
    [SerializeField] int maxHealth;
    // Start is called before the first frame update
    void Start()
    {
        health=maxHealth;
    }

    public void TakeDamage(int damage) 
    {
        health -= damage;    
    }
}
