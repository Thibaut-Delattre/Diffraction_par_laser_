using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class tache : MonoBehaviour {

	public GameObject Laser;
	public GameObject ecran;
	public GameObject fente;

	public SpriteRenderer rend2;

	public float L;
	public float a;
	public float D;
	public float λ;

	void Start () {

		rend2 = GetComponent<SpriteRenderer> ();
	}
	

	void Update () {

		rend2.color = Laser.GetComponent<laser> ().Color;

		a = fente.GetComponent<fente> ().Slidea.value;
		D = ecran.GetComponent<ecran> ().SlideD.value;
		λ = Laser.GetComponent<laser> ().SlideLambda.value;

		L = (2 * D * (λ*Mathf.Pow(10, -9))) / (a*Mathf.Pow(10, -6));

		gameObject.transform.localScale = new Vector3 (L / 0.2f, transform.localScale.y, transform.localScale.z);
		gameObject.transform.position = new Vector3 (ecran.transform.position.x - 0.01f, transform.position.y, transform.position.z);


	}
}
