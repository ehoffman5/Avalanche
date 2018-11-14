using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AccelerometerInput : MonoBehaviour {

	Bounds bounds = new Bounds(Vector3.zero, new Vector3(6, 5, 0));

	void Update () {
		transform.Translate(Input.acceleration.x, 0, 0);	
		Vector3 clampedPosition = transform.position;
		clampedPosition.x = Mathf.Clamp (clampedPosition.x, bounds.min.x, bounds.max.x);
		transform.position = clampedPosition;

	}
}
	
