using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Ending : MonoBehaviour
{
   // Go to Hallway(ZoomIn)
   public void HallwayZoomIn(){
		SceneManager.LoadScene("Ending Scene1");
   }

   // Go to Lobby
	public void Lobby(){
		SceneManager.LoadScene("Ending Scene 2");
	}
}
