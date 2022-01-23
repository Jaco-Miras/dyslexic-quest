using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class NumberOfTries : MonoBehaviour
{
    public static int attemptsValue = 0;
    Text attempts;


   void Start(){
          attempts = GetComponent<Text>();
   }
   void Update(){
          attempts.text = "Attempts: " + attemptsValue;
   }
   }
