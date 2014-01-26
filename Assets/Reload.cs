using UnityEngine;
using System.Collections;

public class Reload : MonoBehaviour {

	// Use this for initialization
	void Start () {
		Screen.showCursor = true;
		Screen.lockCursor = false;
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnMouseDown(){
		Application.LoadLevel("Livello1");
	}
}
