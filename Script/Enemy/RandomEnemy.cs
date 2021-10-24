using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomEnemy : MonoBehaviour
{
    
    Vector2 objeposition;

    float nextSpain = 2f;
    public MyCamera MyCamera;
    private Vector2 screenBounds;
    public List<GameObject> EnemyList;
 
    int randEnemy;

    // Start is called before the first frame update
    void Start()
    {

        screenBounds = MyCamera.mainCamera.ScreenToWorldPoint(new Vector3(MyCamera.minX, MyCamera.minY, MyCamera.mainCamera.transform.position.z));
       

    }
    void Update()
    {
        if (Time.time > nextSpain)
        {
            nextSpain = Time.time + 2f;

            objeposition = new Vector2(screenBounds.x * -2, Random.Range(-screenBounds.y, screenBounds.y));
            randEnemy = Random.Range(0, 3);

                Instantiate(EnemyList[randEnemy], objeposition, Quaternion.identity);
            /*
            if (scoreManager.score== 5)
            {

                Instantiate(ships, objeposition, Quaternion.identity);

            }*/
        }

    }
}
