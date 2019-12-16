using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Events;

public class GvrButton : MonoBehaviour {

    public Image imgCirlce;
    public UnityEvent GvrClick;
    public float totaltime = 2;
    bool gvrstatus;
    public float gvrtimer;


    private void Start()
    {
        imgCirlce.enabled = false;
    }
    // Update is called once per frame
    void Update() {
        if(gvrstatus)
        {
            imgCirlce.enabled = true;
            gvrtimer += Time.deltaTime;
            imgCirlce.fillAmount = gvrtimer / totaltime;
            //Debug.Log("w");

        }

        if(gvrtimer >totaltime)
        {
            //Debug.Log("t");
            GvrClick.Invoke();  
        }
    }

    public void GvrOn()
    {
        //Debug.Log("d");
        gvrstatus = true;
    }

    public void GvrOff()
    {
        
       // Debug.Log("e");
        gvrstatus = false;
        gvrtimer = 0;
        imgCirlce.fillAmount = 0;
    }

}
