using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusicManager : MonoBehaviour
{
    static MusicManager instance = null;
    void Awake () {
      if (instance != null)
         Destroy (gameObject);
      else {
         instance = this;
         GameObject.DontDestroyOnLoad(gameObject);
      }
   }
   

}
