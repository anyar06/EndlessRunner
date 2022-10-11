using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainMenu : MonoBehaviour
{
    public void PlayGame()
    {
        Debug.Log("sgsg");

       UnityEngine.SceneManagement.SceneManager.LoadScene(1); 
    }
}
