using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Batery : MonoBehaviour
{
    public BarrelRotator Move;
    public BarrelRotator Move2;
    public Sprite[] batery;


    void Update()
    {
        if (Move.MoveSpeedBullet == 8)
        {
            GetComponent<SpriteRenderer>().sprite = batery[0];
        }
        if (Move.MoveSpeedBullet == 7)
        {
            GetComponent<SpriteRenderer>().sprite = batery[2];
        }
        if (Move.MoveSpeedBullet == 6)
        {
            GetComponent<SpriteRenderer>().sprite = batery[3];
        }
        if (Move.MoveSpeedBullet == 4)
        {
            GetComponent<SpriteRenderer>().sprite = batery[4];
        }
        if (Move.MoveSpeedBullet == 3)
        {
            GetComponent<SpriteRenderer>().sprite = batery[5];
        }
        if (Move.MoveSpeedBullet == 2)
        {
            GetComponent<SpriteRenderer>().sprite = batery[6];
        }
        if (Move.MoveSpeedBullet == 1)
        {
            GetComponent<SpriteRenderer>().sprite = batery[7];
        }
        if (Move.MoveSpeedBullet == 0)
        {
            GetComponent<SpriteRenderer>().sprite = batery[8];
        }
        if (Move.MoveSpeedBullet >= 10)
        {
            GetComponent<SpriteRenderer>().sprite = batery[9];
        }
        if (Move.MoveSpeedBullet >= 13)
        {
            GetComponent<SpriteRenderer>().sprite = batery[10];
        }
        if (Move.MoveSpeedBullet >= 17)
        {
            GetComponent<SpriteRenderer>().sprite = batery[11];
        }
    }
}