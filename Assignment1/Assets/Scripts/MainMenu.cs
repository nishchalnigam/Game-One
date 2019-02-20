using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainMenu : MonoBehaviour {

    public string playLevel;

    public void PlayGame()
    {

        Application.LoadLevel(playLevel);

    }

    public void ExitGame()
    {
        Application.Quit();
    }
}
