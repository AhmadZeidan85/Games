using UnityEngine;
using System;
namespace Assignment29
{

public class ExceptiionHandling : MonoBehaviour
{
    
    void Start()
    {

        int playerScore = 100;
      int diviser = 0;
   
try{

    Debug.Log("Attempting to calculate score multiplier...");

    int totalScore = playerScore / diviser;
    

}
 catch (DivideByZeroException e)
            {
            Debug.LogError("Error: Division by zero occurred while calculating score multiplier.");
        
            }

            finally
            {
                Debug.Log("Score calculation complete. Cleaning up resources.");
            }


        
    }

   
}
}