using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelCompleted : MonoBehaviour
{
    public float fadeTime = 1f;
    public float displayImageTime = 1f;
    public GameObject player;
    public CanvasGroup exitBackgroundImageCanvasGroup;
    public CanvasGroup gameOverBackgroundImageCanvasGroup;


    bool isPlayerAtExit;
    float timer;

    
    public GameObject player2;
    Miner miner;

    void Awake()
    {
        miner = player2.GetComponent<Miner>();

    }


    void OnTriggerEnter(Collider other)
    {

        if (other.gameObject == player)
        {
            isPlayerAtExit = true;
        }


    }

    void Update()
    {
        if (miner.playTime <= 0)
        {

            GameOver();
        }

    }

    void EndLevel()
    {
        timer += Time.deltaTime;

        exitBackgroundImageCanvasGroup.alpha = timer / fadeTime;

        if (timer > fadeTime + displayImageTime)
        {
            Application.Quit();
        }
    }

    void GameOver()
    {
        timer += Time.deltaTime;

        gameOverBackgroundImageCanvasGroup.alpha = timer / fadeTime;

        if (timer > fadeTime + displayImageTime)
        {
            Application.Quit();
        }
    }
}