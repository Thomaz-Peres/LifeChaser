using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrocaCenas : MonoBehaviour
{
    public void ChamaCenaDaFase()
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene("EscolhaFases");
    }

    public void ChamaCenaInGame()
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene("InGame");
    }
    public void ChamaCenaIniciar()
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene("Start_menu");
    }
}
