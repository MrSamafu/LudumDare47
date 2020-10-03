using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemGenerator : MonoBehaviour
{
    public GameObject pile;
    public GameObject[] itemGenerator;

    private void Start()
    {
        int x = Random.Range(0, 9);
        Instantiate(pile, itemGenerator[x].transform);
    }
}
