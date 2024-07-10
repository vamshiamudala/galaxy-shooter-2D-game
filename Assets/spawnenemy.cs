using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawnenemy : MonoBehaviour
{
    public GameObject enemytospawn;
    public bool canspawn = true;
    public float enemyspawntime = 1.0f;
    public float maxX = 9.0f;
    public float startingY = 17.8f;
    float randomX = 0.0f;
    void Start()
    {
        StartCoroutine(spawnenemytimer());
    }

    IEnumerator spawnenemytimer()
    {
        while (canspawn == true)
        {
            enemyspawn();
            yield return new WaitForSeconds(enemyspawntime);
        }

    }
    void enemyspawn()
    {
        randomX = Random.Range(-maxX, maxX);
        Instantiate(enemytospawn, new Vector3(randomX, startingY, 0), Quaternion.identity);
    }
}
