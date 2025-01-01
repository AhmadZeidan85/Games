using UnityEngine;

namespace Assignment29
{

public class TestUtiillties : MonoBehaviour
{
       void Start()
    {

          int summation = Utilities.Add(5,10,7,9,3);
        Debug.Log($"Sum of numbers is : {summation}");  

        string repeatedString = "Hello".RepeatString(3);
        Debug.Log($"Repeated String is : {repeatedString}"); 
        
    }

}  
}
