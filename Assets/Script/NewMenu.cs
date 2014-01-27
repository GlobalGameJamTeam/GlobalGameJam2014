using UnityEngine;
using System.Collections;

public class NewMenu : MonoBehaviour {

	private float up = (Screen.height - 345) / 2;
	private float left = (Screen.width  - 50) / 2;

	/*
	void OnStart (){
		public float left = (Screen.height ) / 2;
		public float up = (Screen.width ) / 2;
	}*/
	
	void OnGUI () {
		if(GUI.Button (new Rect (left,up,115,50), "Livello 1")) {
			Application.LoadLevel ("Livello1");
		}

		if(GUI.Button (new Rect (left,up + 60,115,50), "Livello 2")) {
			Application.LoadLevel ("livello_prova");
		}

		if(GUI.Button (new Rect (left,up + 120,115,50), "Quit")) {
			Application.Quit();
		}
	}
}