using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectPooler : MonoBehaviour {

    public GameObject pooledObject;
    public GameObject pooledObject2;
    public GameObject pooledObject3;
    public GameObject pooledObject4;


    public int poolAmount;

    public List<GameObject> pooledObjects;


	// Use this for initialization
	void Start () {
        pooledObjects = new List<GameObject>();

        for(int i = 0; i < poolAmount; i++)
        {
            GameObject obj = (GameObject)Instantiate(pooledObject);
            obj.SetActive(false);
            pooledObjects.Add(obj);
        }
        for (int i = 0; i < poolAmount; i++)
        {
            GameObject obj = (GameObject)Instantiate(pooledObject2);
            obj.SetActive(false);
            pooledObjects.Add(obj);
        }
        for (int i = 0; i < poolAmount; i++)
        {
            GameObject obj = (GameObject)Instantiate(pooledObject3);
            obj.SetActive(false);
            pooledObjects.Add(obj);
        }
        for (int i = 0; i < poolAmount; i++)
        {
            GameObject obj = (GameObject)Instantiate(pooledObject4);
            obj.SetActive(false);
            pooledObjects.Add(obj);
        }
    }
	
    //

    public GameObject GetPooledObj()
    {
        for(int i = 0; i < pooledObjects.Count; i++)
        {
            if(!pooledObjects[i].activeInHierarchy)
            {
                return pooledObjects[i];
            }
        }

        GameObject obj = (GameObject)Instantiate(pooledObject);
        obj.SetActive(false);
        pooledObjects.Add(obj);

        return obj;
    }

    public GameObject GetPooledObj2()
    {
        for (int i = 0; i < pooledObjects.Count; i++)
        {
            if (!pooledObjects[i].activeInHierarchy)
            {
                return pooledObjects[i];
            }
        }

        GameObject obj = (GameObject)Instantiate(pooledObject2);
        obj.SetActive(false);
        pooledObjects.Add(obj);

        return obj;


    }
    public GameObject GetPooledObj3()
    {
        for (int i = 0; i < pooledObjects.Count; i++)
        {
            if (!pooledObjects[i].activeInHierarchy)
            {
                return pooledObjects[i];
            }
        }

        GameObject obj = (GameObject)Instantiate(pooledObject3);
        obj.SetActive(false);
        pooledObjects.Add(obj);

        return obj;


    }
    public GameObject GetPooledObj4()
    {
        for (int i = 0; i < pooledObjects.Count; i++)
        {
            if (!pooledObjects[i].activeInHierarchy)
            {
                return pooledObjects[i];
            }
        }

        GameObject obj = (GameObject)Instantiate(pooledObject4);
        obj.SetActive(false);
        pooledObjects.Add(obj);

        return obj;


    }
}
