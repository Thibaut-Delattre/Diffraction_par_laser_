using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class fente : MonoBehaviour {

	public Slider Slidea;
	public Text Texta;

	void Start () {
		
	}
	

	void Update () {

		Texta.text = "a = " + System.Math.Round(Slidea.value, 0) + " µm";

		gameObject.transform.localScale = new Vector3 (transform.localScale.x, transform.localScale.y, Slidea.value / 4000);
	}
}
