﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class thirdperson : MonoBehaviour {

	public float speed = 1;
	public Transform Target;
	public Camera cam;

	void LateUpdate(){
	}

	public void Move(){
		Vector3 direction = (Target.position - cam.transform.position).normalized;
		Quaternion lookrotation = Quaternion.LookRotation(direction);

		lookrotation.x = transform.rotation.x;
		lookrotation.z = transform.rotation.z;

		transform.rotation = Quaternion.Slerp(transform.rotation, lookrotation, Time.deltaTime * 100);

		transform.position = Vector3.Slerp(transform.position, Target.position, Time.deltaTime * speed);
	}

}
