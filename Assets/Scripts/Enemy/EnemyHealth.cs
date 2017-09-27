using UnityEngine;
using UnityEngine.UI;

public class EnemyHealth : MonoBehaviour
{
    public int startingHealth = 100;
    public int currentHealth;
    public float sinkSpeed = 2.5f;
    public int scoreValue = 10;
    public AudioClip deathClip;
	public Image healthBar;

	public GameObject ScoreOrb;
	public GameObject HealthOrb;

	private float health;
    Animator anim;
    AudioSource enemyAudio;
    ParticleSystem hitParticles;
    CapsuleCollider capsuleCollider;


    bool isDead;
    bool isSinking;


    void Awake ()
    {
        anim = GetComponent <Animator> ();
        enemyAudio = GetComponent <AudioSource> ();
        hitParticles = GetComponentInChildren <ParticleSystem> ();
        capsuleCollider = GetComponent <CapsuleCollider> ();

        currentHealth = startingHealth;
		health = startingHealth;

    }

	void start()
	{
		health = startingHealth;
		healthBar.canvasRenderer.SetAlpha( 0.0f );
	}
    void Update ()
    {
        if(isSinking)
        {
            transform.Translate (-Vector3.up * sinkSpeed * Time.deltaTime);
        }

		healthBar.fillAmount = ((currentHealth / health) * 100) / 100f;
    }


    public void TakeDamage (int amount, Vector3 hitPoint)
    {
        if(isDead)
            return;

        enemyAudio.Play ();

		healthBar.canvasRenderer.SetAlpha( 0.0f );
		healthBar.CrossFadeAlpha( 1.0f, 1, false );

        currentHealth -= amount;

        hitParticles.transform.position = hitPoint;
        hitParticles.Play();

        if(currentHealth <= 0)
        {
            Death ();
        }
    }


    void Death ()
    {
        isDead = true;

        capsuleCollider.isTrigger = true;

        anim.SetTrigger ("Dead");

        enemyAudio.clip = deathClip;
        enemyAudio.Play ();
    }


    public void StartSinking ()
    {
        GetComponent <UnityEngine.AI.NavMeshAgent> ().enabled = false;
        GetComponent <Rigidbody> ().isKinematic = true;
        isSinking = true;
        ScoreManager.score += scoreValue;
        Destroy (gameObject, 2f);

		OrbSpawn ();
    }

	void OrbSpawn()
	{
		if (Random.value >= 0.5)
		{
			if (Random.value > 0.7)
			 {
				Instantiate (HealthOrb, transform.position, transform.rotation);
			 } 
			else 
			 {
				Instantiate (ScoreOrb, transform.position, transform.rotation);
			 }

		}
	}
}
