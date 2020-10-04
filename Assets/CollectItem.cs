using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectItem : MonoBehaviour
{
    public AudioClip collect;
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            GetComponent<AudioSource>().PlayOneShot(collect);
            GameObject.Find("Player").GetComponent<PlayerStat>().battery += 1;
            Destroy(gameObject);
        }
    }
}
