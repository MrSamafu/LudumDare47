using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;


public class TheEnd : MonoBehaviour
{
    public TMP_Text score;
    void Start()
    {
        score.text = "Score : " + PlayerPrefs.GetString("Time");

    }
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            SceneManager.LoadScene("Credit");
        }
    }
}
