using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] InputReader input;
    [SerializeField] float speed;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (input.Movement.magnitude > 0)
        {
            print("moving");
            Vector3 position = transform.position;
            position.x += input.Movement.x * speed * Time.deltaTime;
            transform.position = position; 
        }
    }
}
