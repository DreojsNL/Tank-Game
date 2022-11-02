using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Test3 : MonoBehaviour
{



    public void LevelSelect()
    {
        Invoke("test", 0.5f);
    }
    public void test()
    {
        SceneManager.LoadScene("Level 1");
    }
}
