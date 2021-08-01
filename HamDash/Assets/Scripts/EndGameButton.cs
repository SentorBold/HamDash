using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class EndGameButton : MonoBehaviour
{

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Z))
        {
            Game();
        }
        else if (Input.GetKeyDown(KeyCode.Space))
        {
            MenuButton();
        }
    }
    public void MenuButton()
    {
        SceneManager.LoadScene("StartMenu");
    }
   public void Game()
    {
        SceneManager.LoadScene("Game");
    }
}
