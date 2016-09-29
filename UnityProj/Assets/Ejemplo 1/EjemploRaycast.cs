using UnityEngine;
using System.Collections;

public class EjemploRaycast : MonoBehaviour {

	void Start () {
	
	}

	void Update () {
	
		RaycastHit hitInfo;

		if (Physics.Raycast (Vector3.zero,
							 Vector3.forward,
							 out hitInfo))
		{
			
		}

	}
}
