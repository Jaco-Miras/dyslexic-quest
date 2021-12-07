using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI; 

public class AnswerManager01: MonoBehaviour
{
   public static string answer = "";
   public string CorrectAnswer;
   public int Count = 0;
   public int AnswerLength;
   public TimerStage3 time;
   
    
    public void AddLetter(string letter)
    {
        Count++;
        
        answer = answer+letter;
        Debug.Log("Answer is " + answer);
 
        if(answer.Length == AnswerLength && TimerStage3.timeValue > 91){
            SceneManager.LoadScene("3 Stars");
            Debug.Log("Success");
        }
        else if(answer.Length == AnswerLength && TimerStage3.timeValue > 46){
            SceneManager.LoadScene("2 Stars");
            Debug.Log("Success");
        }
        else if(answer.Length == AnswerLength && TimerStage3.timeValue > 1){
            SceneManager.LoadScene("1 Star");
            Debug.Log("Success");
        }
    }

    public bool isCorrect(string letter)
    {
       Debug.Log("Received " + letter);
       //Debug.Log(letter.GetType());
       //Debug.Log("Is Correct " + CorrectAnswer[Count].ToString().Equals(letter));
       return CorrectAnswer[Count].ToString().Equals(letter);

    }
    
   


  
    }