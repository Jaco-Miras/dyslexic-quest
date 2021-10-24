using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainScript : MonoBehaviour
{
    //int level = 1;
     //public LevelManager level;

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

        SceneManager.LoadScene("Level_"+map);
    }


    




    // Congrats
    public void Congrats()
    {
        LevelManager.levelsUnlocked++;
        SceneManager.LoadScene("Congrats");
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


