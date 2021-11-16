using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Stage2 : MonoBehaviour
{
	// Go to Open Gate
	public void OpenGate(){
		SceneManager.LoadScene("Open Gate");
	}
	// Go to Hallway
	public void Hallway(){
		SceneManager.LoadScene("Hallway");
	}
	// Go to HallwayZoomIn
	public void HallwayZoomIn(){
		SceneManager.LoadScene("Hallway(ZoomIn)");
	}
	// Go to Lobby
	public void Lobby(){
		SceneManager.LoadScene("Ending Scene 2");
	}

}
