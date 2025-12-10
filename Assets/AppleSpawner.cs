using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class AppleSpawner : MonoBehaviour
{
    public GameObject applePrefab;

   
    public float minX = -4.5f;
    public float maxX = 4.5f;  
    public float minZ = -4.5f; 
    public float maxZ = 4.5f;
    public float fixedY = 0.5f;

 
    public void SpawnNewApple()
    {
        float randomX = Random.Range(minX, maxX);
        float randomZ = Random.Range(minZ, maxZ);
        Vector3 spawnPosition = new Vector3(randomX, fixedY, randomZ);

        Instantiate(applePrefab, spawnPosition, Quaternion.identity);

    }

    void Start()
    {
        SpawnNewApple();
    }
}