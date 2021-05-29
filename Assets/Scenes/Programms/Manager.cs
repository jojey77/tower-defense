using UnityEngine;
using System.Collections;

public class Manager : MonoBehaviour
{

    public static bool GameIsOver = false;

    public GameObject gameOVerUI;

    private void Start()
    {
        GameIsOver = false;
    }
    void Update()
    {

        if (GameIsOver)
        {
            return;
        }

        if (Input.GetKeyDown("e"))
        {
            EndGame();
        }

        if (PlayerStats.Lives <= 0)
        {
            EndGame();
        }

    }

    void EndGame()
    {
        GameIsOver = true;

        gameOVerUI.SetActive(true);
    }
}
