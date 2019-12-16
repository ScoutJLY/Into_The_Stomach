using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Shooting : MonoBehaviour
{
    public CameraScript CS;
    public GameObject projectile;

    public ParticleSystem muzzleParticle;

    private Animator anim;
    public GameObject gun;

    private AudioSource laserSound;

    public GameObject badExplode;
    public GameObject goodExplode;

    public GameObject crosshair;

    public TextMeshProUGUI scoreText;
    [System.NonSerialized]
    public int score = 0;

    // Use this for initialization
    void Start ()
    {
        anim = gun.GetComponent<Animator>();
        laserSound = GetComponent<AudioSource>();
        scoreText.text = score.ToString();
    }
	
	// Update is called once per frame
	void Update ()
    {
        if (CS.fire)
        {
            Fire();
        }
        else
        {
            Vector3 forward = transform.TransformDirection(Vector3.forward) * 10;
            Debug.DrawRay(transform.position, forward, Color.green);
        }
    }

    void Fire()
    {
        crosshair.transform.Rotate(new Vector3(0, 15, 0));

        Vector3 forward = transform.TransformDirection(Vector3.forward) * 50;
        RaycastHit hit;
        if (Physics.Raycast(transform.position, transform.TransformDirection(Vector3.forward), out hit))
        {
            Debug.DrawRay(transform.position, forward, Color.blue);
            if (hit.collider.tag == "Bad")
            {
                Destroy(hit.collider.gameObject);
                Instantiate(badExplode, hit.transform.position, Quaternion.identity);
                score += 10;
                scoreText.text = score.ToString();
            }
            if (hit.collider.tag == "Good")
            {
                Destroy(hit.collider.gameObject);
                Instantiate(goodExplode, hit.transform.position, Quaternion.identity);
                if (score != 0)
                {
                    score -= 10;
                }
                scoreText.text = score.ToString();
            }
        }
        anim.SetTrigger("Shooting");
        muzzleParticle.Play();
        laserSound.Play();
    }
}
