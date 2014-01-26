#pragma strict

function Update () {
	// Slowly rotate the object around its X axis at 1 degree/second.
		transform.Rotate(Vector3.up * Time.deltaTime * 150);
}