using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Test : MonoBehaviour
{
    public string fac;
    public Score score;

    public void Update()
    {
        if (score.player1Score < 1)
        {
            SceneManager.LoadScene(fac);
        }
        if (score.player2Score < 1)
        {
            SceneManager.LoadScene(fac);
        }
    }
}
