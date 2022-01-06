using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI; 
using System.Threading.Tasks;

public class AnswerManager: MonoBehaviour
{
   public static string answer = "";
   public string CorrectAnswer;
   public int Count = 0;
   public int AnswerLength;
   public TimerStage3 time;
   public static int levelsUnlocked = 1;
   public static float delay = 3;
   public int sleepTime = 3000;

    public void AddLetter(string letter)
    {
        Count++;
        
        answer = answer+letter;
        Debug.Log("Answer is " + answer);
         if(answer.Length == AnswerLength && TimerStage3.timeValue > 91){
            AnswerManager.levelsUnlocked++;
            SceneManager.LoadScene("03_3Stars");
            Debug.Log("Success");
        }
        else if(answer.Length == AnswerLength && TimerStage3.timeValue > 46){
            AnswerManager.levelsUnlocked++;
            SceneManager.LoadScene("03_2Stars");
            Debug.Log("Success");
        }
        else if(answer.Length == AnswerLength && TimerStage3.timeValue > 1){
            AnswerManager.levelsUnlocked++;
            SceneManager.LoadScene("03_1Star");
            Debug.Log("Success");
        }
      
    }

    void Start()
    {
            
    }

    void Update()
    {
        
    }

    IEnumerator TimeDelay(float delay)
    {
        yield return new WaitForSeconds(delay);      
    }

    public static int GetLevel(){
        return levelsUnlocked;
    }

   

    public bool isCorrect(string letter)
    {
       Debug.Log("Received " + letter);
       //Debug.Log(letter.GetType());
       //Debug.Log("Is Correct " + CorrectAnswer[Count].ToString().Equals(letter));
       return CorrectAnswer[Count].ToString().Equals(letter);

    }
    



  
    }