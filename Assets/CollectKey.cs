using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectKey : MonoBehaviour
{
    public AudioClip collect;
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            GetComponent<AudioSource>().PlayOneShot(collect);
            Destroy(gameObject);
            GameObject.Find("Player").GetComponent<PlayerStat>().key += 1;
        }
    }
}
