using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CrashControl : MonoBehaviour {
    public int poder = 1;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Cilindro")
        {
            GameController.instance.CambiarCilindros();
            DecrementarPoder();
			GameController.instance.AumentarTamanoObjetosA ();
        }
        else if (collision.gameObject.tag == "Cubo")
        {
            AumentarPoder();
        }
    }

    public void AumentarPoder()
    {
        poder++;
        Debug.Log("Poder aumentado a " + poder);
    }

    public void DecrementarPoder()
    {
        if (poder >= 1)
            poder--;
        Debug.Log("Poder decrementado a " + poder);
    }
}
