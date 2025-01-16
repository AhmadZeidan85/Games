using UnityEngine;

namespace Assignment35{

public class BoxingUnboxing : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

        int health = 100;
         Debug.Log($"Orginal Value : {health}");
        object health_Boxing = health;
        Debug.Log($"Boxing Value : {health_Boxing}");
        int health_unBoxing = (int)health_Boxing;
        health_unBoxing=90;
        Debug.Log($"UnBoxing and Update Value : {health_unBoxing}");



        
    }

   
}
}
