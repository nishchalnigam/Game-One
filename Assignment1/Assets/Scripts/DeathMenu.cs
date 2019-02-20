using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeathMenu : MonoBehaviour {

    public string mainLevel;

    public void RestartGame()
    {

        Application.LoadLevel("SampleScene");

    }

    public void QuitToMain()
    {
        Application.LoadLevel(mainLevel);
    }


}
