using UnityEngine;
using System.Collections;

public class PossibileBomba : MonoBehaviour {

	public bool bomba;

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
		float dist = Vector3.Distance (myPos, bombPos);
		Debug.Log (dist);
		return dist < 3;
	}
}
