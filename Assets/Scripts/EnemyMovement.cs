using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovement : MonoBehaviour
{
    [SerializeField] float movementSpeed;
    [SerializeField] bool movementEnabled;
    public bool movingRight;
    Enemy enemy;

    bool facingRight;

    private void Awake()
    {
        enemy = GetComponent<Enemy>();
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    private void Update()
    {

        if (movementEnabled)
        {
            Vector3 position = transform.position;
            float speed = movementSpeed;
            if (!movingRight) speed *= -1;
            position.x += speed * Time.deltaTime;
            transform.position = position;
            enemy.Animator.SetFloat("speed", 1);
            if (speed > 0)facingRight = true;
            else if (speed < 0) facingRight = false;
        }
        else 
        {
            enemy.Animator.SetFloat("speed", 0);
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
