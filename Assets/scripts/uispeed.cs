using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class uispeed : MonoBehaviour {
	Text speed;
	//private Laps player;
	// Use this for initialization
	void Start () {
		speed = GetComponent<Text>();
	}
	
	// Update is called once per frame
	void Update () {
		
			if (positiontracker.playerCount >= positiontracker.AICount && positiontracker.playerCount >= positiontracker.AI2Count) {
				gameManager.playerpoosition = 1;

			} 
			if (positiontracker.playerCount < positiontracker.AICount && positiontracker.playerCount >= positiontracker.AI2Count) {
				gameManager.playerpoosition = 2;

			}

			if (positiontracker.playerCount >= positiontracker.AICount && positiontracker.playerCount < positiontracker.AI2Count) {
				gameManager.playerpoosition = 2;

			}

			if (positiontracker.playerCount < positiontracker.AICount && positiontracker.playerCount < positiontracker.AI2Count) {
				gameManager.playerpoosition = 3;

			}

		speed.text= "Time: "+Laps.timer.ToString("f1")+"\n" + "Checkpoint: " + Laps.currentCheckpoint + "\n" +
			"Speed: "+ speedForCar.speedInKPH.ToString("f1") + " KMPH" + "\n"+ "Position: "+gameManager.playerpoosition;
	}
}
