using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class taches : MonoBehaviour {

	public SpriteRenderer rend3;

	public GameObject Laser;
	public GameObject Tache;

	void Start () {

		rend3 = GetComponent<SpriteRenderer> ();
	}

	void Update () {

		rend3.color = Laser.GetComponent<laser> ().Color;

		if (gameObject.name == "tache2") {
			gameObject.transform.localScale = new Vector3 ((Tache.transform.localScale.x / 2), (Tache.transform.localScale.y / 2), 0.1f);
			gameObject.transform.localPosition = new Vector3 (Tache.transform.localPosition.x, Tache.transform.localPosition.y, Tache.transform.localPosition.z + ((Tache.transform.localScale.x)*2 + (0.05f) + (gameObject.transform.localScale.x)*2));
		}
		if (gameObject.name == "tache2i") {
			gameObject.transform.localScale = new Vector3 ((Tache.transform.localScale.x / 2), (Tache.transform.localScale.y / 2), 0.1f);
			gameObject.transform.localPosition = new Vector3 (Tache.transform.localPosition.x, Tache.transform.localPosition.y, Tache.transform.localPosition.z - ((Tache.transform.localScale.x)*2 + (0.05f) + (gameObject.transform.localScale.x)*2));
		}
		if (gameObject.name == "tache3") {
			gameObject.transform.localScale = new Vector3 ((Tache.transform.localScale.x / 2), (Tache.transform.localScale.y / 2), 0.1f);
			gameObject.transform.localPosition = new Vector3 (Tache.transform.localPosition.x, Tache.transform.localPosition.y, Tache.transform.localPosition.z + ((Tache.transform.localScale.x)*4 + (0.03f) + (gameObject.transform.localScale.x)*4));
		}
		if (gameObject.name == "tache3i") {
			gameObject.transform.localScale = new Vector3 ((Tache.transform.localScale.x / 2), (Tache.transform.localScale.y / 2), 0.1f);
			gameObject.transform.localPosition = new Vector3 (Tache.transform.localPosition.x, Tache.transform.localPosition.y, Tache.transform.localPosition.z - ((Tache.transform.localScale.x)*4 + (0.03f) + (gameObject.transform.localScale.x)*4));
		}
		if (gameObject.name == "tache4") {
			gameObject.transform.localScale = new Vector3 ((Tache.transform.localScale.x / 2), (Tache.transform.localScale.y / 2), 0.1f);
			gameObject.transform.localPosition = new Vector3 (Tache.transform.localPosition.x, Tache.transform.localPosition.y, Tache.transform.localPosition.z + ((Tache.transform.localScale.x)*6 + (0.018f) + (gameObject.transform.localScale.x)*6));
		}
		if (gameObject.name == "tache4i") {
			gameObject.transform.localScale = new Vector3 ((Tache.transform.localScale.x / 2), (Tache.transform.localScale.y / 2), 0.1f);
			gameObject.transform.localPosition = new Vector3 (Tache.transform.localPosition.x, Tache.transform.localPosition.y, Tache.transform.localPosition.z - ((Tache.transform.localScale.x)*6 + (0.018f) + (gameObject.transform.localScale.x)*6));
		}
		if (gameObject.name == "tache5") {
			gameObject.transform.localScale = new Vector3 ((Tache.transform.localScale.x / 2), (Tache.transform.localScale.y / 2), 0.1f);
			gameObject.transform.localPosition = new Vector3 (Tache.transform.localPosition.x, Tache.transform.localPosition.y, Tache.transform.localPosition.z + ((Tache.transform.localScale.x)*8 + (0.0108f) + (gameObject.transform.localScale.x)*8));
		}
		if (gameObject.name == "tache5i") {
			gameObject.transform.localScale = new Vector3 ((Tache.transform.localScale.x / 2), (Tache.transform.localScale.y / 2), 0.1f);
			gameObject.transform.localPosition = new Vector3 (Tache.transform.localPosition.x, Tache.transform.localPosition.y, Tache.transform.localPosition.z - ((Tache.transform.localScale.x)*8 + (0.0108f) + (gameObject.transform.localScale.x)*8));
		}
		if (gameObject.name == "tache6") {
			gameObject.transform.localScale = new Vector3 ((Tache.transform.localScale.x / 2), (Tache.transform.localScale.y / 2), 0.1f);
			gameObject.transform.localPosition = new Vector3 (Tache.transform.localPosition.x, Tache.transform.localPosition.y, Tache.transform.localPosition.z + ((Tache.transform.localScale.x)*10 + (0.0064f) + (gameObject.transform.localScale.x)*10));
		}
		if (gameObject.name == "tache6i") {
			gameObject.transform.localScale = new Vector3 ((Tache.transform.localScale.x / 2), (Tache.transform.localScale.y / 2), 0.1f);
			gameObject.transform.localPosition = new Vector3 (Tache.transform.localPosition.x, Tache.transform.localPosition.y, Tache.transform.localPosition.z - ((Tache.transform.localScale.x)*10 + (0.0064f) + (gameObject.transform.localScale.x)*10));
		}
	}
}
