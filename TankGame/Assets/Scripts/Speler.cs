using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Speler : MonoBehaviour
{
    public int spelerNummer;
    [SerializeField]
    Material inactiefMat;
    [SerializeField]
    Material actiefMat;
    bool aanDeBeurt = false;
    [SerializeField]
    Tank tank;
    public void zetBeurt(bool b)
    {
       
        if (b == true)
        {
            
            GetComponent<SpriteRenderer>().material = actiefMat;
            Invoke("SetTrue", 0.2f);
        }
        else
        {
            tank.TankController = false;
            aanDeBeurt = false;
            GetComponent<SpriteRenderer>().material = inactiefMat;
        }
    }

    void SetTrue()
    {
        tank.TankController = true;
        aanDeBeurt = true;
    }

    private void Update()
    {
        if (aanDeBeurt == true)
        {
           
            if (Input.GetKeyDown(KeyCode.Space))
            {

                GameObject.FindGameObjectWithTag("TurnEngine").GetComponent<TurnEngine>().wisselBeurt();
            }
        }
    }
}
