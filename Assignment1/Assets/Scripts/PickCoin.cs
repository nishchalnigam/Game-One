using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickCoin : MonoBehaviour {

    public int score;

    public ScoreManager leScoreManager;
    public AudioSource coinSound;
    public GameObject platformDestructionPoint;
    public GameObject wonScreen;

    // Update is called once per frame
    void Update()
    {

        if (transform.position.x < platformDestructionPoint.transform.position.x)
        {
            //Destroy(gameObject);

            gameObject.SetActive(true);
        }
    }

    // Use this for initialization
    void Start () {
        leScoreManager = FindObjectOfType<ScoreManager>();
        coinSound = GameObject.Find("CoinSound").GetComponent<AudioSource>();
        //Look for a score manager
        //Get ScoreManager from GameManager
        platformDestructionPoint = GameObject.Find("Destroy");
        gameObject.SetActive(true);
    }

    //This function will controll coin collection
    void OnTriggerEnter2D(Collider2D player)
    {
        Debug.Log("Something Happen");
        if(player.gameObject.name=="Player")
        {
            leScoreManager.IncScore(1);//Increase Score by 1
            coinSound.Play();
            gameObject.SetActive(false);//Coin Dissapears
        }

        



    }
}
