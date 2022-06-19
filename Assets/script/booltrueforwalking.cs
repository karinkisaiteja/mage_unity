using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class booltrueforwalking : MonoBehaviour
{
    Animator animator;
    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey("w"))
        {
            animator.SetBool("iswalking", true);
        }
         if (Input.GetKey("w") && Input.GetKey(KeyCode.LeftShift))
        {
            animator.SetBool("walktorun", true);
        }
        else
        {
            animator.SetBool("iswalking", false);
            animator.SetBool("walktorun", false);
        }
    }
}
