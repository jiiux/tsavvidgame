using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class levelController : MonoBehaviour
{
    // Start is called before the first frame update
    public bool matcha = false;

    [SerializeField]
    public GameObject matchaPanel;
    public GameObject sugarPanel;
    public GameObject flourPanel;
    public GameObject dangoPanel;

    void Start()
    {
        matchaPanel.SetActive(true);
    }

    void Update(){
        if(sugarPanel.activeSelf){
            matchaPanel.SetActive(false);
        }
        if(flourPanel.activeSelf){
            sugarPanel.SetActive(false);
        }
        if(dangoPanel.activeSelf){
            flourPanel.SetActive(false);
        }
    }
}
