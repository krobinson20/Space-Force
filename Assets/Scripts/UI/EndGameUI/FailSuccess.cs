using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FailSuccess : TextController
{
    public override void Awake()
    {
        text = GameObject.Find("GameOverHead").GetComponent<Text>();
    }

    public override void SetText()
    {
        //if ()
    }
}
