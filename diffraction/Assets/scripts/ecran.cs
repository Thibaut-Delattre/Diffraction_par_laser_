using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ecran : MonoBehaviour {

	public Slider SlideD;
	public Text TextD;
	public Camera Cameraecran;

	void Start () {
		
	}
	

	void Update () {

		TextD.text = "D = " + System.Math.Round(SlideD.value, 2) + " m";

		gameObject.transform.localPosition = new Vector3 (SlideD.value / 0.2f, transform.localPosition.y, transform.localPosition.z);

		if (Cameraecran.fieldOfView <= 64f && Cameraecran.fieldOfView >= 10f) {
			if (Input.GetAxis ("Mouse ScrollWheel") > 0f) {
					Cameraecran.fieldOfView -= 1f;
			}
			if (Input.GetAxis ("Mouse ScrollWheel") < 0f) {
					Cameraecran.fieldOfView += 1f;
			}
		}
		if (Cameraecran.fieldOfView > 64f) {
			Cameraecran.fieldOfView = 64f;
		}
		if (Cameraecran.fieldOfView < 10f) {
			Cameraecran.fieldOfView = 10f;
		}
	}
}
