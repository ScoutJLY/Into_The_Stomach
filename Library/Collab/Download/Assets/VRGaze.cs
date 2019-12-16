using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class VRGaze : MonoBehaviour {

    public Image UiGaze;

    public float totaltime = 2;
    bool gvrStatus;
    float gvrTimer;
    public float speed = 0.1f;

    private void Start()
    {
        UiGaze.enabled = false;
    }

    private void Update()
    {
        if(gvrStatus)
        {
            UiGaze.enabled = true;
            gvrTimer += Time.deltaTime * speed;
            UiGaze.fillAmount = gvrTimer / totaltime;
        }
    }

    public void GVRoN()
    {
        gvrStatus = true;
    }

    public void GVRoFF()
    {
        gvrStatus = false;
        gvrTimer = 0;
        UiGaze.fillAmount = 0;
    }
}
