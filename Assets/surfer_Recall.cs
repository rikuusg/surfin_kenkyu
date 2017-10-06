using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class surfer_Recall : MonoBehaviour
{

    private Animator anim;

    void Start()
    {
        anim = GetComponent<Animator>();
    }
    void Update()
    {
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            if (Input.GetKey(KeyCode.DownArrow))
            {
                anim.SetBool("is_Recall", true);
            }
        }

        AnimatorStateInfo state = anim.GetCurrentAnimatorStateInfo(0);

        if (state.IsName("Surfer_Recall"))
        {
            anim.SetBool("is_Recall", false);
        }
    }
}