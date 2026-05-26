using UnityEngine;

public class ExitDoor : MonoBehaviour
{
    void Update()
    {
        if (Keycard.totalKey >= 3)
        {
            transform.Translate(Vector3.up * Time.deltaTime);
        }
    }
}