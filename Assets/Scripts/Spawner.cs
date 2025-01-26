using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    private float timer;
    private float spawnTime = 4f;
    public GameObject Fish;
    public float minX = -10f;
    public float maxX = 10f;
    public float minY = -4f;
    public float maxY = 4f;
    private Vector3 spawnPos;
    void Start()
    {
        
    }

    void Update()
    {
        timer -= Time.deltaTime;
        if (timer <= 0)
        {
            timer = spawnTime;
            float spawnX = Random.Range(minX, maxX);
            float spawnY = Random.Range(minY, maxY);
            spawnPos = new Vector3(spawnX, spawnY, 0);
            Instantiate(Fish, spawnPos, Quaternion.identity);
        }
    }
}
