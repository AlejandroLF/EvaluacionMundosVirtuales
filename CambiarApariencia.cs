using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CambiarApariencia : MonoBehaviour {
    public Renderer rend;

    // Use this for initialization
    void Start () {
        rend = GetComponent<Renderer>();
		GameController.instance.EventoCambioCilindros += CambiarColorRojo;
		GameController.instance.EventoCambioColorObjetosB += CambiarColorAzul;
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    void CambiarColorRojo ()
    {
        rend.material.color = Color.red;
    }

	void CambiarColorAzul ()
	{
		rend.material.color = Color.blue;
	}
}
