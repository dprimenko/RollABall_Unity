using UnityEngine;
using System.Collections;

public class ControladorJuego : MonoBehaviour {

	Rigidbody rg;					// De la bola (jugador)
	public float velocidad = 1f;	
	float movimientoHorizontal;
	float movimientoVertical;
	Vector3 movimiento;
	int contador = 0;

	void Start () {
	
	}

	void Awake() {
		rg = GetComponent<Rigidbody> ();
	}

	void FixedUpdate () {
		movimientoHorizontal = Input.GetAxis("Horizontal");
		movimientoVertical = Input.GetAxis ("Vertical");

		movimiento = new Vector3 (movimientoHorizontal, 0, movimientoVertical);

		rg.AddForce (movimiento * velocidad);


	}

	void OnTriggerEnter(Collider item) {
		if (item.tag == "Premio") {
			Destroy (item.gameObject);
			contador++;
		}
	}
}
