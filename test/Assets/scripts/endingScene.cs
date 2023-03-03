using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class endingScene : MonoBehaviour
{
    [SerializeField]
    public GameObject podium1;
    public GameObject podium2;
    public GameObject podium3;
    public GameObject podium4;

     RectTransform first, second, third, fourth;

    // Start is called before the first frame update
    void Start()
    {
         first = podium1.GetComponent<RectTransform>();
         second = podium2.GetComponent<RectTransform>();
         third = podium3.GetComponent<RectTransform>();
         fourth = podium4.GetComponent<RectTransform>();
    }


   
}
