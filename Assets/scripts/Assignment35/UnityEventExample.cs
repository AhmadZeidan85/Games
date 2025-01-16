using UnityEngine;
using UnityEngine.Events;

namespace Assignment35{

public class UnityEventExample : MonoBehaviour


{

    UnityEvent onEventTriggered;
 
    void Start()
    {
        onEventTriggered = new UnityEvent();
        onEventTriggered.AddListener(OnEventResponse);
        
    }

    // Update is called once per frame
    void Update()
    {

         if (Input.GetKeyUp(KeyCode.Space))
            {
                onEventTriggered?.Invoke();
            }
        
    }

    void OnEventResponse(){
        Debug.Log("The event has been triggered!");
    }
}
}
