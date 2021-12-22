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

    private AudioSource audSource;
    [SerializeField]
    private AudioClip paddleHitSound;
    [SerializeField]
    private AudioClip wallHitSound;
    [SerializeField]
    private AudioClip scoreSound;

    private void Awake()
    {
        audSource = GetComponent<AudioSource>();
    }

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
        PlayScoreSound();

        playerPaddle.ResetPosition();
        computerPaddle.ResetPosition();
        ball.ResetPosition();
        ball.AddStartingForce();
    }

    private void PlayScoreSound()
    {
        audSource.PlayOneShot(scoreSound);
    }

    public void PlayWallHitSound()
    {
        audSource.PlayOneShot(wallHitSound);
    }

    public void PlayPaddleHitSound()
    {
        audSource.PlayOneShot(paddleHitSound);
    }
}
