//I followed Naoise's lecture 6 on this script for the game manager

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace GameManagers{

    public class GameManager : MonoBehaviour
    {
        public static GameManager Instance;
        public int score;
        [SerializeField] private UIManager uiManager;
        
        private bool isPaused = false;


        // Start is called before the first frame update
        void Awake()
        {
            if(Instance == null){
                Instance = this;
                DontDestroyOnLoad(gameObject);
        }
            else{
                Destroy(gameObject);
                return;
            }
        }
        
        private void Start(){
            ResetScore();
        }
        // Update is called once per frame
        void Update()
        {
            Debug.Log("GameManager Update");
            if(Input.GetKeyDown(KeyCode.Space)){
                AddScore(1);
            }
            if(Input.GetKeyDown(KeyCode.P)){
                TogglePause();
        }
            if(Input.GetKeyDown(KeyCode.Escape)){
                QuitGame();
            }
        }
    
        public void AddScore(int points){
            score += points;
            uiManager.UpdateScoreDisplay(score);
            AudioManager.Instance.PlaySoundEffect("Score");

        }
        public void ResetScore(){
            score = 0;
            uiManager.UpdateScoreDisplay(score);
        }

        public void QuitGame(){
            Application.Quit();
        }

        public void TogglePause(){
            isPaused = !isPaused;
            if(isPaused){
                Time.timeScale = 0;
                AudioManager.Instance.PlaySoundEffect("Pause");
            }
            else{
                Time.timeScale = 1;
                AudioManager.Instance.PlaySoundEffect("Unpause");
            }
            uiManager.TogglePauseMenu(isPaused);
        }
}
}

