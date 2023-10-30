using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovement : MonoBehaviour
{
    [SerializeField] float movementSpeed;
    [SerializeField] bool movementEnabled;
    [SerializeField] Animator animator;

    bool facingRight;
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
            if (movementSpeed>0)facingRight = true;
            else if (movementSpeed < 0) facingRight = false;
        }
        else 
        {
            animator.SetFloat("speed", 0);
        }

        if (facingRight)
        {
            transform.rotation = Quaternion.Euler(0f, 90f, 0f);
        }
        else 
        {
            transform.rotation = Quaternion.Euler(0f, -90f, 0f);
        }

    }

}
