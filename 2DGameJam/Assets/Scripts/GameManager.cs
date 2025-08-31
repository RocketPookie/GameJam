using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{

    public GameObject PanelUiPause;
    public GameObject panelUiInstruciones;
    public void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);

        Time.timeScale = 1;
    }

    public void playGame()
    {
        Time.timeScale = 1;

        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    public void returnMainMenu()
    {
        SceneManager.LoadScene("MainMenu");
    }

    public void closeGame()
    {
        Application.Quit();
        Debug.Log("Quit");
    }
    public void pause()
    {
        Time.timeScale = 0;
        PanelUiPause.SetActive(true);
    }
    public void resume()
    {
        Time.timeScale = 1;

        PanelUiPause.SetActive(false);
    }

    public void endGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    public void instruccionesOn()
    {
        panelUiInstruciones.SetActive(true);
    }
}

