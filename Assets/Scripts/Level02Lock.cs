using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Level02Lock : MonoBehaviour
{


    // Start is called before the first frame update
    void Start()
    {
        if (LevelManager.levelsUnlocked >= 2)
        {
            GetComponent<Image>().enabled = false;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
