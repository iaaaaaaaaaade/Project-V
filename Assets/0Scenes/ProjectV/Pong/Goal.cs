using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Goal : MonoBehaviour
{
    [SerializeField]
    private GameObject GameManager;
    public bool isPlayer1Goal;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Ball"))
        {
            if (!isPlayer1Goal)
            {
                Debug.Log("Player 1 Scored...");
                GameManager.GetComponent<GameManager>().Player1Scored();
            }
            else
            {
                Debug.Log("Bot Scored...");
                GameManager.GetComponent<GameManager>().BotScored();
            }
        }
    }
}
