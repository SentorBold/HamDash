using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class Timer2 : MonoBehaviour
{
    public Text timer;
    float timeCounter = 0f;

    void Update()
    {
        timeCounter += Time.deltaTime;
        timer.text = (int)timeCounter + "";
        if (timeCounter >= 20f)
        {
            SceneManager.LoadScene("Level 3");
        }
    }
}
