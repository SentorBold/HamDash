using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Loading : MonoBehaviour
{
    [SerializeField] float loadingTime;
    void Start()
    {
        Invoke("Game", loadingTime);
    }

   void Game ()
    {
        SceneManager.LoadScene("Game");
    }
}
