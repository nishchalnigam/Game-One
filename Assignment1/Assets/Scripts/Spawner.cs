using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = System.Random;

public class Spawner : MonoBehaviour {


    public GameObject[] prefabs;

    public ObjectPooler leObjPool;

    public CoinGen leCoinGen;

    public float delay = 2.0f;

    public bool active = true;

	// Use this for initialization
	void Start () {

        StartCoroutine(EnemyGenerator());

        leCoinGen = FindObjectOfType<CoinGen>();
		
	}

    IEnumerator EnemyGenerator()
    {
        yield return new WaitForSeconds(delay);

        if (active)
        {
            var newTransf = transform;
            transform.position = new Vector3(16.6f, GetRandomNumber(-4.6f, 2.2f), 1);
            //Instantiate(prefabs[UnityEngine.Random.Range(0, prefabs.Length)], newTransf.position, transform.rotation);
            GameObject newPlatform = leObjPool.GetPooledObj();
            newPlatform.transform.position = transform.position;
            newPlatform.transform.rotation = transform.rotation;
            newPlatform.SetActive(true);

            GameObject coin = leObjPool.GetPooledObj3();
            coin.transform.position = transform.position;//new Vector3(newPlatform.transform.position.x, newPlatform.transform.position.y+1, newPlatform.transform.position.z);
            coin.transform.rotation = newPlatform.transform.rotation;
            coin.SetActive(true);

            GameObject planeUp = leObjPool.GetPooledObj2();
            planeUp.transform.position = transform.position;
            planeUp.transform.rotation = transform.rotation;
            planeUp.SetActive(true);

            GameObject planeDwn = leObjPool.GetPooledObj4();
            planeDwn.transform.position = transform.position;
            planeDwn.transform.rotation = transform.rotation;
            planeDwn.SetActive(true);
            //leCoinGen.SpawnCoins(new Vector3(transform.position.x,transform.position.y + 1f,transform.position.z));

        }

        StartCoroutine(EnemyGenerator());
    }

    void Update()
    {
        //if (transform.position.y < -2.1 && 4.6)
            
    }

    public float GetRandomNumber(float minimum, float maximum)
    {
        Random random = new Random();
        return (float)random.NextDouble() * (maximum - minimum) + minimum;
    }
}
