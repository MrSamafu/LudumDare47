using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DammageToPlayer : MonoBehaviour
{
    // Start is called before the first frame update
    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag == "Player")
        {
            GameObject.Find("Player").GetComponent<PlayerStat>().life -= 10;
            Debug.Log(GameObject.Find("Player").GetComponent<PlayerStat>().life);
        }
    }
}
