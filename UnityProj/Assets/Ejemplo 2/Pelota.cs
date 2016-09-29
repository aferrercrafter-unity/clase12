using UnityEngine;

public class Pelota : MonoBehaviour
{
	private Rigidbody rb;

	public float speed;

	private float h = 0f;
	private float v = 0f;

	void Awake ()
	{
		rb = GetComponent<Rigidbody>();
	}
	
	void Update ()
	{
		h = Input.GetAxis ("Horizontal");
		v = Input.GetAxis ("Vertical");
	}

	void FixedUpdate ()
	{
		rb.AddForce (v * Vector3.forward * speed);
		rb.AddForce (h * Vector3.right * speed);
	}
}
