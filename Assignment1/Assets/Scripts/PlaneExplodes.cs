using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlaneExplodes : MonoBehaviour {

    private Animator animator;
    private Collider2D collider;
    private Rigidbody2D rb;
    public AudioSource planeExplodeSound;
    public ScoreManager leScoreManager;
    

    // Use this for initialization

    void Start()
    {
        StartCoroutine(Example());
    }

    void Awake () {

        planeExplodeSound = GameObject.Find("PlaneExplodeSound").GetComponent<AudioSource>();
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
            Example();
            animator.SetBool("Boom", true);
            animator.SetBool("Explodes", true);
            leScoreManager.DecHealth(25);//Decrease Health by 20
            collider.enabled = false;
            rb.gravityScale = 10;
            planeExplodeSound.Play();

            
        }
    }

    void OnCollisionExit2D(Collision2D collision)
    {
        
            //animator.SetBool("Boom", true);

            collider.enabled = true;
            rb.gravityScale = 1;
        
    }

    IEnumerator Example()
    {
        print(Time.time);
        yield return new WaitForSeconds(5);
        print(Time.time);
    }
}
