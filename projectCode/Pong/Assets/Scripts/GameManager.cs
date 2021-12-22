using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    private int playerScore;
    private int computerScore;

    [SerializeField]
    private Ball ball;

    public void PlayerScores()
    {
        playerScore++;

        ball.ResetPosition();
    }

    public void ComputerScores()
    {
        computerScore++;

        ball.ResetPosition();
    }
}
