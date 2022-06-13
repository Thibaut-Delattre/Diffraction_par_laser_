using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class resultats : MonoBehaviour {

	public GameObject Laser;
	public GameObject Tache;
	public GameObject Fente;
	public GameObject Ecran;

	public float L;
	public float D;
	public float λ;
	public float a;
	public float θ;

	public Text Resultats;


	void Start () {
		
	}
	

	void Update () {

		L = (Tache.GetComponent<tache> ().L)*(Mathf.Pow(10, 2));
		D = Ecran.GetComponent<ecran> ().SlideD.value;
		λ = Laser.GetComponent<laser> ().SlideLambda.value;
		a = Fente.GetComponent<fente> ().Slidea.value;
		θ = (λ*Mathf.Pow(10, -9)) / (a*Mathf.Pow(10, -6));

		Resultats.text = "<b>λ</b> = <b>" + System.Math.Round(λ, 0) + " nm</b> <size=25><i>(Longueur d'onde du Laser dans le vide)</i></size>\n\n"
					+ "<b>a</b> = <b>" + System.Math.Round(a, 0) + " µm</b> <size=25><i>(Largeur de la fente)</i></size>\n\n"
					+ "<b>D</b> = <b>" + System.Math.Round(D, 2) + " m</b> <size=25><i>(Distance entre la fente et l'écran)</i></size>\n\n"
					+ "<b>L</b> = <b>" + System.Math.Round(L, 2) + " cm</b> <size=25><i>(Largeur de la tache centrale)</i></size>\n\n"
					+ "<b>θ</b> = <b>" + System.Math.Round(θ, 4) + " rad</b> <size=25><i>(Ecart angulaire)</i></size>";
		

	}
}
