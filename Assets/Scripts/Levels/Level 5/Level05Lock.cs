using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Level05Lock : MonoBehaviour
{


    // Start is called before the first frame update
    void Start()
    {
        if (LevelManager.levelsUnlocked >= 5)
        {
            GetComponent<Image>().enabled = false;
        }
    }
}