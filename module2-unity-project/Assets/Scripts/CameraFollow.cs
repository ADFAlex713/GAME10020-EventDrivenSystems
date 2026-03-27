using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    [SerializeField] private Transform playerTransform;

    private Vector3 offset;

    void Start()
    {
        if (playerTransform != null)
        {
            offset = transform.position - playerTransform.position;
        }
    }

    void LateUpdate()
    {
        if (playerTransform != null)
        {
            // Update camera position to the player position
            transform.position = playerTransform.position + offset;
        }
    }
}
