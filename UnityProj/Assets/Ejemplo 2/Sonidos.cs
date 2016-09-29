using UnityEngine;

public class Sonidos : MonoBehaviour
{
	private AudioSource audioSource;

	private float lastTime = 0.0f;

	void Awake ()
	{
		audioSource = GetComponent<AudioSource> ();
	}
	
	void OnTriggerEnter (Collider other)
	{
		float currentTime = Time.time;
		float timeDiff = currentTime - lastTime;
		lastTime = currentTime;
		if (timeDiff < 2.0f) {
			audioSource.pitch += 0.05f;
		}
		else
		{
			audioSource.pitch = 1f;
		}

		audioSource.Play();
	}
}
