using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FailSuccess : TextController
{
    private EndGameState endState;
    public override void Awake()
    {
        text = GameObject.Find("GameOverHead").GetComponent<Text>();
        endState = EndState;
    }

    public override void SetText()
    {
        //if ()
    }
}
