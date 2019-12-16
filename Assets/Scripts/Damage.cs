using UnityEngine;

public class Damage : MonoBehaviour
{
    public int damage = 1;
    public GameObject explosion;

    void OnTriggerEnter(Collider other)
    {
        var health = other.GetComponent<Health>();

        if (health != null)
        {
            health.TakeDamage(damage);
        }

        if (other.name == "CubeRoomEnv")
        {
            Debug.Log("Wall hit, explosion effect");
            Destroy(gameObject);
            //Instantiate(explosion, transform.position, Quaternion.identity);
        }
    }
}
