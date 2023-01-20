using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Explosions : MonoBehaviour
{
    public GameObject FireExplosion;
  
    void Start()
    {
        Destroy(gameObject, 2f);  
    }

   
    void Update()
    {
        
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        GameObject Boom = Instantiate(FireExplosion, transform.position, transform.rotation);
        Destroy(Boom,1f);
        Destroy(gameObject);
    }
}
