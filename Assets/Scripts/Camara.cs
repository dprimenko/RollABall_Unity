using UnityEngine;
using System.Collections;

public class Camara : MonoBehaviour {

	public GameObject jugador;	// Enlace a la bola
	private Vector3 posicionRelativa;

	// Use this for initialization
	void Start () {
		posicionRelativa = transform.position - jugador.transform.position;
	}
	
	// Update is called once per frame
	void LateUpdate () {
		transform.position = jugador.transform.position + posicionRelativa;
	}
}
