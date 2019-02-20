using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scroll : MonoBehaviour {

    public float bg_speed = 0.5f;   //to controll background speed

    Vector3 stposition; //Starting position

	// Use this for initialization
	void Start () {
        stposition = transform.position; //Set starting position

    }
	
	// Update is called once per frame
	void Update () {

        transform.Translate((new Vector3(-1,0,0)) * bg_speed * Time.deltaTime);

        if (transform.position.x < -25.7574)
            transform.position = stposition;

    }
}
