using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using System.Collections;

public class Buttoncontrol : MonoBehaviour
{
	public Button Button_1;
	public Button Button_2;
	public Button Button_3;

	void Start()
	{
		
		Button_1.GetComponent<Button>().onClick.AddListener(OnButton_1_Click);

		Button_2.GetComponent<Button>().onClick.AddListener(OnButton_2_Click);

		Button_3.GetComponent<Button>().onClick.AddListener(OnButton_3_Click);
	}

	void TaskOnClick()
	{
		Debug.Log("You have clicked the button!");
	}

	public void OnButton_1_Click()
    {
        Debug.Log("button_1");
        SceneManager.LoadScene("MenDancersScene");

    }

	public void OnButton_2_Click()
	{
		Debug.Log("button_1");
		SceneManager.LoadScene("WomenDancersScene");

	}

	public void OnButton_3_Click()
	{
		Debug.Log("button_1");
		SceneManager.LoadScene("MenandWomenDancerScene");

	}
}
