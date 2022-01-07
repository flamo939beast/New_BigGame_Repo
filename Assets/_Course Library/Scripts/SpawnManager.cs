using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public int enemyCount;
    public int waveNumber = 1;
    public GameObject[] enemyPrefabs;
    public float spawnRangeX = 5;
    public float spawnPosZ = 20;
    public float spawnPosY = 0.5f;
    public float startDelay = 2;
    public float spawnInterval = 1.5f;
    public float spawnPosY = .5f;
    // Start is called before the first frame update
    void Start()
    {
        SpawnEnemyWave(waveNumber);
    }

    // Update is called once per frame
    void Update()
    {
        enemyCount = ;
        
        if(enemyCount == 0)
        {
            waveNumber++;
            SpawnEnemyWave(waveNumber);
        }
    }

    void SpawnEnemyWave(int enemiesToSpawn)
    {
        for (int i = 0; i < enemiesToSpawn; i++)
        {
            InvokeRepeating("SpawnEnemy", startDelay, spawnInterval);
        }

    }

    void SpawnEnemy()
    {
        Vector3 spawnPos = new Vector3(Random.Range(-spawnRangeX, spawnRangeX), spawnPosY, spawnPosZ);
        int enemyIndex = Random.Range(0, enemyPrefabs.Length);
        Instantiate(enemyPrefabs[enemyIndex], spawnPos, enemyPrefabs[enemyIndex].transform.rotation);
    }
}
