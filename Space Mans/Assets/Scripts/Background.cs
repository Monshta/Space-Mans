using UnityEngine;
using System.Collections;

public class Background : MonoBehaviour {

	void Update () {
		MeshRenderer mr = GetComponent<MeshRenderer> ();
		Material mat = mr.material;
		Vector2 offset = mat.mainTextureOffset;

		offset.x += Time.deltaTime / 7;
		mat.mainTextureOffset = offset;
	}
}
