using UnityEngine;
using System.Collections;

public class GestoreEnergia : MonoBehaviour {
	private float energia = 100;
	private string energiaStr = "Energia: ";

	public float getEnergia(){
		return energia;
	}

	public void subEnergia(float value){
		//Debug.Log ("Tolgo: "+value);
		energia -= value;
	}

	void OnGUI () {
		GUI.TextField(new Rect (25, 25, 100, 30), energiaStr); 
	}

	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
		energiaStr = "Energia: " + energia;
	}
}
