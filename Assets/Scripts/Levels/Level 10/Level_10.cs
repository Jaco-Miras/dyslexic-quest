using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Level_10 : MonoBehaviour
{
    public LevelManager level;

    // Start is called before the first frame update
    void Start()
    {

        if (LevelManager.levelsUnlocked < 10)
        {
            GetComponent<Button>().interactable = false;
        }
        else
        {
            GetComponent<Button>().interactable = true;
        }


    }


}


