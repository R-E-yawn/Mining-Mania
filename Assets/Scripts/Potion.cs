using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Potion : MonoBehaviour
{

    Rigidbody2D rigidbody2D;
    bool vertical = true;
    float switchTime;
    float timer;
    float directionTimer;
    public Instantiate script;
    int direction;
    float destroyTime = 5.0f;
    //[SerializeField]
    float speed;







    void Start()
    {
        rigidbody2D = GetComponent<Rigidbody2D>();
        // Prefab coinPrefab = gameObject.getComponent<CoinPrefab>();
        timer = switchTime;


        SwitchDirection();
        //directionTimer = Random.Range(.5f, 1.5f);






    }

    void SwitchDirection()
    {
        if (Random.Range(0, 2) == 0)
        {
            vertical = true;
        }
        else
        {
            vertical = false;
        }

        if (Random.Range(0, 2) == 0)
        {
            direction = -1;
        }
        else
        {
            direction = 1;
        }

        switchTime = Random.Range(5f, 8.0f);
        speed = Random.Range(3.7f, 5.0f);

    }

    void Update()
    {
        timer -= Time.deltaTime;
        if (timer < 0)
        {
            direction *= -1;
            timer = switchTime;
        }

        /*
                directionTimer -= Time.deltaTime;
                if (directionTimer < 0)
                {
                    SwitchDirection();
                    directionTimer = Random.Range(.5f, 1.5f);
                }

        */

        destroyTime -= Time.deltaTime;
        if (destroyTime < 0.0f) 
        {
            Destroy(gameObject);
        }
    }


    void FixedUpdate()
    {
        Vector2 position = rigidbody2D.position;
        if (vertical)
        {
            position.y += speed * Time.deltaTime * direction;

        }
        else
        {
            position.x += speed * Time.deltaTime * direction;
        }


        rigidbody2D.MovePosition(position);



    }
    void OnTriggerEnter2D(Collider2D other)
    {
        Miner character = other.GetComponent<Miner>();
        if (character != null)
        {
            character.Potion(10.0f);
            Destroy(gameObject);
        }
    }
}
