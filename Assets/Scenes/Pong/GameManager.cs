using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class GameManager : MonoBehaviour
{
    [Header("Ball")]
    public GameObject ball;

    [Header("Player 1")]
    public GameObject player1Paddle;
    public GameObject player1Goal;
   
    [Header("BotPaddle")]
    public GameObject BotPaddle;
    public GameObject BotGoal;
    
    [Header("Score UI")]
    public GameObject player1Text;
    public GameObject BotText;

    private int Player1Score;
    private int BotScore;
    public void Player1Scored()
    {
        Player1Score++;
        player1Text.GetComponent<TextMeshProUGUI>().text = Player1Score.ToString();
        ResetPosition();
    }
    public void BotScored()
    {
        BotScore++;
        BotText.GetComponent<TextMeshProUGUI>().text = BotScore.ToString();
        ResetPosition();
    }
    private void ResetPosition()
    {
        ball.GetComponent<Ball>().Reset();
        player1Paddle.GetComponent<Paddle>().Reset();
        BotPaddle.GetComponent<BotPaddle>().Reset();
    }
}
