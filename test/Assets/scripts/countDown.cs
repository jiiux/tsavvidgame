using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;



public class NewBehaviourScript : MonoBehaviour
{
   float currentTime = 0;
   float startingTime = 5.0f;

   [SerializeField] Text txt;

   void Start(){
        currentTime = startingTime;
        currentTime = 5.0f;

   }

    void Update(){
        if(currentTime > 0.0f){
        currentTime = currentTime - (1* Time.deltaTime);
        }
        else{
            currentTime = 0.0f;
        }
        //print(currentTime);
        txt.text = currentTime.ToString();
        txt.text = "test";
    }

}
