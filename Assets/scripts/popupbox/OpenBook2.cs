using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenBook2 : MonoBehaviour
{
    // Start is called before the first frame update
    public Transform bookFaceUpper;
    public Transform bookFaceBase;

   public Transform gift;


    float bookOpenSpeed = 30f;

    float value = 0f;

    float openAngle = 90; 
    float closeAngle=0;

    bool openBook=true;
    bool closeBook=true;

    Vector3 scaleFactor = new Vector3(0.0f, 0.01f, 0.0f);

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        openBookAction();
        closeBookAction();
        
    }



      void openBookAction()
    {
        
        Quaternion targetRotation = Quaternion.Euler(openAngle,0, 0 );

        if (Input.GetKey(KeyCode.O))
        {
            if(openBook==true){

            bookFaceUpper.Rotate(new Vector3(Time.deltaTime * bookOpenSpeed, 0,0 ), Space.Self);
           // bookFaceRight.Rotate(new Vector3(Time.deltaTime * bookOpenSpeed,0 ,0), Space.Self);
          gift.transform.localScale += scaleFactor;

            float angle1 = Quaternion.Angle(bookFaceUpper.rotation, targetRotation);

            Debug.Log("angle1 "+  angle1);
            
            if(angle1<0.1f){

                Debug.Log("reach traget analge");
                openBook=false;
                closeBook=true;
            }

           



            }

              
        }
        
    }

     void closeBookAction()
    {
        
        Quaternion targetRotation = Quaternion.Euler(closeAngle,0,0 );

        if (Input.GetKey(KeyCode.C))
        {
            if(closeBook==true){

          bookFaceUpper.Rotate(new Vector3(-Time.deltaTime * bookOpenSpeed,0 ,0), Space.Self);
          //bookFaceRight.Rotate(new Vector3(-Time.deltaTime * bookOpenSpeed,0 ,0), Space.Self);
          gift.transform.localScale -= scaleFactor;

            float angle1 = Quaternion.Angle(bookFaceUpper.rotation, targetRotation);

            Debug.Log("angle1 "+  angle1);
            
            if(angle1<0.1f){

                Debug.Log("reach traget analge");
                closeBook=false;
                openBook=true;
                
            }

           



            }

              
        }
        
    }
}
