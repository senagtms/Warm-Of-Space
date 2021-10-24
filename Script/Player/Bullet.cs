using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public Rigidbody2D rb;
    public float speed = 5;
    public GameObject explosion;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        rb.velocity = new Vector2(speed, 0);
    }

    void OnTriggerEnter2D(Collider2D other)
    {

        if (other.tag == "Enemy")
        {
            Instantiate(explosion, transform.position, Quaternion.identity);
            Destroy(other.gameObject);
            Destroy(this.gameObject);
            ScoreManager.instance.Addpoint();
        }
       
        if (other.tag == "Bullet")
        {
            Destroy(other.gameObject);
            Destroy(this.gameObject);
           
            }

    }

   
        private void OnBecameInvisible() //kameranýn çýktýðýnda
    {
        Debug.Log("OnBecameInvisible");
        Destroy(gameObject);
    }
}
