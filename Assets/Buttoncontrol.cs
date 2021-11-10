using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Buttoncontrol : MonoBehaviour
{
    public GameObject cube;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnButton_Pressed()
    {
        Debug.Log("button_1");
          SceneManager.LoadScene("MenDancersScene");

      //  cube.GetComponent<Material>().color = Color.blue;
    }
}
