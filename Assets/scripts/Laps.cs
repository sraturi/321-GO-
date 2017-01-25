using UnityEngine;
using System.Collections;

public class Laps : MonoBehaviour {

	// These Static Variables are accessed in "checkpoint" Script
	public Transform[] checkPointArray;
	public static Transform[] checkpointA;
	public static int currentCheckpoint = 0; 
	public static int currentLap = 0; 
	public Vector3 startPos;
	public int Lap;
	public static float timer;
	public static float timePerLap;
	public float timercopy = 0;
	void  Start ()
	{
		startPos = transform.position;
		currentCheckpoint = 0;
		currentLap = 0; 
		timer = 0.0f;
		timePerLap = 0;

	}

	void  Update ()
	{
		timer += Time.deltaTime;
		Lap = currentLap;
		checkpointA = checkPointArray;
		timercopy += timer;
	}


}