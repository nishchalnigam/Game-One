using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinGen : MonoBehaviour {


    public ObjectPooler coinPool;


	public void SpawnCoins (Vector3 startPos)
    {
        GameObject coin1 = coinPool.GetPooledObj();

        coin1.transform.position = startPos;
        coin1.SetActive(true);
    }
}
