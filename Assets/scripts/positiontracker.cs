using UnityEngine;
using System.Collections;

public class positiontracker : MonoBehaviour {
	public static int playerCount;
	public static int AICount;
	public static int AI2Count;
	bool playerpassed;
	bool AIpassed;
	bool AI2Passed;
	// Use this for initialization
	void Start () {
		playerCount = 0;
		AICount = 0;
		playerpassed = false;
		AIpassed = false;
		AI2Passed = false;
	}

	 void OnTriggerEnter(Collider other){
		if (other.tag == "Player"&& !playerpassed ) {
			playerCount++;
			playerpassed = true;
		}
		if (other.tag == "rival"&&!AIpassed) {
			AICount++;
			AIpassed = true;
		}
		if (other.tag == "rival2" && !AI2Passed) {
			AI2Count++;
			AI2Passed = true;
		}

	}

}
