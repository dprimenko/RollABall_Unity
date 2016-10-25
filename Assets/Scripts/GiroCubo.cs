using UnityEngine;
using System.Collections;

public class GiroCubo : MonoBehaviour {

	const float GRADOSEG = 30f;
	Vector3 rotacion;

	void Start () {
		rotacion = new Vector3 (GRADOSEG, GRADOSEG, GRADOSEG);
	}

	void Update () {
		transform.Rotate (rotacion * Time.deltaTime);
	}
}
