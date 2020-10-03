using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeyGenerator : MonoBehaviour
{
    public GameObject key;
    public GameObject[] keySpawner;

    private void Start()
    {
        if(GameObject.Find("Player").GetComponent<PlayerStat>().key < 2)
        {
            int x = Random.Range(0, keySpawner.Length - 1);
            Instantiate(key, keySpawner[x].transform);
        }
        
    }
}
