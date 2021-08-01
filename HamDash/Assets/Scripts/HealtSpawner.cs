using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealtSpawner : MonoBehaviour
{


    public GameObject heal;
    Vector2 bottomLeft;
    Vector2 BottomRight;
    float timeCounter = 0f;
    float spawnheal = 20f;

    float x;
    float y;

   

    void Start()
    {
        bottomLeft = Camera.main.ScreenToWorldPoint(new Vector2(0, 0));
        BottomRight = Camera.main.ScreenToWorldPoint(new Vector2(Screen.width, Screen.height));
       

       
    }

    // Update is called once per frame
    void Update()
    {
        timeCounter += Time.deltaTime;
        if (timeCounter >= spawnheal)
        {
            spawnheal += 20;
            Healt();






        }
    }
     void Healt()
    {
        x = Random.Range(bottomLeft.x, BottomRight.x);
        y  = Random.Range(bottomLeft.y, BottomRight.y);
        GameObject newHealt = Instantiate(heal);
        newHealt.transform.position = new Vector2(x, y);
    }
}
