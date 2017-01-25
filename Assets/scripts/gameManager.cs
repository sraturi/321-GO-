using UnityEngine;
using System.Collections;
using UnityStandardAssets.Utility;
public class gameManager : MonoBehaviour {
	public bool isCountdownDone = false;
	public static bool countdown = false;
	public GameObject AI;
	public GameObject AI2;
	public GameObject player;
	public GameObject finish;
	public static int playerpoosition;
	int total_players = 3;
	public static int playerLap;
	public static int rivalLap;
	public static int rival2Lap;
	public static int finalPlayerPosition;
		// Use this for initialization
	void Start () {
		Time.timeScale = 1;
		playerpoosition = total_players;
		finalPlayerPosition = 3;
	}


	// Update is called once per frame
	void Update () {
		if (isCountdownDone) {
			countdown = true;
		}



		playerLap = player.GetComponent<Laps> ().Lap;
		rivalLap = AI.GetComponent<LapForRival> ().Lap;
		rival2Lap = AI2.GetComponent<LapForRival> ().Lap;
		if (playerLap> 1 ||( rivalLap>1 &&rival2Lap >1&&playerLap>1)) {
			//GetComponent<pauseMenu> ().Pause ();
			if (finish.gameObject.activeInHierarchy == false )
			{
				finish.gameObject.SetActive(true);
			}
				}

	
	}

}
