using UnityEngine;
using System.Collections;

public class FlashlightComponent : MonoBehaviour {

	public bool on;
	GameObject flashlight;
	GestoreEnergia gestoreEnergia;
	string labelText = "Off";
	public int a = 140;
	public int b = Screen.height-50;
	public int c = Screen.width-300;
	public int d = 120;
	
	// Use this for initialization
	void Start () {
		flashlight = Instantiate (Resources.Load ("Light"), Camera.main.transform.position, Camera.main.transform.rotation) as GameObject;
		flashlight.transform.parent = gameObject.transform;
		gestoreEnergia = GetComponent<GestoreEnergia>();
		on= false;
	}
	
	// Update is called once per frame
	void Update () {
		float currentEnergy = gestoreEnergia.getEnergia();
		if (on){
			flashlight.light.enabled = true;
			gestoreEnergia.subEnergia (4*Time.deltaTime);
		}
		else if(!on)
			flashlight.light.enabled = false;
		if(Input.GetButtonDown ("Fire2"))
			on = !on;
		if (currentEnergy < 1f)
			on = false;
	}

	void OnGUI(){
		if(flashlight.light.enabled){
			labelText = "On";
		}else{
			labelText = "Off";
		}
		GUI.Label(new Rect(Screen.width-80,50,Screen.width,Screen.height),("Sensors"));
		GUI.Label(new Rect(Screen.width-80,70,Screen.width,Screen.height),("Light: " + labelText));
		GUI.Label(new Rect(Screen.width-80,90,Screen.width,Screen.height),("Termal: " + labelText));
	}
}
