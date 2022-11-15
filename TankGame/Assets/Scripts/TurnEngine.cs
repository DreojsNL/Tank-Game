using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TurnEngine : MonoBehaviour
{
    int playerTurn = 1;
    public GameObject player1;
    public GameObject player2;
  

    void Start()
    {
        GameObject[] players = GameObject.FindGameObjectsWithTag("Player");
        foreach (GameObject g in players)
        {
            if (g.GetComponent<Speler>().spelerNummer == 1)
            {
                player1 = g;
            }
            if (g.GetComponent<Speler>().spelerNummer == 2)
            {
                player2 = g;
            }
        }
        player1.GetComponent<Speler>().zetBeurt(true);
        player2.GetComponent<Speler>().zetBeurt(false);
    }

    public void wisselBeurt()
    {
        if (playerTurn == 1)
        {
            playerTurn = 2;
            player1.GetComponent<Speler>().zetBeurt(false);
            player2.GetComponent<Speler>().zetBeurt(true);
            return;
        }
        else if (playerTurn == 2)
        {
            playerTurn = 1;
            player1.GetComponent<Speler>().zetBeurt(true);
            player2.GetComponent<Speler>().zetBeurt(false);
            return;
        }
    }
}
