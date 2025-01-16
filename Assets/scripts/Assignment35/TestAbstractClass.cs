using UnityEngine;

namespace Assignment35{

public class TestAbstractClass : MonoBehaviour


{

     AbstractBaseClass abstractBaseClass;
    
    void Start()
    {

        abstractBaseClass= new DerivedClassExample();

        abstractBaseClass.PerformAction();
        abstractBaseClass.PrintInfo();




        
    }

  

}
}