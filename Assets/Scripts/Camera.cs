using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camera : MonoBehaviour
{
    Transform playerPos;


    void Start()
    {
     
        playerPos = GameObject.FindGameObjectWithTag("Player").transform;

    }


    void Update()
    {
        transform.position = new Vector3(playerPos.position.x, playerPos.position.y,-10f);
        
    }
}
