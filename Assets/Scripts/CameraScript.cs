using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraScript : MonoBehaviour
{
    static WebCamTexture backCam;
    private Vector4 colour;
    public GameObject player;

    [HideInInspector]
    public bool fire = false;

	// Use this for initialization
	void Start ()
    {
        if (backCam == null)
        {
            backCam = new WebCamTexture();
        }

        GetComponent<Renderer>().material.mainTexture = backCam;

        if (!backCam.isPlaying)
        {
            backCam.Play();
        }
	}

    void Update()
    {
        colour = backCam.GetPixel(1080, 540);
        //ToggleCamera(backCam, backCam);

        if (colour.x < 0.1 && colour.y < 0.1 && colour.z < 0.1)
        {
            //Debug.Log("Black Detected, Shoot");
            fire = true;
        }

        else
        {
            fire = false;
        }
    }

    void ToggleCamera(Camera cameraToggle, Camera cameraOutput)
    {
        Debug.Log("Pixel width :" + cameraOutput.pixelWidth + " Pixel height : " + cameraOutput.pixelHeight);
    }
}
