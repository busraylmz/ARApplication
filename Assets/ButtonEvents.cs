using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;

public class ButtonEvents : MonoBehaviour
{

    public GameObject virtualBtnObj;
    public Animator objAnim;
    public VirtualButtonBehaviour vbb;

    // Start is called before the first frame update
    void Start()
    {
        virtualBtnObj = GameObject.Find("");
        vbb = GetComponentInChildren<VirtualButtonBehaviour>();

       // virtualBtnObj.GetComponent<VirtualButtonBehaviour>().RegisterEventHandler(this);


    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
