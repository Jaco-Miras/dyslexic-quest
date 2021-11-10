using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PanelOpen09 : MonoBehaviour
{
   public GameObject Panel;
   public AnswerManager09 answer;
   public Button myBTN;


   public void OpenPanel09(string letter)
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
