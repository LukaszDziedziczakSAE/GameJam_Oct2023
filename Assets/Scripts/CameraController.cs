using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    [SerializeField] Transform player;
    [SerializeField] float distanceToPlayer = 5f;

    private void Update()
    {
        transform.position = new Vector3(player.position.x, player.position.y, -distanceToPlayer);
    }
}
