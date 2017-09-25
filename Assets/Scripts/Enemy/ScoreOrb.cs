using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreOrb : MonoBehaviour {

	public int scoreValue = 5;

	AudioSource audioSource;


	// Use this for initialization

	void Awake ()
	{
		audioSource = GetComponent<AudioSource>();
	}

	void OnTriggerEnter(Collider other)
	{
		if (other.tag == "Player") {
			ScoreManager.score += scoreValue;

			audioSource.Play ();
			gameObject.GetComponent<Renderer> ().enabled = false;
			gameObject.GetComponent<SphereCollider>().enabled = false;
		}
		Destroy (gameObject, 5f);

	}
}
