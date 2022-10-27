using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Animation1 : MonoBehaviour
{
    private Animator animator;
    Score point1;

    private void Start()
    {
        animator = GetComponent<Animator>();

    }

    private void Update()
    {


            if (Input.GetAxisRaw("Horizontal") != 0)
            {
                animator.SetBool("IsDriving", true);
            }
            else
            {
                animator.SetBool("IsDriving", false);
            }
        
    }
}