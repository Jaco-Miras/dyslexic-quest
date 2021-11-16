using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EndingNavigation : MonoBehaviour
{
	// GotoEndingScene2	
	 public void GotoEndingScene2()
	 {
		  SceneManager.LoadScene("EndingScene 2");
	 }

	 // Go to Post Ending
	 public void PostEnding(){
		  SceneManager.LoadScene("PostEnding");
	 } 
}
