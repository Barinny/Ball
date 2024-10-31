using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnFoe : MonoBehaviour
{
    public GameObject spawnPoint;
    public GameObject objToSpawn;

    public float timeRemaining = 7;

    int randomNumber;
    int lastNumber;

    void NewRandomNumber()
    {
        randomNumber = Random.Range(0, 3);

        if (randomNumber == lastNumber)
        {
            randomNumber = Random.Range(0, 3);
        }

        lastNumber = randomNumber;
    }

    void Update()
    {
        if (timeRemaining > 0)
        {
            timeRemaining -= Time.deltaTime;
        }
        else
        {
            Instantiate(objToSpawn, spawnPoint.transform.position, Quaternion.identity);
            //Debug.Log(Random.Range(0, 3));
            timeRemaining = 7;
        }
    }
    
}
