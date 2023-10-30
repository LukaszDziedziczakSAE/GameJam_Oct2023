using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovement : MonoBehaviour
{
    [SerializeField] float movementSpeed;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    private void Update()
    {
        Vector3 position = transform.position;
        position.x += movementSpeed * Time.deltaTime;
        transform.position = position;
    }

}
