using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TimerScript : MonoBehaviour
{
    public float gameTime = 0;
    public GameOverScreen GameOverScreen;
    public GameOverQuote GameOverQuote;
    public GameOverScreen GameWonScreen;
    public float timeScaling;
    public float desiredGameSecondDuration;

    private void Start()
    {
        timeScaling = desiredGameSecondDuration/360;
    }
    void GameOver()
    {
        GameOverScreen.Setup(gameTime, timeScaling);
        //GameOverQuote.Setup();
    }

    void GameWon()
    {
        GameOverScreen.Setup(gameTime, timeScaling);
    }
    public void FixedUpdate()
    {
        gameTime = Time.time;
        if (gameTime == desiredGameSecondDuration)
        {
            gameTime = desiredGameSecondDuration;
            GameWon();
        }
    }
}
