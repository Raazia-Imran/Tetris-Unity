using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;

public class MAINMENU : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public void PlayGame() {
        SceneManager.LoadSceneAsync(1);
        

    }

    public void QuitGame()
    {
        Application.Quit();


    }
}
