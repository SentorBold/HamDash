using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;


public class Timer : MonoBehaviour
{
<<<<<<< Updated upstream
    int sd = 1;
    public Text timer;
=======
    public TextMeshProUGUI timer;
>>>>>>> Stashed changes
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