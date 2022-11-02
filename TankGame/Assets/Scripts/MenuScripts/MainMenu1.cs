using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu2 : MonoBehaviour
{
    Score score;
    private void Update()
    {
        if (score.player1Score == 0 )
        {
            SceneManager.LoadScene("Menu");
        }
    }
}
