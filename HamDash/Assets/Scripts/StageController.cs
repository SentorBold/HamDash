using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StageController : MonoBehaviour
{
    public static StageController instance;

    [SerializeField] GameObject[] enemies;

    [SerializeField] int enemyNum = 1;
    int maxEnemyNum = 10;
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
        ResetStage();
        for (int i = 0; i < enemyNum; i++)
        {
            int randomEnemy = Random.Range(0, enemies.Length);
            enemies[randomEnemy].SetActive(true);
        }       
    }
    public void AddEnemyNum()
    {
        if (enemyNum < maxEnemyNum)
            enemyNum++;
    }

    private void ResetStage()
    {
        for (int i = 0; i < enemies.Length; i++)
        {
            enemies[i].SetActive(false);
        }
    }
}
