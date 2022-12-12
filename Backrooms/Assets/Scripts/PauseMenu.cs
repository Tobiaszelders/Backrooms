using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseMenu : MonoBehaviour
{
    public static bool GameIsPauzed = false;

    public GameObject pauseMenuUI;
    public Player player;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (GameIsPauzed)
            {
                Resume();
            }
            else
            {
                Pause();
            }
        }
    }

    public void Resume()
    {
        pauseMenuUI.SetActive(false);
        Time.timeScale = 1f;
        GameIsPauzed = false;
        Cursor.lockState = CursorLockMode.Locked;
    }

    void Pause()
    {
        pauseMenuUI.SetActive(true);
        Time.timeScale = 0f;
        GameIsPauzed = true;
        Cursor.lockState = CursorLockMode.None;
    }

    public void SaveGame(Player player)
    {
        player.SavePlayer();
        Debug.Log(player.level);
        Debug.Log(player.health);
        //Debug.Log("Saved player data.\nPlayer level: " + player.level + "\nPlayer health: " + player.health);
    }

    public void LoadGame(Player player)
    {
        player.LoadPlayer();
        Debug.Log(player.level);
        Debug.Log(player.health);
    }

    public void QuitGame()
    {
        Application.Quit();
    }


}
