using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Hills : MonoBehaviour
{
    public void LevelSelect()
    {
        Invoke("test", 0.5f);
    }
    public void test()
    {
        SceneManager.LoadScene("Level");
    }
}

