using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuManager : MonoBehaviour
{
   [SerializeField]
   private string gameSceneName = "Game Scene";
   [SerializeField]
   private string optionSceneName = "Options Scene";


public void StartGame()
{
  SceneManager.LoadScene(gameSceneName);
}

public void OpenOptions()
{
    SceneManager.LoadScene(optionSceneName);
}

public void QuitGame()
{
    Application.Quit();
}
}
