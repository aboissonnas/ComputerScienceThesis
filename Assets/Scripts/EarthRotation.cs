using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EarthRotation : MonoBehaviour
{

	// Use this for initialization
	void Start ()
	{
		
	}
	
	// Update is called once per frame
	void Update ()
	{
		//one real-world second will be one hour in the simulation
		var degPerHour = 15;

		//rotate around the local Y-axis
		transform.Rotate(Vector3.up * degPerHour * Time.deltaTime);
	}
}
