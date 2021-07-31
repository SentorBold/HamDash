using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StageController : MonoBehaviour
{
    public static StageController instance;

    [SerializeField] GameObject[] enemies;

    int enemyNum = 1;
   void Awake()
    {
        if (!instance)
        {
            instance = this;
        }
    }
    void Start()
    {
        InstantiateStage();
    }

    public void InstantiateStage()
    {
        for (int i = 0; i < enemyNum; i++)
        {
            enemies[Random.Range(0, enemies.Length)].SetActive(true);
        }
        
    }
}
