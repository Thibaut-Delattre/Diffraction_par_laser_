using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class laser : MonoBehaviour {

	public Material Mat;
	public Slider SlideLambda;
	public Text TextLambda;

	public Color32 Color;

	public byte R;
	public byte G;
	public byte B;

	public float λ;

	void Start () {

		Mat = gameObject.GetComponent<Renderer>().material;
	}
	

	void Update () {

		TextLambda.text = "λ = " + System.Math.Round(SlideLambda.value, 0) + " nm";

		Color = new Color32(R, G, B, 255);
		λ = SlideLambda.value;

		if (SlideLambda.value >= 380 && SlideLambda.value < 420) {
			R = System.Convert.ToByte(255 * (440 - λ) / (440 - 380) * (0.3 + 0.7 * (λ - 380)) / (420 - 380));
			G = System.Convert.ToByte (0);
			B = System.Convert.ToByte (255 * (0.3 + 0.7 * (λ - 380)) / (420 - 380));
		}
		if (SlideLambda.value >= 420 && SlideLambda.value < 440) {
			R = System.Convert.ToByte(255*(440-λ)/(440-380));
			G = System.Convert.ToByte (0);
			B = System.Convert.ToByte (255);
		}
		if (SlideLambda.value >= 440 && SlideLambda.value < 490) {
			R = System.Convert.ToByte(0);
			G = System.Convert.ToByte (255*(λ-440)/(490-440));
			B = System.Convert.ToByte (255);
		}
		if (SlideLambda.value >= 490 && SlideLambda.value < 510) {
			R = System.Convert.ToByte(0);
			G = System.Convert.ToByte (255);
			B = System.Convert.ToByte (255*(510-λ)/(510-490));
		}
		if (SlideLambda.value >= 510 && SlideLambda.value < 580) {
			R = System.Convert.ToByte(255*(λ-510)/(580-510));
			G = System.Convert.ToByte (255);
			B = System.Convert.ToByte (0);
		}
		if (SlideLambda.value >= 580 && SlideLambda.value < 645) {
			R = System.Convert.ToByte(255);
			G = System.Convert.ToByte (255*(645-λ)/(645-580));
			B = System.Convert.ToByte (0);
		}
		if (SlideLambda.value >= 645 && SlideLambda.value < 700) {
			R = System.Convert.ToByte(255);
			G = System.Convert.ToByte (0);
			B = System.Convert.ToByte (0);
		}
		if (SlideLambda.value >= 700 && SlideLambda.value <= 780) {
			R = System.Convert.ToByte(255*(0.3+0.7*(780-λ))/(780-700));
			G = System.Convert.ToByte (0);
			B = System.Convert.ToByte (0);
		}



		Mat.SetColor("_EmissionColor", Color);
	}
}
