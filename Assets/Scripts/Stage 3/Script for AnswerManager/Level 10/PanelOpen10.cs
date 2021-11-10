using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PanelOpen10 : MonoBehaviour
{
   public GameObject Panel;
   public AnswerManager10 answer;
   public Button myBTN;


   public void OpenPanel10(string letter)
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
