using UnityEngine;

public class Caja : MonoBehaviour {

	void Start ()
	{
		transform.Rotate (0, Random.Range (0, 180), 0, Space.World);
	}

	void Update ()
	{
		transform.Rotate (Vector3.up * 150f * Time.deltaTime, Space.World);
	}

	void OnTriggerEnter(Collider other)
	{
		Destroy (gameObject);
	}
}
