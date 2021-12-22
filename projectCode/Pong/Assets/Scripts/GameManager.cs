using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    private int playerScore;
    private int computerScore;

    [SerializeField]
    private Text playerScoreText;
    [SerializeField]
    private Text computerScoreText;

    [SerializeField]
    private Ball ball;

    [SerializeField]
    private Paddle playerPaddle;
    [SerializeField]
    private Paddle computerPaddle;

    public void PlayerScores()
    {
        playerScore++;
        playerScoreText.text = playerScore.ToString();

        ResetRound();
    }

    public void ComputerScores()
    {
        computerScore++;
        computerScoreText.text = computerScore.ToString();

        ResetRound();
    }

    private void ResetRound()
    {
        playerPaddle.ResetPosition();
        computerPaddle.ResetPosition();
        ball.ResetPosition();
        ball.AddStartingForce();
    }
}
