using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class EndGameButton : MonoBehaviour
{
  public void MenuButton()
    {
        SceneManager.LoadScene("StartMenu");
    }
   public void Game()
    {
        SceneManager.LoadScene("Game");
    }
}
