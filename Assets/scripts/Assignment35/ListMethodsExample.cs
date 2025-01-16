using System.Collections.Generic;
using UnityEngine;

namespace Assignment35{

public class ListMethodsExample : MonoBehaviour
{

    List<int> numbers = new List<int> { 3, 1, 4, 1, 5, 9 };

    List<int> numbers2 = new List<int> { 3, 1, 4, 1, 5, 9, 2, 6};
  
    void Start()
    {
             // Assignment 35- Part 4

         /*
         numbers.Sort((x, y) => y.CompareTo(x));
         Debug.Log(string.Join(", ", numbers));*/


         // Assignment 35- Part 5

        /* List<int> filteredNumbersList = numbers2.FindAll(x => x % 2 == 0);
         Debug.Log(string.Join(", ", filteredNumbersList));*/

        

        
    }

   
}

}