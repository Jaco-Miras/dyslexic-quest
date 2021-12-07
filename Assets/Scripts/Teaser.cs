using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Teaser : MonoBehaviour
{
	// Stage 1
	// Go to Teaser
	public void Teaser1()
	{
		SceneManager.LoadScene("Teaser");
	}
	
   // Go to Teaser 2
   public void Teaser2()
   {
		  SceneManager.LoadScene("Teaser 2");
   }
   //Go to Teaser 3
   public void Teaser3()
   {
		  SceneManager.LoadScene("Teaser 3");
   }
   // Go to Teaser 4
   public void Teaser4()
   {
		  SceneManager.LoadScene("Teaser 4");
   }
    // Go to Teaser 5
   public void Teaser5()
   {
		  SceneManager.LoadScene("Teaser 5");
   }

   // Stage 2
   // Main Teaser
   public void Mainteaser()
   {
		SceneManager.LoadScene("02_Main Teaser");
   }
   // 02_Teaser 01
   public void Teaser021()
   {
		SceneManager.LoadScene("02_Teaser 01");
   }

   // Stage 3
   // Main Teaser
   public void MainTeaser03()
   {
		SceneManager.LoadScene("03_Main Teaser");
   }
   // Teaser 1
   public void Teaser031()
   {
		SceneManager.LoadScene("03_Teaser 01");
   }
    public void Teaser032()
   {
		SceneManager.LoadScene("03_Teaser 02");
   }
	public void Teaser033()
   {
		SceneManager.LoadScene("03_Teaser 03");
   }	


}
