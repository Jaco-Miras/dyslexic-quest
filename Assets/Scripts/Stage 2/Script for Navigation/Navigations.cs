using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Navigations : MonoBehaviour
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
	// Go to 2-14(Classroom)
	public void TwoClassroom(){
		SceneManager.LoadScene("2-14(Classroom)");
	}
	// Go to 2-14(ZoomIn)
	public void TwoZoomIn(){
		SceneManager.LoadScene("2-14(ZoomIn)");
	}
	// Go to Canteen
	public void Canteen(){
		SceneManager.LoadScene("Canteen");
	}
	// Go to Canteen(ZoomIn)
	public void CanteenZoomIn(){
		SceneManager.LoadScene("Canteen(ZoomIn)");
	}
	// Go to HW (Stairs)
	public void HallWayStairs(){
		SceneManager.LoadScene("HW (Stairs)");
	}
	// Go to HallWayStairs(ZoomIn)
	public void HallWayStairsZoomIn(){
		SceneManager.LoadScene("HW Stairs(ZoomIn)");
	}
	// Go to Left Stairs
	public void LeftStairs(){
		SceneManager.LoadScene("Left Stairs");
	}
	// Go to Right Stairs
	public void RightStairs(){
		SceneManager.LoadScene("Right Stairs");
	}
	// Go to OSA(HW)
	public void OSAHallway(){
		SceneManager.LoadScene("OSA(HW)");
	}
	// Go to OSA(ZoomOut)
	public void OSAZoomOut(){
		SceneManager.LoadScene("OSA(ZoomOut)");
	}
	// Go to Stairs(ZoomIn)
	public void StairsZoomIn(){
		SceneManager.LoadScene("Stairs(Zoom In)");
	}
	// Go to Corridors 1
	public void CorridorOne(){
		SceneManager.LoadScene("Corridors 1");
	}
	// Go to Corridors1(ZoomIn)
	public void CorridorOneZoomIn(){
		SceneManager.LoadScene("Corridors1(ZoomIn)");
	}
	// Go to Corridors 2
	public void CorridorsTwo(){
		SceneManager.LoadScene("Corridors 2");
	}
	// Go to Corridors2(ZoomIn)
	public void CorridorsTwoZoomIn(){
		SceneManager.LoadScene("Corridors2(ZoomIn)");
	}

}
