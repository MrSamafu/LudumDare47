using System;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuSceneManager : MonoBehaviour
{
   public void PlayGame()
    {
        SceneManager.LoadScene("LevelDesign");
    }
}
