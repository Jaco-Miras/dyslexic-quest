using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Level04Lock : MonoBehaviour
{


    // Start is called before the first frame update
    void Start()
    {
        if (LevelManager.levelsUnlocked >= 4)
        {
            GetComponent<Image>().enabled = false;
        }
    }
}