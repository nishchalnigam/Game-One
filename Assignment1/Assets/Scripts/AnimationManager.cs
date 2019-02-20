using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationManager : MonoBehaviour {

    private Animator animator;
    private Collider2D collider;
    private Rigidbody2D rb;
    private AudioSource tankExpSound;
    public ScoreManager leScoreManager;

    // Use this for initialization
    void Awake () {
        tankExpSound = GameObject.Find("TankExplodeSound").GetComponent<AudioSource>();
        animator = GetComponent<Animator>();
        collider = GetComponent<Collider2D>();
        rb = GetComponent<Rigidbody2D>();
        leScoreManager = FindObjectOfType<ScoreManager>();
    }
	
	// Update is called once per frame
	void Update () {
		
	}

    //Explode tanks on collision
    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.name == "Player")
        {
            leScoreManager.DecHealth(20);//Decrease Health by 20
            animator.SetBool("Moving", false);
            tankExpSound.Play();
            collider.enabled = false;
            rb.gravityScale = 0;
        }
    }
}
