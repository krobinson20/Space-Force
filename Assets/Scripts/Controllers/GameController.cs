using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameController : MonoBehaviour
{
    [Header("Game Controllers")]
    [SerializeField] private PlayController playCont;
    [SerializeField] private UIController uiCont;

    public enum States {
        Playing,
        GameOver,
        MainMenu
    }
    [Header("Flags")]
    [SerializeField] public States currentState;

    // Start is called before the first frame update
    void Awake()
    {
        playCont = GetComponent<PlayController>();
        uiCont = GetComponent<UIController>();
        currentState = States.MainMenu;
    }

    public void SetState(States state)
    {
        switch (state)
        {
            case States.MainMenu:
                SceneManager.LoadScene("MainMenu");
                currentState = States.MainMenu;
                break;
            case States.Playing:
                SceneManager.LoadScene("Space");
                currentState = States.Playing;
                break;
            case States.GameOver:
                SceneManager.LoadScene("GameOverMenu");
                currentState = States.GameOver;
                break;
        }
    }
}
