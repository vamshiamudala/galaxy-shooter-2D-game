using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bulletmovement : MonoBehaviour
{
    public float bulletspeed = 0.5f;
    

    // Update is called once per frame
    void Update()
    {
        transform.Translate(0, bulletspeed, 0);
    }
    void OnCollisionEnter2D(Collision2D transformCollision)
    {
        if (transformCollision.gameObject.tag == "enemy")
        {
            Destroy(transformCollision.gameObject);
        }
    }
}
