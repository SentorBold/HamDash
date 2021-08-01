using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Timer : MonoBehaviour
{
    public Text timer;
    float timeCounter = 0f;
    float stageCounter = 3;

    void Update()
    {
        timeCounter += Time.deltaTime;
        timer.text = (int)timeCounter + "";
        if(timeCounter >= stageCounter)
        {
            stageCounter += 5;          
            StageController.instance.InstantiateStage();
        }
    }
}