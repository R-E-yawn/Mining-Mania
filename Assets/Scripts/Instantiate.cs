using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class Instantiate : MonoBehaviour
{
    public float generateTimer = 0.00000025f;
    float currentGenTimer;
    public GameObject CoinPrefab;
    public GameObject RedCoinPrefab;
    public GameObject Fireball;
    public GameObject Potion;
    public GameObject Diamond;
    public GameObject Spikeball;
    int item;
    string mode = "spikeball";
    int spawnAmount = 3;

    Miner miner;

    // Spawns new coins
    public void SpawnNewCoin(int num)
    {
        for (int i = 0; i < num; i++)
        {
            item = Random.Range(1, 100);
            if (item <= 30)
            {
                GameObject coinClone = Instantiate(RedCoinPrefab, new Vector2(Random.Range(-6f, 6f), Random.Range(-4f, 4f)), Quaternion.identity);
            }
            
            else if ( 30 < item && item <=34) 
            {
                GameObject coinClone = Instantiate(Diamond, new Vector2(Random.Range(-8f, 8f), Random.Range(-6f, 6f)), Quaternion.identity);
            }
            
            else if (34<item && item<=38)
            {
                GameObject coinClone = Instantiate(Potion, new Vector2(Random.Range(-8f, 8f), Random.Range(-6f, 6f)), Quaternion.identity);
            }
            
            else
            {
                GameObject coinClone = Instantiate(CoinPrefab, new Vector2(Random.Range(-6f, 6f), Random.Range(-4f, 4f)), Quaternion.identity);
            }

        }
    }

    void Start() 
    {
        SpawnNewCoin(Random.Range(5, 15));
        //miner = GetComponent<SpriteRenderer>()
    }

    

    // Update is called once per frame
    void Update()
    {
        currentGenTimer -= Time.deltaTime;
        if (currentGenTimer < 0)
        {
       
            SpawnNewCoin(spawnAmount);
            

            currentGenTimer = generateTimer;
        }


    }
    
    /*
    void Tempo(playTime)
    {
        if (playTime >= 55f)
        {
            spawnAmount = 5;
        }else if ( 55f > playTime >= 45f)
        {
            spawnAmount = 2;
        }else if (45f > playTime >= 40f)
        {
            spawnAmount = 7;
        }
        else if (40f > playTime >= 30f)
        {
            spawnAmount = 2;
        }
        else if (30f > playTime >= 25f)
        {
            spawnAmount = 9;
        }
        else if (25f > playTime >= 15f)
        {
            spawnAmount = 3;
        }
        else if (15f > playTime >= 10f)
        {
            spawnAmount = 15;
        }
        else if (10f > playTime >= 0f)
        {
            spawnAmount = 2;
        }
    }

    */
}
