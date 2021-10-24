using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Enemy : MonoBehaviour
{
    private Rigidbody2D rb;
    


    private void Start() 
    {
        rb = GetComponent<Rigidbody2D>();
        rb.velocity = new Vector2(-Random.Range(5,10), 0);

    }

   
    private void OnBecameInvisible() //kameranýn çýktýðýnda
    {
        Debug.Log("OnBecameInvisible");
        Destroy(gameObject);
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.CompareTag("Player"))
        {
            SceneManager.LoadScene(1);
        }

    }
}
