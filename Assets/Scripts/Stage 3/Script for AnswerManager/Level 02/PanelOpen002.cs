using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PanelOpen002 : MonoBehaviour
{
   public GameObject Panel;
   public AnswerManager02 answer;
   public Button myBTN;


   public void OpenPanel02(string letter)
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
