using UnityEngine;

public class EjemploAudio1 : MonoBehaviour {

	public AudioClip otroSonido;

	private AudioSource aSource;

	void Awake () {
	
		aSource = GetComponent<AudioSource> ();

	}

	void Update () {

		if (Input.anyKeyDown) {
			aSource.PlayOneShot (otroSonido);
		}

	}
}
