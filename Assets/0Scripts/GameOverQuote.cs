using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class GameOverQuote : MonoBehaviour
{
    public TMP_Text quoteText;
    public void Setup()
    {
        quoteText.text = "QuoteHere";
    }
}
