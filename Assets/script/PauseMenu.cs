using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour
{
    public GameObject pausePanel;
    public GameObject touchSystem;   // Tambahkan ini

    bool isPaused = false;

    public void PauseGame()
    {
        pausePanel.SetActive(true);

        touchSystem.SetActive(false); // Matikan area swipe

        Time.timeScale = 0f;

        Cursor.lockState = CursorLockMode.None;
        Cursor.visible = true;

        isPaused = true;
    }

    public void ResumeGame()
    {
        pausePanel.SetActive(false);

        touchSystem.SetActive(true); // Aktifkan lagi

        Time.timeScale = 1f;

        Cursor.lockState = CursorLockMode.None;
         Cursor.visible = true;

        isPaused = false;
    }

    public void MainMenu()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene("Main menu");
    }
}