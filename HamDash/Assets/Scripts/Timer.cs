using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;


public class Timer : MonoBehaviour
{

    public TextMeshProUGUI timer;

    float timeCounter = 0f;
    float stagecounter = 10;
    float posChangeCounter=2f;

    void Update()
    {
        timeCounter += Time.deltaTime;
        timer.text = (int)timeCounter + "";
        if (timeCounter >= posChangeCounter)
        {
            posChangeCounter = timeCounter+2;
            StageController.instance.InstantiateStage();
        }
        if(timeCounter >= stagecounter)
        {
            stagecounter += 10;   
            StageController.instance.AddEnemyNum();
        }
    }
    public int GetTime()
    {
        return (int)timeCounter;
    }
}