using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UseKey : MonoBehaviour
{
    // Start is called before the first frame update
    private void OnTriggerStay(Collider other)
    {
        if(other.gameObject.tag == "Player")
        {
            if(Input.GetKeyDown(KeyCode.E) && GameObject.Find("Player").GetComponent<PlayerStat>().key > 0)
            {
                if(GetComponentInParent<Animator>().GetBool("open") == true)
                {
                    Debug.Log("Door is already Open");
                }
                else
                {
                    GetComponentInParent<Animator>().SetBool("open", true);
                    GameObject.Find("Player").GetComponent<PlayerStat>().key -= 1;

                }
            }
        }
    }
}
