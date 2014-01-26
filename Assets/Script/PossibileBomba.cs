using UnityEngine;
using System.Collections;

public class PossibileBomba : MonoBehaviour {

	public bool bomba;
	private float dist = 1000f;

	void OnMouseDown() {
		Debug.Log ("clicked possible bomb");
		if (closeEnough ()) {
						if (bomba) {
								Application.LoadLevel ("WinningScreen");
						} else {
								Application.LoadLevel ("GameOver");
						}
				}
	}

	bool closeEnough() {
		Vector3 myPos = Camera.main.transform.position;
		Vector3 bombPos = transform.position;
		this.dist = Vector3.Distance (myPos, bombPos);
		Debug.Log (dist);
		return dist < 5;
	}

	float getDist(){
		return dist;
	}

	void OnGUI(){
		if (getDist() < 5f){
			GUI.Label(new Rect(Screen.width-120,90,Screen.width,Screen.height),("Left Click to activate"));
		}
	}
}
