using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour {

    public Text coinText;
    public Text healthText;
    private Animator animator;
    public GameObject deathScreen;

    private int coins = 0;
    private int playerHealth = 100;

    public int PlayerHealth
    {
        get
        {
            return playerHealth;
        }

        set
        {
            playerHealth = value;
        }
    }

    public int Coins
    {
        get
        {
            return coins;
        }

        set
        {
            coins = value;
        }
    }

    //  private int increaseScore;

    // Use this for initialization
    void Start () {
        animator = GetComponent<Animator>();
        //deathScreen = GameObject.Find("DeathMenu");//.GetComponent<GameObject>();

    }
	
	// Update is called once per frame
	void Update () {

        if (playerHealth <= 0)
        {
            animator.SetBool("Explodes", true);
            deathScreen.SetActive(true);
            healthText.text = "Health: GameOver";
        }

    }

    //This will increase the score
    public void IncScore(int score)
    {
        coins += score;
        coinText.text = "Coins: " + coins.ToString();
    }

    public void DecHealth(int healthRed)
    {
        playerHealth -= healthRed;
        healthText.text = "Health: " + playerHealth.ToString();
    }

}
