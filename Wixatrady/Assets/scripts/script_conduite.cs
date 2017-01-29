using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class script_conduite : MonoBehaviour {

	public GameObject camera;
	public GameObject car;
	float vitesse;
	public int vitesse_max;
	public int acceleration;
	public float rotationSpeed;
	float rotation;
	//public float rotationCamera;
	public GameObject textVitesse;


	// Use this for initialization
	void Start () {
		vitesse = 0;
	}

	// Update is called once per frame
	void Update () {
		// acceleration
		if (Input.GetButton ("Fire1")) {
			if (vitesse < vitesse_max) {
				vitesse += acceleration * Time.deltaTime;
			} else {
				vitesse = vitesse_max;
			}
		} 
		// freinage et marche arriere
		else if (Input.GetButton ("Fire2")) {
			if (vitesse > 1f) {
				vitesse -= acceleration * 1.2f * Time.deltaTime;
			} else if (vitesse <= 1f && vitesse > 0) {
				vitesse = 0;
			} else if (vitesse <= 0 && vitesse > -10f) {
				vitesse -= acceleration * 0.3f * Time.deltaTime;
			} else if (vitesse < -10f) {
				vitesse = -10f;
			}

		} 
		// friction terrain
		else {
			if (vitesse > 1f) {
				vitesse -= acceleration * 0.8f * Time.deltaTime;
			} else if (vitesse < -1f) {
				vitesse += acceleration * 0.8f * Time.deltaTime;
			} else {
				vitesse = 0;
			}
		}
		// rotation
		if (vitesse != 0) {
			rotation = Input.GetAxis ("Horizontal") * rotationSpeed;
			rotation *= Time.deltaTime;
			car.transform.Rotate (0, rotation, 0);

			// Deplacement léger de la caméra quand on tourne
			// Ne marche pas, à régler

			/*rotationCamera = rotation * 10;
			rotationCamera = Mathf.Round (rotationCamera);
			rotationCamera /= 10;
			if (rotationCamera < -0.2f && rotationCamera > -1f) {
				camera.transform.localEulerAngles = new Vector3 (0, 90 - rotationCamera * 5, 0);
			} else if (rotationCamera < -1f) {
				camera.transform.localEulerAngles = new Vector3 (0, 85, 0);
			} else if (rotationCamera > 0.2f && rotationCamera < 1f) {
				camera.transform.localEulerAngles = new Vector3 (0, 90 + rotationCamera * 5, 0);
			} else if (rotationCamera > 1f) {
				camera.transform.localEulerAngles = new Vector3 (0, 95, 0);
			} else {
				camera.transform.localEulerAngles = new Vector3 (0, 90, 0);
			}*/
		} /*else {
			camera.transform.localEulerAngles = new Vector3 (0, 90, 0);
		}*/

		// déplacement
		car.transform.Translate (Vector3.right * vitesse * Time.deltaTime);

		// UI text vitesse
		int vitesseInt = (int)vitesse;
		vitesseInt = Mathf.Abs (vitesseInt);
		textVitesse.GetComponent<Text> ().text = vitesseInt.ToString();
	}
}
