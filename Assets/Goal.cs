using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Goal : MonoBehaviour
{
    public bool isPlayer1;

   
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.CompareTag("Ball"))
        if (isPlayer1)
        {
            Debug.Log("Player 1 scored ...");
            GameObject.Find("GameManager").GetComponent<GameManager>().player1Scored();
        }
        else
        {
            Debug.Log("Player 2 scored ...");
            GameObject.Find("GameManager").GetComponent<GameManager>().player2Scored();
        }
    }
       
    
}