using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovement : MonoBehaviour
{
    [SerializeField] float movementSpeed;
    [SerializeField] bool movementEnabled;
    [SerializeField] Animator animator;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    private void Update()
    {

        if (movementEnabled)
        {
            Vector3 position = transform.position;
            position.x += movementSpeed * Time.deltaTime;
            transform.position = position;
            animator.SetFloat("speed", 1);

        }
        else 
        {
            animator.SetFloat("speed", 0);
        }
    }

}
