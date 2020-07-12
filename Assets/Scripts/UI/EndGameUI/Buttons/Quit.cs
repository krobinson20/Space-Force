using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Quit : ButtonController
{
    override public void OnClick()
    {
        Application.Quit();
    }
}
