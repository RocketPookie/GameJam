using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManagerCredits : MonoBehaviour
{
    public void closeGame()
    {
        Application.Quit();
        Debug.Log("Quit");
    }
}
