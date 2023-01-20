using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fire : MonoBehaviour
{
    public GameObject Bullet;
    float bulletsSpeed = 20f;
  

    void Start()
    {
        
    }

    
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            GameObject newBullet = Instantiate(Bullet, transform.position, transform.rotation);
            Rigidbody2D bulletRb = newBullet.GetComponent<Rigidbody2D>();
            bulletRb.AddForce(transform.up * bulletsSpeed, ForceMode2D.Impulse);
 
        }



    }
}
