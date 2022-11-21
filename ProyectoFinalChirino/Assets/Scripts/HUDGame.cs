using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class HUDGame : MonoBehaviour
{
    // Start is called before the first frame update
    public Text textDistacia;
    public Text textVida;
    public static int distaciaRecorrida=0;

    [Header ("Barra de vida")]
    public Image barraVida;
    public float vidaActual;
    public float maxVida=100f;
    [Header ("PAUSA")]
    private bool pausaActiva;
    public GameObject menuPausa;
    public GameObject uiElementGame;

    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        textDistacia.text= "Tiempo caminado:" + distaciaRecorrida.ToString();
        vidaActual=Player.vidaJugador;
        barraVida.fillAmount= vidaActual/maxVida;
        TogglePausa();
        
    }
    public void TogglePausa()
    {
        if(Input.GetKeyDown(KeyCode.Escape))
        {
            if(pausaActiva)
            {
                ResumeGame();
            }else
            {
                PauseGame();

            }
        }
    }
    void PauseGame()
    {
        menuPausa.SetActive(true);
        uiElementGame.SetActive(false);
        pausaActiva=true;
        Time.timeScale=0;

    }
    void ResumeGame()
    {
        menuPausa.SetActive(false);
        uiElementGame.SetActive(true);
        pausaActiva=false;
        Time.timeScale=1;

    }
    public void VolverAlMenu()
    {
        SceneManager.LoadScene(0);
    }
    public void ExitGame()
    {
        Application.Quit();

    }
}
