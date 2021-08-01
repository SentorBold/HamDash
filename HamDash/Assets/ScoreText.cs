using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ScoreText : MonoBehaviour
{
    [SerializeField]TextMeshProUGUI highScoreText;
    [SerializeField]TextMeshProUGUI scoreText;

    ScoreHolder SH;
    void Start()
    {
        SH = FindObjectOfType<ScoreHolder>();
        highScoreText.text = "High Score :" + SH.GetHighScore().ToString();
        scoreText.text ="Score : " +SH.GetScore().ToString();
    }

  
}
