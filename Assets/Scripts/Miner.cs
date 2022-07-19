using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Miner : MonoBehaviour
{

    public float speed = 4.0f;
    public int coins = 0;
    public Text coinText;
    public Text timeText;
    
    public float playTime = 60.0f;
    public int health = 100;
    public Bounds bounds;

    public float potionTime = 0f;
    public bool potion = false;
    
    // Start is called before the first frame update
    void Start()
    {
        coinText.text = "Coins: " + coins.ToString();
        timeText.text = "Time: " + playTime.ToString("F0");
    }

    // Update is called once per frame
    void Update()
    {
        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");
        Vector2 position = transform.position;
        position.x += speed * horizontal*Time.deltaTime;
        position.y += speed * vertical * Time.deltaTime;

        transform.position = position;

        Debug.Log("Scale:" + transform.localScale);
        playTime -= Time.deltaTime;
        timeText.text = "Time: " + playTime.ToString("F0");


        if (potion = true) 
        {
            if (potionTime >= 0)
            {
                potionTime -= Time.deltaTime;
            }
            else 
            {
                potion = false;
                

                speed = 4.0f;
                transform.localScale = new Vector3(1.2f,1.2f,1.2f) ;
                GetComponent<SpriteRenderer>().color = new Color(1f, 1f, 1f);
            }
        }
    }

    public void ChangeCoin(int amount) 
    {
       
        coins = Mathf.Clamp(coins + amount, 0, 1000000);
        coinText.text = "Coins: " + coins.ToString();

    }

    public void ChangeHealth(int amount)
    {
       
        health = Mathf.Clamp(health + amount, 0, 100);
     

    }

    public void Potion(float newSpeed)
    {
       
            potion = true;
            potionTime = 5.0f;
            speed = 12.0f;
            transform.localScale = new Vector3(3.6f,3.6f,3.6f) ;
            GetComponent<SpriteRenderer>().color = new Color(1f, 1f, 0f);
           


    }

    void Awake()
    {
        bounds = GameObject.FindObjectOfType<Bounds>();
     
    }
}
