using UnityEngine;
using System.Collections;

public class NewBehaviourScript : MonoBehaviour {
		int pos =0;
		int pos1=0;
		int pos2=0;
	private int button=0;
	private int plano=0;
	private int esfera=0;
	private int capsula=0;

		float r = 0.0f;
		float g = 0.0f;
		float b = 0.0f;
		GameObject cube1;
		GameObject esfera1;
		GameObject capsula1;
		GameObject plano1;
		public GUISkin customSkin;
		
		void OnGUI () {
				GUI.skin = customSkin;
				GUI.Label (new Rect (260, 85, 100, 100), "ROJO");
				GUI.Label (new Rect (260, 115, 100, 100), "VERDE");
				GUI.Label (new Rect (260, 145, 100, 100), "AZUL");
			
				r = GUI.HorizontalSlider (new Rect (450, 10, 100, 30), r, 0.0f, 1.0f);
				g = GUI.HorizontalSlider (new Rect (450, 40, 100, 30), g, 0.0f, 1.0f);
				b = GUI.HorizontalSlider (new Rect (450, 70, 100, 30), b, 0.0f, 1.0f);
			
				if (GUI.Button (new Rect (250, 50, 100, 30), "Crear Cubo")) {
						if (button == 0) {
								pos += 3;
								cube1 = GameObject.CreatePrimitive (PrimitiveType.Cube);
								cube1.transform.position = new Vector3 (-8, 0, pos);
								cube1.transform.localScale = new Vector3 (2, 2, 2);
								cube1.transform.rotation = Quaternion.Euler (0, 0, 0);
								cube1.renderer.material.color = new Color (r, g, b, 250f);
								button = 1;
				
						} else {
								Debug.Log ("exiten el objecto");
						}
				}
				if (GUI.Button (new Rect (250, 80, 100, 30), "Crear esfera")) {
						if (esfera == 0) {
								pos1 += 3;
								esfera1 = GameObject.CreatePrimitive (PrimitiveType.Sphere);
								esfera1.transform.position = new Vector3 (-8, 0, pos1);
								esfera1.transform.localScale = new Vector3 (2, 2, 2);
								esfera1.transform.rotation = Quaternion.Euler (0, 0, 0);
								esfera1.renderer.material.color = new Color (r, g, b);
								esfera = 1;
						} else {
								Debug.Log ("exiten el objecto");
						}
				}
				if (GUI.Button (new Rect (250, 110, 100, 30), "Crear Capsula")) {
						if (capsula == 0) {
								pos2 += 3;
								capsula1 = GameObject.CreatePrimitive (PrimitiveType.Capsule);
								capsula1.transform.position = new Vector3 (-8, 0, pos2);
								capsula1.transform.localScale = new Vector3 (2, 2, 2);
								capsula1.transform.rotation = Quaternion.Euler (0, 0, 0);
								capsula1.renderer.material.color = new Color (r, g, b);
								capsula = 1;
						} else {
								Debug.Log ("exiten el objecto");
						}
				}
				if (GUI.Button (new Rect (250, 140, 100, 30), "Crear Plano")) {
						if (plano == 0) {
								pos2 += 3;
								plano1 = GameObject.CreatePrimitive (PrimitiveType.Plane);
								plano1.transform.position = new Vector3 (-8, 0, pos2);
								plano1.transform.localScale = new Vector3 (2, 2, 2);
								plano1.transform.rotation = Quaternion.Euler (0, 0, 0);
								plano1.renderer.material.color = new Color (r, g, b);
								plano = 1;
						} else {
								Debug.Log ("exiten el objecto");
						}
				}
	}

		void Update(){
			if(cube1 != null)
				cube1.renderer.material.color=new Color(r,g,b);
			if(esfera1 != null)
				esfera1.renderer.material.color=new Color(r,g,b);
			if(capsula1 != null)
				capsula1.renderer.material.color=new Color(r,g,b);
		}
	}