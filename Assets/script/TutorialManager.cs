using UnityEngine;

public class TutorialManager : MonoBehaviour
{
    public GameObject tutorialPanel;

    void Start()
    {
        tutorialPanel.SetActive(true);

        Time.timeScale = 0f;

        Cursor.lockState = CursorLockMode.None;
        Cursor.visible = true;
    }

        public void StartMission()
    {
        Debug.Log("Start Mission");

        tutorialPanel.SetActive(false);

        Time.timeScale = 1f;

        Debug.Log("TimeScale = " + Time.timeScale);

        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
    }
}