using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DeathMenu : MonoBehaviour
{
    private static GameObject _deathMenu;

    void Start()
    {
        _deathMenu = GameObject.Find("DeathMenu");
        _deathMenu.SetActive(false);
    }

    public void Retry()
    {
        SceneManager.LoadScene("Level1");
    }

    public void MainMenu()
    {
        SceneManager.LoadScene("CharacterSelect");
    }

    public static void OpenDeathMenu()
    {
        _deathMenu.SetActive(true);
    }
}
