using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Menus : MonoBehaviour
{
    
    public GameObject mainMenu;
    public GameObject setingsMenu;
    public GameObject pauseMenu;
    public GameObject shop;
    public GameObject game;

    public void StartGame()
    {
        SceneManager.LoadScene("Runner");
    }

    public void SetingMenuOpen()
    {
        setingsMenu.SetActive(true);
        mainMenu.SetActive(false);
    }

    public void SetingMenuClose()
    {
        setingsMenu.SetActive(false);
        mainMenu.SetActive(true);
    }

    public void ShopMenuOpen()
    {
        shop.SetActive(true);
        mainMenu.SetActive(false);
    }

    public void ShopMenuClose()
    {
        shop.SetActive(false);
        mainMenu.SetActive(true);
    }

    public void pauseMenuOpen()
    {
        pauseMenu.SetActive(true);
        game.SetActive(false);
        Time.timeScale = 0.0f;
    }

    public void resumeMenu()
    {
        pauseMenu.SetActive(false);
        game.SetActive(true);
        Time.timeScale = 1.0f;
    }

    public void LoseRestart()
    {
        SceneManager.LoadScene("Runner");
    }

    public void MainMenuGo()
    {
        SceneManager.LoadScene("MainMenu");
    }

    public void Exit()
    {
        Application.Quit();
    }

}
