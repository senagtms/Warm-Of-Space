using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeywordController : MonoBehaviour
{
   
    float speed = 0.1f;
    MyCamera MyCamera;

    float x, y;

     void Start()
    {
        MyCamera = GetComponent<MyCamera>();
    }
    // Update is called once per frame
    void LateUpdate()
    {
        x = Input.GetAxis("Horizontal");
        y = Input.GetAxis("Vertical");
        Vector3 movement = new Vector3(x*speed, y*speed, 0);
        MyCamera.player.Translate(movement);
        Vector3 pos = MyCamera.player.position;
        MyCamera.playerPosition(pos);
       ;
    }
    
}
