using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StarsRetry : MonoBehaviour
{

	public AnswerManager answer;
	public TimerStage3 time;

	public void Retry()
	{
		Debug.Log("The Level is " + AnswerManager.GetLevel());
		TimerStage3.timeValue = 119;
		SceneManager.LoadScene("03Level0" + AnswerManager.GetLevel());
		if (AnswerManager.GetLevel() < 10)
		{
			SceneManager.LoadScene("03Level0" + AnswerManager.GetLevel());
		}
		else
		{
			SceneManager.LoadScene("03Level" + AnswerManager.GetLevel());
		}
	}

   public void NextLevel()
   {
		  Debug.Log("The Level Now is " + AnswerManager.GetLevel());	
		  TimerStage3.timeValue = 5;
		  if (AnswerManager.GetLevel() < 10)
		  {
			SceneManager.LoadScene("03Level0" + AnswerManager.levelsUnlocked);
		  }
		  else if(AnswerManager.GetLevel() == 10)
		  {
			SceneManager.LoadScene("03Level" + AnswerManager.levelsUnlocked);
		  }
		  else if(AnswerManager.GetLevel() > 10)
		  {
			SceneManager.LoadScene("Ending Scene1");
		  }

		 
   }

}
