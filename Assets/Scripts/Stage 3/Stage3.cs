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
}
