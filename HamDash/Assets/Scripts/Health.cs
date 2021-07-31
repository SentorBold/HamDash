using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Health : MonoBehaviour
{
    [SerializeField] int health;
    [SerializeField] Text healthtext;

    private void Start()
    {
        SetHealthText();
    }
    public void DoDamage()
    {
        health--;
        SetHealthText();
        if (health <= 0)
        {
            Destroy(gameObject);
        }
    }

    void SetHealthText()
    {
        healthtext.text = health.ToString();
    }
}
