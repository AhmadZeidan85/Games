using UnityEngine;

namespace Assignment29
{


public class TestCustomObject : MonoBehaviour
{
  
    void Start()
    {

        CustomObject  customObject1= new CustomObject("customObject1",949599492);
        print(customObject1);

        CustomObject  customObject2= new CustomObject("customObject1",949599492);
      

        print(customObject1 == customObject2);
        print(customObject1 != customObject2);

        
        
    }

    
}
}
