using UnityEngine;
using System.Collections;

public class checkpointForRival : MonoBehaviour {

	void  Start ()
	{

	}

	void  OnTriggerEnter ( Collider other  )
	{
		//Is it the Player who enters the collider?
		if (other.tag != "rival") 
			return; //If it's not the player dont continue


		else if (transform == LapForRival.checkpointA[LapForRival.currentCheckpoint].transform) 
		{
			//Check so we dont exceed our checkpoint quantity
			if (LapForRival.currentCheckpoint + 1 < LapForRival.checkpointA.Length) 
			{
				//Add to currentLap if currentCheckpoint is 0
				if (LapForRival.currentCheckpoint == 0) {
					LapForRival.currentLap++;
					LapForRival.timePerLap = LapForRival.timer;
					LapForRival.timer = 0;
				}
				LapForRival.currentCheckpoint++;

			} 
			else 
			{
				//If we dont have any Checkpoints left, go back to 0
				LapForRival.currentCheckpoint = 0;
			}
		}


	}

}
