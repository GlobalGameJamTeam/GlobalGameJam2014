using UnityEngine;
using System.Collections;

public class GestoreEnergia : MonoBehaviour {
	private const float MAX_ENERGIA = 100;
	private float energia = MAX_ENERGIA;
	private string energiaStr = "Energia: ";

	public float getEnergia(){
		return energia;
	}

	public void subEnergia(float value){
		//Debug.Log ("Tolgo: "+value);
		energia -= value;
	}

	void OnGUI () {
		//GUI.TextField(new Rect (25, 25, 100, 30), energiaStr);
		float width = Mathf.Clamp01 (energia / MAX_ENERGIA) * (Screen.width - 140);
		GUI.Box (new Rect ((Screen.width-width)/2, 0, width, 20), energiaStr);
	}

	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
		energiaStr = "Energia: " + (int)energia;

	}
}
