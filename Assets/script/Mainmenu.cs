using UnityEngine;
using UnityEngine.SceneManagement;

#if UNITY_EDITOR
using UnityEditor;
#endif

public class MainMenu : MonoBehaviour
{
    public void PlayGame()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene("Level 1");
    }

    public void OpenSetting()
    {
        Debug.Log("Open Setting");
    }

    public void ExitGame()
    {
        Debug.Log("Game Keluar");

#if UNITY_EDITOR
        // Berhenti Play Mode jika sedang di Unity Editor
        EditorApplication.isPlaying = false;
#else
        // Menutup aplikasi jika sudah di-build
        Application.Quit();
#endif
    }
}