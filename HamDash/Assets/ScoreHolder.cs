using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreHolder : MonoBehaviour
{
    static bool dontDestroy=false;

    int score;
    int highScore;
    void Awake()
    {
        if (dontDestroy) Destroy(gameObject);

        dontDestroy = true;
        DontDestroyOnLoad(gameObject);
    }

    public void SetScore()
    {
        score = FindObjectOfType<Timer>().GetTime();
        if (highScore < score)
        {
            highScore = score;
        }
    }
    public int GetScore()
    {
        return score;
    }
    public int GetHighScore()
    {
        return highScore;
    }

}
