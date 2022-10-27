using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class BarrelRotator : MonoBehaviour
{
    [SerializeField]
    Transform barrelRotator;
    [SerializeField]
    GameObject bulletToFire;
    public Transform firePoint;
    public int MoveSpeedBullet;
    public float BarrleSpeed;
    [SerializeField]
    Tank tank;
    Score point1;
    public TextMeshProUGUI textMeshProUGUI;
 
   
    private void Start()
    {

        GameObject f = GameObject.FindGameObjectWithTag("Score");
        point1 = f.GetComponent<Score>();

        //power = GetComponent<PowerScript>();
    }

    void Update()
    {
        textMeshProUGUI.text = MoveSpeedBullet.ToString();


        if (Input.GetKeyDown(KeyCode.LeftShift))
        {
            MoveSpeedBullet += 1;
        }
        if (Input.GetKeyDown(KeyCode.LeftControl))
        {
            MoveSpeedBullet -= 1;
        }
        if(MoveSpeedBullet < 0)
        {
            MoveSpeedBullet = 0;
        }
        if (MoveSpeedBullet > 20)
        {
            MoveSpeedBullet = 20;
        }
            if (point1.PL1 == true && point1.PL2 == true)
        {
            if (tank.TankController == true)
            {
                barrelRotator.Rotate(Vector3.forward, Input.GetAxis("Vertical") * Time.deltaTime * BarrleSpeed);

                if (MoveSpeedBullet > 0)
                {
                    if (Input.GetKeyDown(KeyCode.Space))
                    {

                        GameObject b = Instantiate(bulletToFire, firePoint.position, firePoint.rotation);
                        b.GetComponent<Rigidbody2D>().AddForce(barrelRotator.up * MoveSpeedBullet, ForceMode2D.Impulse);
                    }
                }
            }
        }
         
    }
}
