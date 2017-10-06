using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class surfer_tecnic : MonoBehaviour
{

    public float Speed = 0.5f;
    public GameObject player;
    public Rigidbody rb;
    private Animator anim;

    void Start()
    {

        rb = GetComponent<Rigidbody>();
        anim = GetComponent<Animator>();
    }



    void Update()
    {
        if (Input.GetKey(KeyCode.RightArrow))
        {
            if (Input.GetKey(KeyCode.LeftArrow))
            {
                anim.SetBool("is_spin", true);
            }
        }
        AnimatorStateInfo state = anim.GetCurrentAnimatorStateInfo(0);

        if (state.IsName("surfer_spin"))
        {
            anim.SetBool("is_spin", false);
        }
    }
}

        
    
