using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PanelOpen : MonoBehaviour
{
   public GameObject Panel;
   public AnsMan1 answer;

   public void OpenPanel(string letter)
   {	
		
		if(Panel != null)
		{
			bool isActive = Panel.activeSelf;
			Panel.SetActive(!isActive);

			answer.AddLetter(letter);
		}
   }
}
