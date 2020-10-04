using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GateScript : MonoBehaviour
{
    public GameObject[] lightGate;
    public Material matLightOn;
    public Material matLightOff;

    private PlayerStat playerStat;

    private void Start()
    {
        playerStat = GameObject.Find("Player").GetComponent<PlayerStat>();
        foreach (GameObject lightInit in lightGate)
        {
            lightInit.GetComponent<MeshRenderer>().material = matLightOff;
        }

    }
    private void Update()
    {
        int battery = playerStat.battery;

        if(battery > 0 && battery <= 5)
        {
            for (int i = 0; i < battery;i++)
            {
                lightGate[i].GetComponent<MeshRenderer>().material = matLightOn;
            }
        }
    }
    private void OnTriggerStay(Collider other)
    {
        if(other.gameObject.name == "Player")
        {
            if (Input.GetKey(KeyCode.E))
            {
                if(playerStat.battery >= 5)
                {
                    SceneManager.LoadScene("WinScene");
                }
            }
        }
    }
}
