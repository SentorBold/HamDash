using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class Health : MonoBehaviour
{
    [SerializeField] int health;
    [SerializeField] TextMeshProUGUI healthtext;

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
            FindObjectOfType<ScoreHolder>().SetScore();
            Destroy(gameObject);
            SceneManager.LoadScene("EndGame");
        }
    }

    void SetHealthText()
    {
        healthtext.text = health.ToString();
    }
   public void GainHealt()
    {
        health++;
        SetHealthText();
    }

}
