using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerCollisions : MonoBehaviour
{
    public GameObject PanelUi;

    private int scorePoint = 0;
    public Text scoreText;
    void muerte()
    {
        //todo: para jego , guardar, abrir ui

        PanelUi.SetActive(true);
        Time.timeScale = 0;
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Enemy")
        {
            muerte();
        }
        if (collision.tag == "CollectableCorn")
        {
            scorePoint += 1;
            Debug.Log(scorePoint);
            collision.SendMessage("kaboom");
            scoreText.text = scorePoint.ToString();
        }
    }
}
