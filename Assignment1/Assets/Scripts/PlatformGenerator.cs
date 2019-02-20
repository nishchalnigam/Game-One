using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformGenerator : MonoBehaviour {

    public GameObject lePlatform;
    public Transform genPoint;
    public float distBw;

    private float platformWd;

    // Use this for initialization
    void Start () {

        platformWd = lePlatform.GetComponent<BoxCollider2D>().size.x;

	}
	
	// Update is called once per frame
	void Update () {
		if (transform.position.x < genPoint.position.x)
        {
            //Moving gen position further
            transform.position = new Vector3(transform.position.x + platformWd + distBw,transform.position.y, transform.position.z);

            //Duplicate a platform
            Instantiate(lePlatform, transform.position, transform.rotation);

        }
	}
}
