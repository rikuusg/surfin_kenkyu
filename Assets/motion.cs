using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using UnityEngine.SceneManagement;




public class motion : MonoBehaviour
{

    private int starttime;
    private int now;
    private int duration;
    public GameObject player;

    void Start()
    {
        starttime = DateTime.Now.Hour * 60 * 60 * 1000 + DateTime.Now.Minute * 60 * 1000 +
        DateTime.Now.Second * 1000 + DateTime.Now.Millisecond;
    }

    void Update()
    {
        now = DateTime.Now.Hour * 60 * 60 * 1000 + DateTime.Now.Minute * 60 * 1000 +
        DateTime.Now.Second * 1000 + DateTime.Now.Millisecond;

        duration = now - starttime;

        if (duration < 1)
        {
            this.gameObject.transform.Translate(0, 0, 0);

        }
        else if (duration<21000)
        {
            this.gameObject.transform.Translate(0, 0, 0.03f);
        }
        else if (duration < 22000)
        {
            this.gameObject.transform.Rotate(0, 1.5f, 0);
            this.gameObject.transform.Translate(0.04f, 0.04f, 0.02f);

        }
        else if (duration < 23000)
        {
            this.gameObject.transform.Rotate(0, -0.5f, 0);
            this.gameObject.transform.Translate(0.04f, 0.04f, 0.02f);

        }
        else if (duration < 24000)
        {
            
            this.gameObject.transform.Translate(0.04f, 0.04f, 0.02f);

        }
        else if (duration < 60000)
        {
           
            this.gameObject.transform.Translate(0.04f, 0.04f, 0.02f);
        }
    }
}