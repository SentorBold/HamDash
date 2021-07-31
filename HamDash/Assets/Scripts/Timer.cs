using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{
    public Text timer;
    float timeCounter = 0f;

    void Update()
    {
        timeCounter += Time.deltaTime;
        timer.text = (int)timeCounter + "";
    }
}