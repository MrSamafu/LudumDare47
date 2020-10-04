using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class PlayerStat : MonoBehaviour
{
    public float life;
    public float speed;
    public float jumpForce;
    public int battery;
    public int key;
    public TMP_Text batteryText;
    public Image lifeBar;
    public TMP_Text keyText;
    public GameObject gameOver;

    private void Update()
    {
        keyText.text = "Key : " + key + "/2";
        lifeBar.fillAmount = ((life * 100)/100)/100;
        
        if(life <= 0)
        {
            gameOver.SetActive(true);
            GetComponent<PlayerMove>().enabled = false;
            GetComponent<SpriteRenderer>().enabled = false;
            GetComponent<Rigidbody>().isKinematic = true;

        }

    }
}
