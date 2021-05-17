using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameManagerNave : MonoBehaviour
{
    public static GameManagerNave instance;
    public int puntaje;
    public TextMeshProUGUI puntajeUI;
    public CanvasGroup restartPanel;
    public GameObject player;

    private void Awake()
    {
        instance = this;
    }

    private void Update()
    {
        puntajeUI.text = puntaje.ToString();
        if(player == null)
        {
            ShowRestartPanel();
        }
    }

    public void ShowRestartPanel()
    {
        restartPanel.alpha = 1;
        restartPanel.interactable = true;
        restartPanel.blocksRaycasts = true;
    }

    public void RestartLevel()
    {
        SceneManager.LoadScene(0);
    }
}
