using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DammageToPlayer : MonoBehaviour
{
    public AudioClip damageSound;
    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag == "Player")
        {
            GameObject.Find("Player").GetComponent<PlayerStat>().life -= 10;
            GetComponent<AudioSource>().PlayOneShot(damageSound);

        }
    }
}
