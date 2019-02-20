using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = System.Random;

public class EnemyPlaneSpawner : MonoBehaviour {


    public GameObject[] prefabs;

    public ObjectPooler leObjPool;

    public float delay = 2.0f;

    public bool active = true;

	// Use this for initialization
	void Start () {

        StartCoroutine(EnemyGenerator());
		
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
