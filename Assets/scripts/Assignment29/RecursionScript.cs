using UnityEngine;
namespace Assignment29
{

public class RecursionScript : MonoBehaviour
{
  
    void Start()
    {
        Debug.Log ($"FibonacciRecursive for 10 is: {FibonacciRecursive(10)} ");
        Debug.Log ($"FibonacciRecursive for 30 is: {FibonacciRecursive(30)} ");

        Debug.Log ($"FibonacciIterative for 10 is: {FibonacciIterative(10)} ");
        Debug.Log ($"FibonacciIterative for 30 is: {FibonacciIterative(30)} ");
        
    }

    public int FibonacciRecursive(int n){

        if (n < 0) return -1;

          
            if (n == 0) return 0;
            if (n == 1) return 1;

            return FibonacciRecursive(n - 1) + FibonacciRecursive(n - 2);

    }

    public int FibonacciIterative(int n){

        int result=0;
        int previousElement1 =0;
        int previousElement2=1;
        if (n < 0) return -1;
        if (n == 0) return 0;
        if (n == 1) return 1;
        for (int i=2;i<=n;i++){

        result=previousElement1+previousElement2;
        previousElement1=previousElement2;
        previousElement2=result;




        }





        return result;



    }

   


}
}
