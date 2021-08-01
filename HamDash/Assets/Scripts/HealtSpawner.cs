using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealtSpawner : MonoBehaviour
{
    public GameObject heal;
    [SerializeField]float spawnheal = 20f;

    void Start()
    {
        StartCoroutine(SpawnHeal());
    }

    IEnumerator SpawnHeal()
    {
        while (gameObject)
        {
            yield return new WaitForSeconds(spawnheal);
            Healt();
        }
    }
    void Healt()
    {
        float x = Random.Range(-5f, 5f); ;
        float y = Random.Range(-4.5f, 3f);
        Vector2 pos = new Vector2(x, y);

        Instantiate(heal,pos,Quaternion.identity);
    }
}
