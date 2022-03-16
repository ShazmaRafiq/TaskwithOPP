using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject[] fruitPrefabs;
    private float spawnRangeX = 7.0f;
    private float spawnRangeZ = 10.0f;
    private float startDelay = 2;
    private float endDelay = 1.5f;

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnRandomFruit", startDelay, endDelay);

    }

    // Update is called once per frame
    void Update()
    {

       
    }
    void SpawnRandomFruit()
    {

        int fruitIndex = Random.Range(0, fruitPrefabs.Length);
        Vector3 spawnPos = new Vector3(Random.Range(-spawnRangeX, spawnRangeX), 0, Random.Range(-spawnRangeZ, spawnRangeZ));
        GameObject spawn = Instantiate(fruitPrefabs[fruitIndex], spawnPos, fruitPrefabs[fruitIndex].transform.rotation);
        Destroy(spawn, 3);
    }
}























        
        

