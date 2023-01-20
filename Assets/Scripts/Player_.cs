using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_ : MonoBehaviour
{
   
    float Speed = 500f;
    public Rigidbody2D Rb; 
    Vector2 playerMove;
    public Animator Anim;
    
    void Start()
    {
        
    }

  
    void Update()
    {
        playerMove.x = Input.GetAxisRaw("Horizontal");
        playerMove.y = Input.GetAxisRaw("Vertical");
        Anim.SetInteger("moveX",(int)playerMove.x);
        Anim.SetInteger("moveY", (int)playerMove.y);
        Rb.velocity = playerMove * Speed *Time.deltaTime;
    }
}
