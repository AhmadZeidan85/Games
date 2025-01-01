using System.Collections.Generic;
using UnityEngine;

namespace Assignment29
{

public class TypeManagementScript : MonoBehaviour
{
   
    void Start()
    {
      
        Animal animal=new Cat();
        animal.MakeSound();
        animal.Move();

        (animal as Cat)?.MakeSound(); 
        (animal as Cat)?.Move(); 

    

        List<ICanFight> fights = new List<ICanFight>
        {
            new Cat(),
            new Warrior()
        };

        foreach (ICanFight fighter in fights)
        {
           
           
            fighter.Attack();
        
        }

        foreach (ICanFight fighter in fights)
        {
           
            if (fighter is Cat)
            {
                Debug.Log("The object is a Cat.");
               
            }
            else if (fighter is Warrior)
            {
                Debug.Log("The object is a Warrior.");
                
            }
        }
        
    }

   
}







}