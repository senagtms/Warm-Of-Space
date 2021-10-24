using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TurretEnemy : MonoBehaviour
{

    public GameObject shoot;
    public GameObject explosion;
    public float nextSpain = 2f;
    public Transform firePoint;
    int life = 5;


    // Start is called before the first frame update

    void Update()
    {
        if (Time.time > nextSpain)
        {

            nextSpain = Time.time + Random.Range(3,7); ;
            Instantiate(shoot, firePoint.position, firePoint.rotation);

        }


    }
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