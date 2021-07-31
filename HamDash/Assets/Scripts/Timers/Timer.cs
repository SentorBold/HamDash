using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Timer : MonoBehaviour
{
    int sd = 1;
    public Text timer;
    float timeCounter = 0f;
    float stagecounter = 3;

    void Update()
    {
        timeCounter += Time.deltaTime;
        timer.text = (int)timeCounter + "";
        if(timeCounter >= stagecounter)
        {
            stagecounter += 3;
           
            StageController.instance.InstantiateStage();



        }
 

    }
}