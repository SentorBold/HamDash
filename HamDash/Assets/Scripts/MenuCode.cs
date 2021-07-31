using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class MenuCode : MonoBehaviour
{
 
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Z ))
        {
            SceneManager.LoadScene("LoadingScreen");
        }
        if (Input.GetKeyDown(KeyCode.Space))
        {
            SceneManager.LoadScene("LoadingScreen");
        }
    }
}
