using Unity.VisualScripting;
using UnityEngine;
namespace Assignment29
{

public class UnitySpecificScript : MonoBehaviour
{

    GameObject TargetObject;
     GameObject JokerObject;

     Light LightObject;
   
    
    void OnEnable(){

       print("GameObject Enabled");

    }
    void Start()
    {
        print("Game started!");

         TargetObject=GameObject.Find("TargetObject");

        if(TargetObject !=null){
          print("Found object by name: "+TargetObject.name);
        }
        else{
          print("No TargetObject found.");  
        }

        GameObject JokerObject=GameObject.FindGameObjectWithTag("Joker");
         if(JokerObject !=null){
          print("Found object by tag: "+JokerObject.name);
        }
        else{
          print("No Joker object found.");  
        }

         LightObject=GameObject.FindObjectOfType<Light>();

         if(LightObject !=null){
          print("Found object of type Light: "+LightObject.name);
        }
        else{
          print("No Light object found.");  
        }

        
    }

    void Update(){

         if (Input.GetKeyDown(KeyCode.D))
        {
            if (TargetObject != null)
            {
                TargetObject.SetActive(false);
                print("TargetObject deactivated!");
            }
        }



    }

  
    

    void OnDisable(){
        print("GameObject Disabled");

    }
}
}
