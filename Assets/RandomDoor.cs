using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomDoor : MonoBehaviour
{
    public GameObject[] doors;
    

    void Start()
    {
        foreach(GameObject door in doors)
        {
            int x = Random.Range(0, 2);
            if (x == 0)
            {
                door.GetComponent<Animator>().SetBool("open", true);
            }
            else if (x == 1)
            {
                door.GetComponent<Animator>().SetBool("open", false);

            }
            Debug.Log(x);
        }
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
