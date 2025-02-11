﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PhoneBehavior : MonoBehaviour {
	public float speed = 50.0f;

	private void Update () {
		Vector2 dir = Vector2.zero;

		// we assume that the device is held parallel to the ground
		// and the Home button is in the right hand

		// remap the device acceleration axis to game coordinates:
		// 1) XY plane of the device is mapped onto XZ plane
		// 2) rotated 90 degrees around Y axis
		dir.x = Input.location.x;
		dir.y = Input.location.y;

		// clamp acceleration vector to the unit sphere
		if (dir.sqrMagnitude > 1)
			dir.Normalize();

		// Make it move 10 meters per second instead of 10 meters per frame...
		dir *= Time.deltaTime;

		// Move object
		this.transform.Translate (dir * speed);
	}

}