using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SideScrolling : MonoBehaviour
{
    private Transform player;

    private void Awake()
    {
        player = GameObject.FindWithTag("Player").transform;
    }

    private void LateUpdate()
    {
        Vector3 cameraPosition = transform.position;

        //Free Movement
        //cameraPosition.x = player.position.x;
        //Only Movement to the right
        cameraPosition.x = Mathf.Max(cameraPosition.x, player.position.x);


        transform.position = cameraPosition;
    }
}
