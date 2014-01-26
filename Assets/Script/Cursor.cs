using UnityEngine;
using System.Collections;

public class Cursor : MonoBehaviour {

	public Texture aText;

	// Use this for initialization
	void Start () {
		Screen.showCursor = false;
		Screen.lockCursor = true;
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnGUI () {
		GUI.DrawTexture(new Rect(Screen.width/2, Screen.height/2, 30, 30), aText, ScaleMode.ScaleToFit, true, 0f);
	}
}
