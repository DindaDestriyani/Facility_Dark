using UnityEngine;

public class KeypadTrigger : MonoBehaviour
{
    public GameObject keypadPanel;
    public GameObject touchSystem;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            keypadPanel.SetActive(true);

            touchSystem.SetActive(false);

            Time.timeScale = 0f;
        }
    }
}