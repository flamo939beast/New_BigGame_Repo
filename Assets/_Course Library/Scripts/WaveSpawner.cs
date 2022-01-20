using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class WaveSpawner : MonoBehaviour
{
    public TextMeshProUGUI waveCountText;
    public int waveCount = 1;

    public float spawnRate = 1.0f;
    public float timeBetweenWaves = 3.0f;
    public int enemyCount;
   // public GameObject enemy;

    public GameObject[] enemyPrefabs;
    public float spawnRangeX = 5;
    public float spawnPosZ = 20;
    public float spawnPosY = 0.5f;
    public float startDelay = 2;
    public float spawnInterval = 1.5f;
    public GameObject gameOverText;
    public GameObject Wall;
    
    


    bool waveIsDone = true;
    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        waveCountText.text = "Wave: " + waveCount.ToString();

        if(waveIsDone == true)
        {
            StartCoroutine(waveSpawner());
        }
    }

    IEnumerator waveSpawner()
    {
        waveIsDone = false;

        for(int i = 0; i < enemyCount; i++)
        {
            Vector3 spawnPos = new Vector3(Random.Range(-spawnRangeX, spawnRangeX), spawnPosY, spawnPosZ);
            int enemyIndex = Random.Range(0, enemyPrefabs.Length);
            Instantiate(enemyPrefabs[enemyIndex], spawnPos, enemyPrefabs[enemyIndex].transform.rotation);


            yield return new WaitForSeconds(spawnRate);
        }

        spawnRate -= 0.1f;
        enemyCount += 1;
        waveCount += 1;

        yield return new WaitForSeconds(timeBetweenWaves);

        waveIsDone = true;

    }

    public void NewGame()
    {
        Debug.Log("It's a new game");
        GameObject[] allenemies = GameObject.FindGameObjectsWithTag("Enemies");
        foreach (GameObject dude in allenemies)
            GameObject.Destroy(dude);
        waveCount = 1;
        enemyCount = 1;
        gameOverText.SetActive(false);
        Time.timeScale = 1;
        Wall.SetActive(true);
        Wall.GetComponent<WallDamageScript>().currentHealth = 100;

    }

}
