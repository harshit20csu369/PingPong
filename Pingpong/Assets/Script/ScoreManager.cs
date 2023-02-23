using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour
{


    private int player1Score = 0;
    private int player2Score = 0;

    public Text player1ScoreText;
    public Text Player2ScoreText;

    public void playerGoal()
    {
        player1Score++;
        player1ScoreText.text = player1Score.ToString();
    }

    public void Player2Goal()
    {
        player2Score++;
        Player2ScoreText.text = player2Score.ToString();
    }
}
