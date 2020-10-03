using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class PlayerStat : MonoBehaviour
{
    public float life;
    public float speed;
    public float jumpForce;
    public int battery;
    public int key;
    public TMP_Text batteryText;

    private void Start()
    {
        
    }
    private void Update()
    {
        batteryText.text = "Battery : " + battery;
    }
}
