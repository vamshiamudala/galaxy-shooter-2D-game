using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playermovement : MonoBehaviour
{
    public float playerspeed = 2.0f;

    public GameObject bullets;
    public float bulletstime = 0.2f;
    public bool isshooting = true;
    float bulletcollisionoffset = 4f;


    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(bulletshootingtime());
    }

    IEnumerator bulletshootingtime()
    {
        while(isshooting == true)
        {
            spawnbullets();
            yield return new WaitForSeconds(bulletstime);
        }
    }

    void spawnbullets()
    {
        if(Input.GetKey(KeyCode.Space))
        {
            Instantiate(bullets, new Vector3(transform.position.x, transform.position.y + bulletcollisionoffset, 0), Quaternion.identity);
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.LeftArrow) && transform.position.x > -9.0f)
        {
            transform.Translate(-playerspeed, 0,0);
        }
        if (Input.GetKey(KeyCode.RightArrow) && transform.position.x < 9.0f)
        {
            transform.Translate(playerspeed, 0, 0);
        }

    }
}
