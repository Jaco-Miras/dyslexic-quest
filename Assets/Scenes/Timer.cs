using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Timer : MonoBehaviour
{
	public GameObject textDisplay;
	public static int secondsLeft = 59;
	public bool takingAway = false;

	void Start(){
		textDisplay.GetComponent<Text>().text = "00:" + secondsLeft;
	}

	void Update(){
		Debug.Log(secondsLeft);
		if (takingAway == false && secondsLeft > 0)
		{
			StartCoroutine(TimerTake());
		} 
		else if (secondsLeft == 0) {
			SceneManager.LoadScene("Retry");
		}
	}

	IEnumerator TimerTake()
	{
		takingAway = true;
		yield return new WaitForSeconds(1);
		secondsLeft -= 1;
		if (secondsLeft < 10)
		{
			textDisplay.GetComponent<Text>().text = "00:0" + secondsLeft;
		}
		else
		{
			textDisplay.GetComponent<Text>().text = "00:" + secondsLeft;
		}
		takingAway = false;
	}

}
