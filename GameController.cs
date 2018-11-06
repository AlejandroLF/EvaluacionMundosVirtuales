using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public delegate void CambioCilindros();
public delegate void DisminuirPoderObjetosA(int cantidad);
public delegate void DisminuirTamanoObjetosA(float proporcion);
public delegate void CambioColorObjetosB();
public delegate void AumentarMonedas(int cantidad);

public class GameController : MonoBehaviour {
    public static GameController instance;
	int energia = 2;
	public Text mostrarEnergia;

	public event CambioCilindros EventoCambioCilindros;
	public event DisminuirPoderObjetosA EventoDisminuirPoderObjetosA;
	public event DisminuirTamanoObjetosA EventoDisminuirTamanoObjetosA;
	public event CambioColorObjetosB EventoCambioColorObjetosB;
	public event AumentarMonedas EventoAumentarMonedas;


    void Awake()
    {
        if (instance == null)
        {
            instance = this;
            DontDestroyOnLoad(this);
        }
        else if (instance != this)
            Destroy(gameObject);
    }

    // Use this for initialization
    void Start () {
		ActualizarEnergia ();
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown(KeyCode.V)) {
			DisparoA ();
		}
		if (Input.GetKeyDown(KeyCode.B)) {
			DisparoB ();
		}
	}

    public void CambiarCilindros()
    {
        EventoCambioCilindros();
    }

	public int GetEnergia() {
		return energia;
	}

	public void AumentarEnergia(int cantidad) {
		energia += cantidad;
		ActualizarEnergia ();
	}

	public void ActualizarEnergia() {
		mostrarEnergia.text = "Energía: " + energia;
	}

	public void DisparoA() {
		EventoDisminuirPoderObjetosA (energia);
		EventoDisminuirTamanoObjetosA (energia);
	}

	public void DisparoB() {
		EventoCambioColorObjetosB ();
		EventoAumentarMonedas (3);
	}

	public void AumentarTamanoObjetosA () {
		EventoDisminuirTamanoObjetosA (0.5F);
	}
}
