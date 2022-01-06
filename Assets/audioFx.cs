using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.Threading.Tasks;

public class audioFx : MonoBehaviour
{
  public AudioSource myFx;
  public AudioClip clickFx;
  
   public GameObject Panel;
   public AnswerManager answer;
   public Button myBTN;

  public void ClickSound(string letter)
  {
		myFx.PlayOneShot(clickFx);
		Debug.Log(letter);
		Task.Delay(600).Wait();
		if(answer.isCorrect(letter))
		{
		if(Panel != null)
		{
			bool isActive = Panel.activeSelf;
			Panel.SetActive(!isActive);
			answer.AddLetter(letter);
			myBTN.interactable = false;
		}
		}
  }
}
