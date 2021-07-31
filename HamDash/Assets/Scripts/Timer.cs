using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Timer : MonoBehaviour
{
    public UnityEngine.UI.Text timer;
    float timeCounter = 0f;

    // Update is called once per frame
    void Update()
    {
        timeCounter += Time.deltaTime;
        timer.text = (int)timeCounter + "";
    }
}