using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CambiarObjetoA : MonoBehaviour {
	public const int poderInicial = 10;
	Transform tf;
	int poder = poderInicial;

	// Use this for initialization
	void Start () {
		tf = GetComponent<Transform> ();
		GameController.instance.EventoDisminuirPoderObjetosA += DisminuirPoder;
		GameController.instance.EventoDisminuirTamanoObjetosA += DisminuirTamano;
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void DisminuirPoder (int cantidad) {
		if (cantidad <= poder)
			poder -= cantidad;
		else
			poder = 0;
		Debug.Log ("Nuevo poder: " + poder);
	}

	public void DisminuirTamano (float proporcion) {
		float escala = 1F / proporcion;
		tf.localScale = new Vector3 (tf.localScale.x * escala, tf.localScale.y * escala, tf.localScale.z * escala);
		tf.localPosition = new Vector3 (tf.localPosition.x, tf.localScale.y / 2, tf.localPosition.z);
	}
}
