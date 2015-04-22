using UnityEngine;
using System.Collections;

public class Alien : MonoBehaviour {

	public Vector3 alienPos;
	public Vector3 mousePos;

	void Start () {

	}

	void Update () {
		mousePos = Camera.main.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y, Input.mousePosition.z + 10));
		transform.position = mousePos;
		Debug.Log (mousePos);
	}

	void OnCollisionEnter2D (Collision2D other) {
		if (other.gameObject.tag == "Points") {
			Debug.Log ("+1 Point!");
			Destroy (other.gameObject);
		}
	}
}
