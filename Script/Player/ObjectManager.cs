using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectManager : MonoBehaviour
{

    public GameObject Player;
    public MyCamera MyCamera;


    private float StepSize = 0.05f;

    public void ObjectUp()
    {
        Debug.Log("ObjectUp");

        Player.transform.Translate(transform.up * StepSize); //transformdan translate fonksiyonu çaðýrýldý ve vector2 ye yeni deðer atandý // down -y anlamýnda
        Vector3 pos = transform.position;
        MyCamera.playerPosition(pos);


    }
    public void ObjectDown()
    {
        Player.transform.Translate(Vector2.down * StepSize);
        Vector3 pos = transform.position;
        MyCamera.playerPosition(pos);

    }
    public void ObjectRight()
    {
        Player.transform.Translate(Vector2.right * StepSize);
        Vector3 pos = transform.position;
        MyCamera.playerPosition(pos);

    }
    public void ObjectLeft()
    {
        Player.transform.Translate(Vector2.left * StepSize);
        Vector3 pos = transform.position;
        MyCamera.playerPosition(pos);

    }



}
