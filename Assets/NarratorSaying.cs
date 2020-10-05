using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class NarratorSaying : MonoBehaviour
{
    public TMP_Text narratorSay;
    public Scrollbar content;
    private int count;
    public string[] sentence;

    void Start()
    {
        count = 0;
        StartCoroutine(speak());
    }
    IEnumerator speak()
    {
        yield return new WaitForSeconds(Random.Range(5f, 10f));
        narratorSay.text = narratorSay.text + "-" + sentence[count] + "<br>";
        count++;
        if(count == sentence.Length)
        {

        }
        else
        {
            StartCoroutine(speak());
            content.value -= 0.020f;
        }
    }
}
