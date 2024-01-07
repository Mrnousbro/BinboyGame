using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    public Transform[] enemySpawnPoints;

    public GameObject[] enemyPrefabs;
    
    public List<GameObject> spawnedEnemies;

    public int timer = 0;

    private void Start()
    {
        Debug.Log("Enemy Spawner: Start");
    }

    private void Update()
    {
        timer += 1;

        if (timer >= 280)
        {
            for (int spawnPointIndex = 0; spawnPointIndex < enemySpawnPoints.Length; spawnPointIndex++)
            {
                spawnedEnemies.Add(Instantiate(enemyPrefabs[0], enemySpawnPoints[spawnPointIndex].position, transform.rotation));
            }
            //int randomSpawnPoint = Random.Range(0, enemySpawnPoints.Length);
            //int randomEnemy = Random.Range(0, enemyPrefabs.Length);

            //.Log($"BEFORE {spawnedEnemies.Count}");
            if (spawnedEnemies.Count >= enemySpawnPoints.Length * 8)
            {
                //Debug.Log("INSIDE");
                int count = 8;
                while (count-- > 0)
                {
                    Destroy(spawnedEnemies[0]);
                    spawnedEnemies.RemoveAt(0);
                }
            }

            //Debug.Log("Enemy Spawner: " + randomSpawnPoint);
            //Debug.Log("Enemy Spawner: " + randomEnemy);

            //GameObject spawnedEnemy = Instantiate(enemyPrefabs[0], enemySpawnPoints[randomSpawnPoint].position, transform.rotation);

            //Debug.Log("Enemy Spawner: " + spawnedEnemy);

            timer = 0;
            //DestroyAfterDelay(spawnedEnemy, 5f);
        }
    }
    /*
    void DestroyAfterDelay(GameObject obj, float delay)
    {
        // Destroy the object after the specified delay
        Destroy(obj, delay);
    }*/

    /*[SerializeField] private float spawnRate = 1f;

    [SerializeField] private GameObject[] enemyPrefabs;

    [SerializeField] private bool canSpawn = true;

    private void Start()
    {

        Debug.Log("EnemySpawner: Start");
        StartCoroutine(Spawner());
        Debug.Log("EnemySpawner: Start 2");
    }

    private IEnumerator Spawner() 
    {
        WaitForSeconds wait = new WaitForSeconds(spawnRate);

        while (canSpawn) 
        {
            yield return wait;
            int rand = Random.Range(0, enemyPrefabs.Length);

            GameObject enemyToSpawn = enemyPrefabs[rand];

            Instantiate(enemyToSpawn, transform.position, Quaternion.identity);

        
        }
    
    }*/
}

