using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletControler : MonoBehaviour
{
    public bool shit;
   public float bulletTTl = 0.5f;
    Rigidbody2D rb;
    ParticleSystem ps;
    public bool fack;
    public Tank tank1;
    public bool Check;

    void Start()
    {
        GameObject f = GameObject.FindGameObjectWithTag("PTank");
        tank1 = f.GetComponent<Tank>();
        shit = false;
        fack = false;
        Check = false;
        rb = GetComponent<Rigidbody2D>(); 
    }
    private void Update()
    {
           if (gameObject.activeSelf)
        {
            Check = true;
            
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        fack = true;
        shit = true;
        GetComponent<SpriteRenderer>().enabled = false;
        GetComponent<ParticleSystem>().Play();
        if (collision.gameObject.tag == "Floer")
        {
            Invoke("destroy" , 0.3f);
        }
        if (collision.gameObject.tag == "PTank")
        {
          tank1.TankHit = true;
            Invoke("destroy", 0.1f);
        }
        if (collision.gameObject.tag == "PTank2")
        {        

            tank1.TankHit2 = true;
            Invoke("destroy", 0.1f);
        }
       
    }
    private void destroy()
    {
        Destroy(gameObject);
    }
}
