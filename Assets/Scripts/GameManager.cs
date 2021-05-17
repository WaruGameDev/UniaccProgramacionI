using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;
    public float puntaje, fruitMissed;
    public TextMeshProUGUI puntajeText;
    public GameObject panelReset;

    private void Awake()
    {
        instance = this;
    }
    private void Update()
    {
        puntajeText.text = puntaje.ToString();
        if (fruitMissed > 10)
        {
            Lost();
        }        
    }   
    public void Lost()
    {
        panelReset.SetActive(true);
        GameObject.FindGameObjectWithTag("Player").GetComponent<MovementTwoDirection>().enabled = false;
    }
    public void ResetGame()
    {
        puntaje = 0;
        fruitMissed = 0;
        SceneManager.LoadScene(0);
    }    
}
