using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ReturnToStartMenu : ButtonController
{
    override public void OnClick()
    {
        SceneManager.LoadScene("MainMenu");
    }
}
