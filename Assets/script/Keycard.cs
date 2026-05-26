using UnityEngine;

public class Keycard : MonoBehaviour
{
    public static int totalKey = 0;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            totalKey++;
            Destroy(gameObject);

            Debug.Log("Key Collected: " + totalKey);
        }
    }
}