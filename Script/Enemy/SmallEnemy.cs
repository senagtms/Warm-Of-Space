using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SmallEnemy : MonoBehaviour
{
    int life = 5;
    public GameObject explosion;
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Turret"))
        {
            life--;
            if (life.Equals(0))
            {
                Instantiate(explosion, transform.position, Quaternion.identity);
                Destroy(other.gameObject);
                Destroy(transform.parent.gameObject);
                ScoreManager.instance.Addpoint();
            }
        }
    }
}
