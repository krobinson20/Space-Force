using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public abstract class TextController : MonoBehaviour
{
    private EndGameState endState;
    public EndGameState EndState
    {
        get { return endState; }
    }
    public Text text;

    virtual public void Awake() { }
    virtual public void SetText() { }
}
