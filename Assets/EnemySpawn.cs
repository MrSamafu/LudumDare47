using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawn : MonoBehaviour
{
    public GameObject[] enemy;
    private void Start()
    {
        int x = Random.Range(0, 2);
        Instantiate(enemy[x], transform);
    }
}
