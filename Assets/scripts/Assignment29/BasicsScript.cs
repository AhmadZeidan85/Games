using System;
using UnityEngine;

namespace Assignment29
{
    

public class BasicsScript : MonoBehaviour
{
   
    void Start()
    {
        var number =5;
        var text="The Number ";
        var isEven = (number % 2 == 0);
        var result = isEven ? "even" : "odd";

        Debug.Log($"{text} {number}  is {result}");

         Debug.Log($"Current date : {DateTime.Now.ToString("dd-MM-yyyy")}");
         Debug.Log($"Current time : {DateTime.Now.ToString("HH:mm:ss")}");
          Debug.Log($"Current day : {DateTime.Now.DayOfWeek}");


        

    }


}
}
