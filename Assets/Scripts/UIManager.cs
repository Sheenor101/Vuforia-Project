//I followed Naoise's tutorial for this to set up the Game Manager

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

namespace GameManagers{

public class UIManager : MonoBehaviour

{

    public TMP_Text scoreText;
    public GameObject pauseMenu;
    
    public void UpdateScoreDisplay(int score)
    {
        scoreText.text = "Score: " + score;
    }

    public void TogglePauseMenu(bool isPaused)
    {
        pauseMenu.SetActive(!pauseMenu.activeSelf);
    }
}
}