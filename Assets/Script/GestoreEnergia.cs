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
		GUI.Box (new Rect (70, 10, Mathf.Clamp01 (energia / MAX_ENERGIA) * (Screen.width - 140), 20), energiaStr);
	}

	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
		energiaStr = "Energia: " + (int)energia;

	}
}
