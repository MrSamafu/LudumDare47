using System;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuSceneManager : MonoBehaviour
{
   public void PlayGame()
    {
        SceneManager.LoadScene("LevelDesign");
    }
    public void BackToMenu()
    {
        SceneManager.LoadScene("Menu");
    }
    public void GoToCredit()
    {
        SceneManager.LoadScene("Credit");
    }
}
