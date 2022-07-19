using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GenerateSpikeballs : MonoBehaviour
{

    public GameObject Spikeball;
    public GameObject Bullet;
    float currentGenTimer;
    float generateTimer = 1.0f;
    float time = 60.0f;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        currentGenTimer -= Time.deltaTime;
        if (currentGenTimer < 0)
        {
            SpawnNewSpikeBall();
            currentGenTimer = generateTimer;
        }


        
        

        time -= Time.deltaTime;

        if (time <= 50.0f && time >40.0f)
        {
            generateTimer = 0.9f;
        }
        else if (time <= 40.0f && time > 30.0f) 
        {
            generateTimer = 0.75f;
        }
        else if (time <= 30.0f && time > 20.0f)
        {
            generateTimer = 0.5f;
        }
        else if (time <= 20.0f && time > 10.0f)
        {
            generateTimer = 0.4f;
        }
        else if (time <= 10.0f )
        {
            generateTimer = 0.25f;
        }
    }

    public void SpawnNewSpikeBall()
    {
        GameObject spikeballClone = Instantiate(Spikeball, new Vector2(15.0f, Random.Range(-5f, 5f)), Quaternion.identity);
    }

/*
    public void SpawnNewBullet()
    {
        GameObject spikeballClone = Instantiate(Bullet, new Vector2(15.0f, Random.Range(-4f, 4f)), Quaternion.identity);
    }
*/
}
