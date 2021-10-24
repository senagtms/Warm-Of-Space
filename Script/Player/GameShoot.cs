using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameShoot : MonoBehaviour
{
    public Transform firePoint;

    public GameObject shoot;

    
    // Update is called once per frame
    void Update()
    {

        Shoot();
    }

    public void Shoot()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            Instantiate(shoot, firePoint.position, firePoint.rotation);
        }

    }
    
}
