using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;
using UnityEngine.UI;
using UnityEngine.UIElements;
using UnityEngine.SceneManagement;
public class GameOverScreen : MonoBehaviour
{
    public TMP_Text timeText;
    public void Setup(float gameTime, float timeScaling)
    {
        int gameHour = (int)(gameTime / (60*timeScaling));
        var gameMinute = (gameTime % (60*timeScaling));
        
        gameObject.SetActive(true);
        
        timeText.text = "0" + gameHour.ToString() + ":" + gameMinute.ToString() + " AM";
    }

    public void Finish()
    {
        gameObject.SetActive(true);

    }
    public void RestartButton()
    {
        SceneManager.LoadScene("ProjectV");
    }
    public void ExitButton()
    {
        SceneManager.LoadScene("MainMenu");
    }
}
