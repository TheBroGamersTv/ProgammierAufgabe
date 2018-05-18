using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour {

	public void StartGame()
    {
        //SceneManager.LoadScene("Game_Aufgabe.unity");
        Debug.Log("Starting to load scene");
    }
  
	public void ExitGame()
    {
        Application.Quit();
        Debug.Log("Quiting Game...");
    }
}
