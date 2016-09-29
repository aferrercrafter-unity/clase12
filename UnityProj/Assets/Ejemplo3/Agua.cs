using UnityEngine;
using System.Collections;

public class Agua : MonoBehaviour {

	AudioLowPassFilter filtro;
	Rigidbody rb;

	void Awake()
	{
		filtro = GetComponent<AudioLowPassFilter> ();

		rb = GetComponent<Rigidbody> ();
	}

	void OnTriggerEnter(Collider other)
	{
		filtro.enabled = true;	
	}


	void OnTriggerExit(Collider other)
	{
		filtro.enabled = false;	
	}

}
