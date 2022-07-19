using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LevelCompleted2 : MonoBehaviour
{
    public float fadeTime = 1f;
    public float displayImageTime = 1f;
    public GameObject player;
    public CanvasGroup exitBackgroundImageCanvasGroup;
    public CanvasGroup gameOverBackgroundImageCanvasGroup;
    public Text finalCoinText;
    public int finalCoinAmount;

    bool isPlayerAtExit;
    float timer = .5f;

    Miner miner;
    public GameObject player2;


    void Awake()
    {
        miner = player2.GetComponent<Miner>();
        timer = .5f;
    }

    /*
    void OnTriggerEnter(Collider other)
    {

        if (other.gameObject == player)
        {
            isPlayerAtExit = true;
        }


    }
    */

    void Update()
    {
        /*
        if (isPlayerAtExit)
        {
            EndLevel();
        }
        */

        if (miner.playTime <= 1f)
        {
            
            GameOver();
        }

    }

   

    void GameOver()
    {
        
        timer += Time.deltaTime;

        finalCoinAmount = miner.coins;
        finalCoinText.text = "Coins Collected: " + finalCoinAmount.ToString(); ;
        gameOverBackgroundImageCanvasGroup.alpha = timer / fadeTime;

        if (timer > fadeTime + displayImageTime)
        {
            Application.Quit();
        }
    }
}