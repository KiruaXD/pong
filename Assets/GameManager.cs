using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    [Header("Ball")]
    public GameObject ball;

    [Header("Player1")]
    public GameObject player1Paddle;
    public GameObject player1Goal;

    [Header("Player2")]
    public GameObject player2Paddle;
    public GameObject player2Goal;

    [Header("Score UI")]
    public GameObject Player1Text;
    public GameObject Player2Text;

    private int player1score;
    private int player2score;

    public void player1Scored()
    {
        Debug.Log("1Score");
        player1score++;
        Player1Text.GetComponent<TextMeshProUGUI>().text = player1score.ToString();
        Reset();
    }

    public void player2Scored()
    {
        Debug.Log("2Score");
        player2score++;
        Player2Text.GetComponent<TextMeshProUGUI>().text = player2score.ToString();
        Reset();
    }

    private void Reset()
    {
        ball.GetComponent<Ball>().Reset();
        player1Paddle.GetComponent<Paddle>().Reset();
        player2Paddle.GetComponent<Paddle>().Reset();
    }
}
