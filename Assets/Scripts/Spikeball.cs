using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spikeball : MonoBehaviour
{

    Rigidbody2D rigidbody2D;
  
    //public float switchTime;
    //float timer;

    int direction = -1;

    [SerializeField]
    float speed = 5.0f;







    void Start()
    {
        rigidbody2D = GetComponent<Rigidbody2D>();
        // Prefab coinPrefab = gameObject.getComponent<CoinPrefab>();
        //timer = switchTime;



       
        







    }


    void Update()
    {
        



    }


    void FixedUpdate()
    {
        Vector2 position = rigidbody2D.position;
        position.x += speed * Time.deltaTime * direction;
        


        rigidbody2D.MovePosition(position);



    }
    void OnTriggerEnter2D(Collider2D other)
    {
        Miner character = other.GetComponent<Miner>();
        if (character != null)
        {
            character.ChangeHealth(-2);
            Destroy(gameObject);
        }
    }
}