using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Timer : MonoBehaviour
{
    private float count;
    private int seconde = 0;
    private int minutes = 0;
    void Start()
    {
        count = 0f;
    }

    // Update is called once per frame
    void Update()
    {
        count += Time.deltaTime;
        seconde = Convert.ToInt32(count);
        if(count >= 60)
        {
            count = 0f;
            minutes += 1;
        }
        PlayerPrefs.SetString("Time", "" + minutes + ":" + seconde);
    }
}
