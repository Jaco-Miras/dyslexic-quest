using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Level_09 : MonoBehaviour
{
    public LevelManager level;

    // Start is called before the first frame update
    void Start()
    {

        if (LevelManager.levelsUnlocked == 9)
        {
            GetComponent<Button>().interactable = true;
        }
        else
        {
            GetComponent<Button>().interactable = false;
        }


    }


}


