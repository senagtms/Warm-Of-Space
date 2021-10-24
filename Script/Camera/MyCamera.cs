using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MyCamera : MonoBehaviour
{
    public BoxCollider2D cameraBox;
    public BoxCollider2D boundary;
    float zaman = 1;
    public Transform player;
    public Camera mainCamera;
    public float leftPivot, rightPivot, topPivot, botPivot;
    public float minX, maxX, minY, maxY;
    public float objectWidht;
    public float objectHeight;




    public void playerPosition(Vector3 playerpos)
    {
        Kamerasinir();
        pivothesaplama();
        Vector3 start = transform.position; //baslangýc konumu
        Vector3 finish = playerpos; //oyuncunun durduðu nokta
        
        transform.position = Vector3.Lerp(start, finish, zaman * Time.deltaTime);   //baslangýci bitis noktalarý arasýndaki kaç tane kare olduðunu hesaplayan
        transform.position = new Vector3
            (
            Mathf.Clamp(transform.position.x, leftPivot, rightPivot), //max ve min pivot noktasýný yuvarlayarak sýnýrlar için kullanýlýr
            Mathf.Clamp(transform.position.y, botPivot, topPivot), //
            transform.position.z
            );
    }

    public void Kamerasinir()
    {
        maxY = mainCamera.orthographicSize - objectHeight;
        minY = -mainCamera.orthographicSize + objectHeight;
        maxX = (mainCamera.orthographicSize * mainCamera.aspect) - objectWidht;
        minX = -(mainCamera.orthographicSize * mainCamera.aspect) + objectWidht;
        Vector3 pos = player.position;

        // Horizontal 
        if (pos.x < minX) pos.x = minX;
        if (pos.x > maxX) pos.x = maxX;

        // vertical 
        if (pos.y < minY) pos.y = minY;
        if (pos.y > maxY) pos.y = maxY;

        // Update position
        player.position = pos;
    }

    void pivothesaplama()
    {
        botPivot = boundary.bounds.min.y + cameraBox.size.y / 2;
        topPivot = boundary.bounds.max.y - cameraBox.size.y / 2;
        leftPivot = boundary.bounds.min.x + cameraBox.size.x / 2;
        rightPivot = boundary.bounds.max.x - cameraBox.size.x / 2;
    }
    void Start()
    {
        mainCamera = Camera.main;
        objectWidht = player.GetChild(0).GetComponent<SpriteRenderer>().bounds.extents.x;
        objectHeight = player.GetChild(0).GetComponent<SpriteRenderer>().bounds.extents.y;
        // Debug.Log($"W: {objectWidht}");

    }
}
