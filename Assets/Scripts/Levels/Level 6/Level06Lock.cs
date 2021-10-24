using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Level06Lock : MonoBehaviour
{


    // Start is called before the first frame update
    void Start()
    {
        if (LevelManager.levelsUnlocked >= 6)
        {
            GetComponent<Image>().enabled = false;
        }
    }
}