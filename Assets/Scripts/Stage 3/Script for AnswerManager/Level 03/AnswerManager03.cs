using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI; 

public class AnswerManager03: MonoBehaviour
{
   public static string answer = "";
   public int AnswerLength;
   
    
    public void AddLetter(string letter)
    {
        answer = answer+letter;
        Debug.Log("Answer is " + answer);
 
        if(answer.Length == AnswerLength){
            SceneManager.LoadScene("03Level02");
            Debug.Log("Success");
        }
    }
 }
 
