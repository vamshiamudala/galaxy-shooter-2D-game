using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemymovement : MonoBehaviour
{
    public float enemyspeed = 0.1f;


    // Update is called once per frame
    void Update()
    {
        transform.Translate(0, -enemyspeed, 0);
    }
    void OnCollisionEnter2D(Collision2D transformCollision)
    {
        if (transformCollision.gameObject.tag == "bullet")
        {
            Destroy(transformCollision.gameObject);
        }
    }
}
