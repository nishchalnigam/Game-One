using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InstantVelocity : MonoBehaviour {


    public Vector2 velocity;

    private Rigidbody2D body2d;
    private Vector2 speed;

    void Awake()
    {
        body2d = GetComponent<Rigidbody2D>();
    }

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void FixedUpdate () {

        body2d.velocity = velocity;

	}
}
