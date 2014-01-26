using UnityEngine;
using System.Collections;

public class Calore : MonoBehaviour {
	bool on;
	PossibileBomba[] poBombe;
	Material calore;
	Material originale;

	// Use this for initialization
	void Start () {
		on = false;
		calore = Resources.Load<Material>("Calore");
		poBombe = GetComponentsInChildren<PossibileBomba>(); 
		foreach (PossibileBomba poBomba in poBombe){
			if(poBomba.bomba){
				originale = poBomba.renderer.material;
			}
		}
	}
	
	// Update is called once per frame
	void Update () {
		if(Input.GetKeyUp(KeyCode.H)){
			on = !on;
			Debug.Log ("pressed H");
			if(on){
				foreach (Component poBomba in poBombe){
					if(poBomba.GetComponent<PossibileBomba>().bomba){
						poBomba.renderer.material = calore;
					}
				}
			}
			if(!on){
				foreach (Component poBomba in poBombe){
					if(poBomba.GetComponent<PossibileBomba>().bomba){
						poBomba.renderer.material = originale;
					}
				}
			}
		}
	}

}
