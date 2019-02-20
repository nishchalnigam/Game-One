using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Control : MonoBehaviour {
    Rigidbody2D rb;
    private Animator animator;
    public float speed;
    public ScoreManager leScoreManager;
    public GameObject deathScreen;
    public GameObject wonScreen;
    private Collider2D collider;



    // Use this for initialization
    void Start()
    {
        //This will reference the gameObject
        rb = gameObject.GetComponent<Rigidbody2D>();
        leScoreManager = FindObjectOfType<ScoreManager>();
        //deathScreen = GameObject.Find("DeathMenu");
        animator = GetComponent<Animator>();
        collider = GetComponent<Collider2D>();

    }

    //public void OnCollisionEnter2D(Collision2D collision)
    //{
    //    if (leScoreManager.PlayerHealth <= 0)
    //    {
    //        deathScreen.SetActive(true);
    //    }
    //}


    // Update is called once per frame
    void Update()
    {
        if (leScoreManager.PlayerHealth <= 0)
        {
            animator.SetBool("Explodes", true);
            collider.enabled = false;
            deathScreen.SetActive(true);
        }

        if (leScoreManager.Coins >= 10)
        {

            wonScreen.SetActive(true);
        }

        if (transform.position.y <= 4.5f && transform.position.y >= -5f)
        {

            //Translate by Axis

            float xSpeed = Input.GetAxis("Horizontal");
            float ySpeed = Input.GetAxis("Vertical");

            //speed = 0.2;
            //transform.Translate(new Vector2(xSpeed,ySpeed) * speed);
            xSpeed = 0f;
            ySpeed = 0f;


            print(xSpeed);

            //if (Input.GetKey(KeyCode.D))
            //{
            //    xSpeed = 1;
            //}
            //else if (Input.GetKey(KeyCode.A))
            //{
            //    xSpeed = -1;
            //}
            //else
            //    xSpeed = 0;



            if (Input.GetKey(KeyCode.W))
            {
                ySpeed = 1;
            }
            else if (Input.GetKey(KeyCode.S))
            {
                ySpeed = -1;
            }
            else
            {
                ySpeed = 0;
            }


            //rb.AddForce(new Vector2(xSpeed, ySpeed) * speed);
            //Velocity
            //Translate is for non-colliding objects
            //Use translation for endless road
            //Can also change the weight
            //Use Spwners to spawn objects
            rb.velocity = new Vector2(xSpeed, ySpeed) * speed;
        }

        else if (transform.position.y > 4.5f) 
        {
            transform.position = new Vector3(transform.position.x, 4.45f ,transform.position.z);
        }
        else if (transform.position.y < -5f)
        {
            transform.position = new Vector3(transform.position.x, -4.95f, transform.position.z);
        }
    }
}
