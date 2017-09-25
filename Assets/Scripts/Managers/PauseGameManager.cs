using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PauseGameManager : MonoBehaviour {

	public GameObject PauseScreen;
	public Text PausePromptText;

	private bool PauseStatus;
	// Use this for initialization
	void Start () {
		PauseStatus = false;
		PausePromptText.text = "ESC to pause";
	}
	
	// Update is called once per frame
	void Update()
	{
		if (Input.GetKeyDown(KeyCode.Escape))
		{
			PauseStatus =! PauseStatus;
			if(PauseStatus == true)
			{
				PauseScreen.SetActive (true);
				PausePromptText.text = "ESC  to  resume";
				Pause();
			}
			else
			{
				PauseScreen.SetActive (false);
				PausePromptText.text = "ESC  to  pause";
				Pause();
			}
		}
	}
	public void Pause()
	{
		Time.timeScale = Time.timeScale == 0 ? 1 : 0;
	}
}
