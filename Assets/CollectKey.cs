using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectKey : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            Destroy(gameObject);
            GameObject.Find("Player").GetComponent<PlayerStat>().key += 1;
        }
    }
}
