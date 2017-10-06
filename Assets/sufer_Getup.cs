using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sufer_Getup : MonoBehaviour {
    private Animator anim;

    void Start()
    {
        anim = GetComponent<Animator>();
    }
    void Update()
    {
        if (Input.GetKey(KeyCode.Space))
        {
            anim.SetBool("is_Getup", true);
        }

        AnimatorStateInfo state = anim.GetCurrentAnimatorStateInfo(0);

        if (state.IsName("surfer_Getup"))
        {
            anim.SetBool("is_Getup", false);
        }
    }
}