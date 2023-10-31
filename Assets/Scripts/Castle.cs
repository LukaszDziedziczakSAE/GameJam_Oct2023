using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Castle : MonoBehaviour
{
    [SerializeField]float attackRange;
    [field: SerializeField] public Health Health { get; private set; }
    
    // Start is called before the first frame update
    void Start()
    {
        Health = GetComponent<Health>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public bool IsWithinAttackRange(Transform enemy) 
    {
        float distance = Vector3.Distance(transform.position, enemy.position);
        return distance < attackRange;
    
    }
}
