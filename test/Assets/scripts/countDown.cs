using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;



public class NewBehaviourScript : MonoBehaviour
{
   float currentTime = 0;
   float startingTime = 45f;

   [SerializeField] Text txt;

   void Start(){
        currentTime = startingTime;

   }

    void Update(){
        if(currentTime > 0){
        currentTime -= 1* Time.deltaTime;
        }
        else{
            currentTime = 0;
        }
        //print(currentTime);
        txt.text = currentTime.ToString();
    }

}
