using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelComplete : MonoBehaviour
{
    public GameObject levelCompletePanel;
    public GameObject doorLockedPanel;

    private void OnTriggerEnter(Collider other)
    {
        if (!other.CompareTag("Player"))
            return;

        if (Keycard.totalKey >= 3)
        {
            levelCompletePanel.SetActive(true);

            Time.timeScale = 0f;
            Cursor.lockState = CursorLockMode.None;
            Cursor.visible = true;
        }
        else
        {
            doorLockedPanel.SetActive(true);
        }
    }

    public void CloseDoorPopup()
    {
        doorLockedPanel.SetActive(false);
    }

    public void NextLevel()
    {
        Time.timeScale = 1f;
        Keycard.totalKey = 0;

        SceneManager.LoadScene("Level 2");
    }

    public void MainMenu()
    {
        Time.timeScale = 1f;
        Keycard.totalKey = 0;

        SceneManager.LoadScene("Main menu");
    }
}