using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI; 

public class LevelManager : MonoBehaviour
{
   public static int levelsUnlocked = 1;
    

    public static int GetLevel()
    {
        return levelsUnlocked;
    }
    public static void LevelUp()
    {
        Debug.Log("Level Up");
        levelsUnlocked++;
    }

    public void helloWorld()
    {
        Debug.Log("Hello");
    }

  
    }
    


