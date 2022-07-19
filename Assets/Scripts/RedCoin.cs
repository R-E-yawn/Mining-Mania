using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RedCoin : MonoBehaviour
{

    Rigidbody2D rigidbody2D;
    public bool vertical;
    public float switchTime;
    float timer;

    int direction;

    [SerializeField]
    float speed;

    void Start()
    {
        rigidbody2D = GetComponent<Rigidbody2D>();
        // Prefab coinPrefab = gameObject.getComponent<CoinPrefab>();
        timer = switchTime;


        if (Random.Range(0, 2) == 1)
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

        switchTime = Random.Range(15.0f, 25.0f);
        speed = Random.Range(4.5f, 7.5f);
    }


    void Update()
    {
        timer -= Time.deltaTime;
        if (timer < 0)
        {
            direction *= -1;
            timer = switchTime;
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
            character.ChangeCoin(5);
            Destroy(gameObject);
        }
    }
}
