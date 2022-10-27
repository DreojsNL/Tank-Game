using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletControler : MonoBehaviour
{
  
   public float bulletTTl = 0.5f;
    Rigidbody2D rb;
    ParticleSystem ps;
    public bool fack;
    public Tank tank1;

    void Start()
    {
        GameObject f = GameObject.FindGameObjectWithTag("PTank");
        tank1 = f.GetComponent<Tank>();
        
        fack = false;
        rb = GetComponent<Rigidbody2D>(); 
    }
    private void Update()
    {
        if (fack == true)
        {
            bulletTTl -= Time.deltaTime;
            if (bulletTTl < 0)
            {
                Destroy(gameObject);
            }
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        fack = true;
        GetComponent<SpriteRenderer>().enabled = false;
        GetComponent<ParticleSystem>().Play();
        if (collision.gameObject.tag == "Floer")
        { 
            Destroy(gameObject);
        }
        if (collision.gameObject.tag == "PTank")
        {
          tank1.TankHit = true;
        }
        if (collision.gameObject.tag == "PTank2")
        {
            tank1.TankHit2 = true;
        }
    }
}
