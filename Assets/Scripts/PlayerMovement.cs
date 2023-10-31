using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] InputReader input;
    [SerializeField] float speed;
    [SerializeField] float sprintSpeed;
    [SerializeField] Animator animator;
    [SerializeField] float leftMax;
    [SerializeField] float rightMax;

    Rigidbody rb;
    bool facingRight = true;

    private void Awake()
    {
        rb = GetComponent<Rigidbody>();
    }

    void Update()
    {
        if (IsAttacking) return;

        if (input.Movement.magnitude > 0)
        {
            float moveSpeed = speed;
            if (input.Sprinting) moveSpeed = sprintSpeed;


            Vector3 position = transform.position;
            position.x += input.Movement.x * moveSpeed * Time.deltaTime;

            if (position.x < leftMax) position.x = leftMax;
            else if (position.x > rightMax) position.x = rightMax;

            transform.position = position;

            if (input.Movement.x > 0) facingRight = true;
            else if (input.Movement.x < 0) facingRight = false;

            if (!input.Sprinting) animator.SetFloat("Speed", 1);
            else animator.SetFloat("Speed", 2);
        }
        else
        {
            animator.SetFloat("Speed", 0);
            rb.velocity = Vector3.zero;
        }

        if (facingRight)
        {
            transform.rotation = Quaternion.Euler(0f, 90f, 0f);
        }
        else
        {
            transform.rotation = Quaternion.Euler(0f, -90f, 0f);
        }

        transform.position = new Vector3(transform.position.x, transform.position.y, 0);
    }

    private bool IsAttacking
    {
        get
        {
            if (animator.GetCurrentAnimatorStateInfo(0).IsTag("attack"))
                return animator.GetCurrentAnimatorStateInfo(0).normalizedTime < 1;
            return false;

        }
    }
}
