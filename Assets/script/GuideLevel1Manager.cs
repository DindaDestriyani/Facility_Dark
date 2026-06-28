using UnityEngine;
using UnityEngine.SceneManagement;

public class GuideLevel1Manager : MonoBehaviour
{
    public void StartLevel1()
    {
        SceneManager.LoadScene("Level1");
    }
}