using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UseKey : MonoBehaviour
{
    public GameObject bubble;
    private void OnTriggerStay(Collider other)
    {
        if(other.gameObject.tag == "Player")
        {
            if(Input.GetKeyDown(KeyCode.E) && GameObject.Find("Player").GetComponent<PlayerStat>().key > 0)
            {
                if(GetComponentInParent<Animator>().GetBool("open") == true)
                {
                    Debug.Log("Door is already Open");
                    bubble.SetActive(false);
                }
                else
                {
                    GetComponentInParent<Animator>().SetBool("open", true);
                    GameObject.Find("Player").GetComponent<PlayerStat>().key -= 1;

                }
            }
        }
    }
    private void OnTriggerEnter(Collider other)
    {
        if(GameObject.Find("Player").GetComponent<PlayerStat>().key > 0)
        {
            bubble.SetActive(true);
        }
    }
    private void OnTriggerExit(Collider other)
    {
            bubble.SetActive(false);        
    }
}
