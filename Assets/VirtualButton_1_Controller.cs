using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;
using UnityEngine.SceneManagement;


public class VirtualButton_1_Controller : MonoBehaviour
{
    public GameObject cube;

    public VirtualButtonBehaviour Vb_1;

    public VirtualButtonBehaviour Vb_2;

    public VirtualButtonBehaviour Vb_3;
    // Start is called before the first frame update
    void Start()
    {
         Debug.Log("button_1");

        Vb_1.RegisterOnButtonPressed(OnButton_1_Pressed);
        Vb_1.RegisterOnButtonReleased(OnButton_1_Released);

        Vb_2.RegisterOnButtonPressed(OnButton_2_Pressed);
        Vb_2.RegisterOnButtonReleased(OnButton_2_Released);

        Vb_3.RegisterOnButtonPressed(OnButton_3_Pressed);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnButton_1_Pressed(VirtualButtonBehaviour Vb)
    {
        Debug.Log("button_1");
      //  SceneManager.LoadScene("MenDancerScene");

        cube.GetComponent<Material>().color = Color.blue;
    }

    public void OnButton_2_Pressed(VirtualButtonBehaviour Vb)
    {
        Debug.Log("button_2");
       // SceneManager.LoadScene("MenDancersScene");


        cube.GetComponent<Material>().color = Color.yellow;
    }

    public void OnButton_3_Pressed(VirtualButtonBehaviour Vb)
    {
        Debug.Log("button_3");
       // SceneManager.LoadScene("WomenDancersScene");

        cube.SetActive(false);
    }

    public void OnButton_1_Released(VirtualButtonBehaviour Vb)
    {
        Debug.Log("button_1");
        // SceneManager.LoadScene("WomenDancersScene");

        cube.GetComponent<Material>().color = Color.red;
    }

    public void OnButton_2_Released(VirtualButtonBehaviour Vb)
    {
        Debug.Log("button_1");
        // SceneManager.LoadScene("WomenDancersScene");

        cube.GetComponent<Material>().color = Color.black;
    }
}
