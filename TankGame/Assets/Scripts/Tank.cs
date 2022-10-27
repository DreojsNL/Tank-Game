using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tank : MonoBehaviour
{
    Rigidbody2D rb;
    [SerializeField]
    private float MoveSpeed;
    public bool TankController;
    public bool TankHit;
    public bool TankHit2;
    Score point1;
    private void Start()
    {
        GameObject f = GameObject.FindGameObjectWithTag("Score");
        point1 = f.GetComponent<Score>();
    }


    void Update()
    {
        if (point1.PL1 == true && point1.PL2 == true)
        {

            if (TankController == true)
            {
             
                    transform.Translate(Vector2.right * Input.GetAxisRaw("Horizontal") * MoveSpeed * Time.deltaTime);
                
            }
            if (TankHit == true)
            {
                GameObject.Find("Canvas").GetComponent<Score>().AddP1Score();
                ;
                Invoke("SetFalse", 0.0001f);
            }
            if (TankHit2 == true)
            {
                GameObject.Find("Canvas").GetComponent<Score>().AddP2Score();
                Invoke("SetFalse", 0.0001f);
            }
        }

        
            
        
    }
    void SetFalse()
    {

        TankHit = false;
        TankHit2 = false;
    }
}

