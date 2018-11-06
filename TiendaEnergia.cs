using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class TiendaEnergia : MonoBehaviour {
	public const int cantidadInicialMonedas = 5;
	public const int precioEnergia = 1;
	int monedas = cantidadInicialMonedas;
	public Text mostrarInfo;

	// Use this for initialization
	void Start () {
		GameController.instance.EventoAumentarMonedas += AumentarMonedas;
		ActualizarInfo ();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void ComprarEnergia1 () {
		ComprarEnergia (1);
	}

	void ComprarEnergia(int cantidad) {
		if (monedas >= precioEnergia * cantidad) {
			monedas -= precioEnergia * cantidad;
			GameController.instance.AumentarEnergia (cantidad);
		}
		ActualizarInfo ();
	}

	public void AumentarMonedas(int cantidad) {
		monedas += cantidad;
		ActualizarInfo ();
	}

	public void ActualizarInfo() {
		mostrarInfo.text = "\nPrecio: " + precioEnergia + "\nMonedas: " + monedas;
	}
}
