using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelManager : MonoBehaviour
{
        private static LevelManager instance;
        private static bool Paused;
        private static int currentLevel;
    
    // Start is called before the first frame update
    void Awake()
    {
        if (instance == null){
            instance = this;
            DontDestroyOnLoad(this.gameObject);
        }
        else{
            Destroy(gameObject);
            return;
        }
        currentLevel = 0;


    }
    public static void Pause(){
        if (LevelManager.Paused){
            Time.timeScale = 1;
            LevelManager.Paused = false;
        }
        else{
            Time.timeScale = 0;
            LevelManager.Paused = true;
        }
    }
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape)){
            Application.Quit();
        }
        if (Input.GetKeyDown(KeyCode.P)){
            LevelManager.Pause();
        }
        if (Input.GetKeyDown(KeyCode.R)){
            LevelManager.ResetLevel();
        }
    }
    public static void NextLevel(){
        currentLevel++;
        StartLevel(currentLevel);
    }
    public static void ResetLevel(){
        LevelChanger.ReloadLevel();
    }
    public static void StartLevel(int level){
        LevelChanger.FadeToLevel(level);
    }
}
