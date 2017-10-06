using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;




public class getup : MonoBehaviour
{

    private int starttime;
    private int now;
    private int duration;
    public GameObject player;
    private Animator anim;


    void Start()
    {
        starttime = DateTime.Now.Hour * 60 * 60 * 1000 + DateTime.Now.Minute * 60 * 1000 +
        DateTime.Now.Second * 1000 + DateTime.Now.Millisecond;

        anim = GetComponent<Animator>();
    }

    void Update()
    {
        now = DateTime.Now.Hour * 60 * 60 * 1000 + DateTime.Now.Minute * 60 * 1000 +
        DateTime.Now.Second * 1000 + DateTime.Now.Millisecond;

        duration = now - starttime;

        if (duration >= 22000)
        {
            anim.SetBool("is_getup",true );
        }
        AnimatorStateInfo state = anim.GetCurrentAnimatorStateInfo(0);
        if ((state.IsName("getup"))&&(duration >= 22000))
        {
            anim.SetBool("is_getup", false);
        }
    }
}