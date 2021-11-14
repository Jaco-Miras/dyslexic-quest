using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Stage3 : MonoBehaviour
{
   // Go to Classroom(ZoomIn)
   public void ClassroomZoomIn()
   {
		SceneManager.LoadScene("Classroom(ZoomIn)");
   }
   // Go to Blackboard
   public void Blackboard()
   {
		SceneManager.LoadScene("Blackboard");
   }

	// Go Back to the Hallway
	public void GoBack()
	{
		SceneManager.LoadScene("2-14(ZoomIn)");
	}

   // Go to the Game
   public void Game()
   {
		  SceneManager.LoadScene("03Level01");
   }

}
