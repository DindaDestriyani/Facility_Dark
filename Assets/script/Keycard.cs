using UnityEngine;

public class Keycard : MonoBehaviour
{
    public static int totalKey = 0;

    private void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("Player"))
        {
            totalKey++;

            FindObjectOfType<KeyPopupUI>().ShowPopup(totalKey,3);

            Destroy(gameObject);
        }
    }
}