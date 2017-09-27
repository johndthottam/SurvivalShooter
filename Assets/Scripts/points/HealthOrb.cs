using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthOrb : MonoBehaviour {

	public int healthValue = 50;

	PlayerHealth playerHealth;
	GameObject player;

	AudioSource audioSource;


	// Use this for initialization

	void Start()
	{
		player = GameObject.FindGameObjectWithTag ("Player");
		playerHealth = player.GetComponent <PlayerHealth> ();
	}
	void Awake ()
	{
		audioSource = GetComponent<AudioSource>();
	}

	void Update()
	{
		transform.Rotate (0, 60 * Time.deltaTime, 0);
	}

	void OnTriggerEnter(Collider other)
	{
		if (other.tag == "Player") {
			//ScoreManager.score += scoreValue;
			playerHealth.heal(healthValue);
			audioSource.Play ();
			gameObject.GetComponent<Renderer> ().enabled = false;
			gameObject.GetComponent<SphereCollider>().enabled = false;
		}
		Destroy (gameObject, 5f);

	}
}
