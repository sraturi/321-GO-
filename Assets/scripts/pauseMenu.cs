using UnityEngine;
using System.Collections;
using UnityStandardAssets.Vehicles;

public class pauseMenu : MonoBehaviour {
	public Transform canvas;

	void Awake(){
		Time.timeScale = 1;
		 AudioListener.volume=1;
	}

	// Update is called once per frame
	void Update () {
		
	}
	public void Pause()
	{
		if (canvas.gameObject.activeInHierarchy == false)
		{
			canvas.gameObject.SetActive(true);
			Time.timeScale = 0;
			Debug.Log (AudioListener.volume);
			AudioListener.volume = 1 - AudioListener.volume;
		}

	}
	public void unpause(){
		canvas.gameObject.SetActive (false);
		Time.timeScale = 1;
		AudioListener.volume = 1;
	}
}
