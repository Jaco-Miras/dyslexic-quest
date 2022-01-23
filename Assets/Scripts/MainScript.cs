using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainScript : MonoBehaviour
{
    public Timer timer;
    public NumberOfTries tries;
    //int level = 1;
    public LevelManager level;
    //public AnswerManager01 answer1;
    //public TimerStage3 time;
   // Play Game
   public void PlayGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    // Map
    public void Map()
    {
       //level.helloWorld();
       SceneManager.LoadScene("Map");

       if (LevelManager.levelsUnlocked > 10)
       {
            SceneManager.LoadScene("Close Gate");
       }
    }
    // Level 01
   // public void Level01()
    //{
     //   SceneManager.LoadScene("Level_01");
    //}

    // Level Unlocked

    public void GetMap(string map)
    {
        Debug.Log("Level Is " + LevelManager.levelsUnlocked);
        Timer.secondsLeft = 59;
        SceneManager.LoadScene("Level_"+map);
    }

    public void GetRetry()
    {
        Debug.Log("The Level is " + LevelManager.GetLevel());
        Timer.secondsLeft = 59;
        SceneManager.LoadScene("Level_0" + LevelManager.GetLevel());
        if (LevelManager.GetLevel() < 10)
        {
            SceneManager.LoadScene("Level_0" + LevelManager.GetLevel());
        }
        else
        {
            SceneManager.LoadScene("Level_" + LevelManager.GetLevel());
        }
    }


    // Proceed to Stars
    public void StarsThree(){
        Debug.Log("Time Left " + Timer.secondsLeft);
        SceneManager.LoadScene("3 Stars");
    }

    public void GetResult(){
        if (Timer.secondsLeft > 41)
        {
            LevelManager.levelsUnlocked++;
            SceneManager.LoadScene("3 Stars");
        }
        else if (Timer.secondsLeft > 21)
        {
            LevelManager.levelsUnlocked++;
            SceneManager.LoadScene("2 Stars");
        }
        else if (Timer.secondsLeft > 1)
        {
            LevelManager.levelsUnlocked++;
            SceneManager.LoadScene("1 Star");
        }
        else{
            SceneManager.LoadScene("Retry");
        }
    }

    // Codes for Stage 3
    /*public void Get01()
    {
        if(time.timeValue > 91)
        {
           AnswerManager01.Count++;
           SceneManager.LoadScene("3 Stars");
        }
    } */


    // Proceed to Stage 2
    public void StageTwo(){
        SceneManager.LoadScene("Close Gate");
    }

    // Proceed to Teaser
    public void MainTeaser(){
        SceneManager.LoadScene("Main Teaser");
    }

    // Back to Main Menu
    public void MainMenu(){
        SceneManager.LoadScene("Main Menu");
    }

    // Proceed to Storyline
    public void Storyline(){
        SceneManager.LoadScene("Story Line");
    }

    // Congrats
    public void Congrats()
    {
        LevelManager.levelsUnlocked++;
        SceneManager.LoadScene("Congrats");
    }

    // Congrats to Stage 2
    public void Congrats10(){
        SceneManager.LoadScene("Congrats 10");
    }

    // Back 
    public void Back()
    {
        // reload the current scene
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);

        // load the previous scene
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 1);
    }

    public void QuitGame()
    {
        Application.Quit();
    }
}


