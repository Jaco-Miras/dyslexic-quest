using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class AfterCorrect02 : MonoBehaviour
{

    public LevelManager level;

    // Start is called before the first frame update
    void Start()
    {
    
         if (LevelManager.levelsUnlocked == 2)
         {
            GetComponent<Button>().interactable = false;
        }
        else
        {
            GetComponent<Button>().interactable = true;
        }


    }

    
}
