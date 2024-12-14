using UnityEngine;

namespace assignment27{

public class Assignment27 : MonoBehaviour
{

    void Start()
    {
        int number1=5;
        int number2=10;

        Debug.Log($"number1 value before  CallByValueDemonstration method is {number1} ");
        CallByValueDemonstration(number1);
        Debug.Log($"number1 value after  CallByValueDemonstration method is {number1} ");

        Debug.Log($"number2 value before  CallByReferenceDemonstration method is {number2} ");
        CallByReferenceDemonstration(ref number2);
        Debug.Log($"number2 value after  CallByReferenceDemonstration method is {number2} ");


        int number3=0;
         Debug.Log($"number3 value before  CallByOut method is {number3} ");
         CallByOut(out number3);
          Debug.Log($"number3 value after  CallByOut method is {number3} "); 



        
    }

    
    void CallByValueDemonstration(int variable){

        variable+=10;

    }

    void CallByReferenceDemonstration(ref int variable){

        variable+=10;

    }

    void   CallByOut(out int variable){

        variable=30;

    }


}
}
