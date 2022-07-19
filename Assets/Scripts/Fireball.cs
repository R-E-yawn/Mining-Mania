using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fireball : MonoBehaviour
{

    Rigidbody2D rigidbody2D;
    public bool vertical;
    
    float timer = 20.0f;

    int direction;

    [SerializeField]
    float speed = 7.0f;







    void Start()
    {
        rigidbody2D = GetComponent<Rigidbody2D>();
        // Prefab coinPrefab = gameObject.getComponent<CoinPrefab>();
       


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
           //flip it too somehow
        }
        else
        {
            direction = 1;
        }

        







    }


    void Update()
    {
        timer -= Time.deltaTime;
        if (timer < 0)
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
            character.ChangeCoin(-10);
            Destroy(gameObject);
        }
    }
}
