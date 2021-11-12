using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using System.Collections;

public class ButtonEvents : MonoBehaviour
{

    public Button Button_1;


    void Start()
    {

        Button_1.GetComponent<Button>().onClick.AddListener(OnButton_1_Click);

    }

    public void OnButton_1_Click()
    {
        Debug.Log("button_1");
        SceneManager.LoadScene("MainScene");

    }
}