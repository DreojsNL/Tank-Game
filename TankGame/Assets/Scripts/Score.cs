using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Score : MonoBehaviour
{
    public int player1Score = 3;
    public int player2Score = 3;
    public bool PL1 = true;
    public bool PL2 = true;
    public TextMeshProUGUI p1Text;
    public TextMeshProUGUI p2Text;
    

    void Update()
    {
        if (player1Score >= 1)
        {
            PL1 = true;
        }
        else
        {
            PL1 = false;
        }
        if (player2Score >= 1)
        {
            PL2 = true;
        }
        else
        {
            PL2 = false;
        }
    }
    public void AddP1Score()
    {
        player1Score--;
        p1Text.text = player1Score.ToString();
    }
    public void AddP2Score()
    {
        player2Score--;
        p2Text.text = player2Score.ToString();
    }
}
