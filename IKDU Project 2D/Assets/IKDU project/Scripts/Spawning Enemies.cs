using System.Collections;
using System.Collections.Generic;
using System.Diagnostics.Tracing;
using UnityEngine;

public class SpawningEnemies : MonoBehaviour
{
    private float counter = 0;
    public float spawnTime = 10;
    public GameObject enemyPrefab;
    public int numberEnemiesSpawned = 1;

    // Start is called before the first frame update
    void Start()
    {
            
    }

    // Update is called once per frame
    void Update()
    {
          counter += Time.deltaTime;
        if (counter > spawnTime)
        {
            counter = 0;

            for (int i = 0; i < numberEnemiesSpawned; i++)
            {
               
                Instantiate(enemyPrefab, new Vector3(Random.Range(-5, 5), Random.Range(-5, 5), -1f), Quaternion.identity);
            }
        }
    }

    
}
