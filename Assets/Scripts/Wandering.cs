using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Wandering : MonoBehaviour
{
    [SerializeField]
    private float rotateSpeed = 1.0f;

    [SerializeField]
    private float movementSpeed = 1.0f;

    [SerializeField]
    private float obstacleRange = 1.0f;

    // Use this for initialization
    void Start ()
    {
        StartCoroutine("Die");
	}
	
	// Update is called once per frame
	void Update ()
    {
        transform.Rotate(rotateSpeed * Time.deltaTime, rotateSpeed * Time.deltaTime, rotateSpeed * Time.deltaTime);
        transform.Translate(0, 0, movementSpeed * Time.deltaTime);

        Ray ray = new Ray(transform.position, transform.forward);
        RaycastHit hit;
        if (Physics.SphereCast(ray, 0.75f, out hit))
        {
            if (hit.distance < obstacleRange)
            {
                float angle = Random.Range(-110, 110);
                transform.Rotate(0, angle, 0);
            }
        }
    }

    IEnumerable Die()
    {
        yield return new WaitForSeconds(5);
        Destroy(gameObject);
    }
}
